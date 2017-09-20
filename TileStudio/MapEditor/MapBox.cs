using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

using TileStudio.Core;
using System.ComponentModel;

namespace TileStudio.MapEditor
{
    public class MapBox : PictureBox
    {
        public Map Map;
        public bool DrawOnlyCurrentLayer = false;
        public int MapLayer = 0;
        public MapLayer CurrentMapLayer
        {
            get { return Map.Layers[MapLayer]; }
        }

        private int PixelWidth;
        private int PixelHeight;
        private int RenderedTileWidth;
        private int RenderedTileHeight;

        public MainWindow EditorWindow;
        public Tileset Tileset;
        public Palette Palette;

        public const int MinZoom = 1;
        public const int MaxZoom = 4;
        private int ZoomLevel;
        public bool ShowGrid = true;
        public bool ShowViewport = false;
        public bool ShowBoundary = true;
        private Pen GridPen;
        private Color GridColor = Color.FromArgb(50, 255, 255, 255);
        private Color ViewportColor = Color.FromArgb(100, 255, 0, 0);
        public int ViewportWidth = Map.DefaultWidth / 2;
        public int ViewportHeight = Map.DefaultHeight / 2;

        private FastBitmap MapImage;
        private HashSet<Point> InvalidatedMapPositions;

        public new Image BackgroundImage = null;
        private Rectangle SelectedArea = Rectangle.Empty;

        public enum OperationMode
        {
            Edit, Select
        }

        public OperationMode Mode = OperationMode.Edit;

        public MapBox()
        {
            DoubleBuffered = true;
            GridPen = new Pen(GridColor);
            GridPen.DashStyle = DashStyle.Solid;

            InvalidatedMapPositions = new HashSet<Point>();

            SetZoom(2);

            Click += MapBox_Click;
            MouseDown += MapBox_Click;
            MouseMove += MapBox_Click;
            MouseLeave += MapBox_MouseLeave;
        }

        public void SelectArea(int x, int y, int w, int h)
        {
            SelectedArea = new Rectangle(x, y, w, h);
        }

        public void DeselectArea()
        {
            SelectedArea = Rectangle.Empty;
        }

        public Rectangle GetSelectedArea()
        {
            return SelectedArea;
        }

        public void CopySelectedAreaTo(int dstX, int dstY, bool eraseSrc)
        {
            int srcX = SelectedArea.X;
            int srcY = SelectedArea.Y;
            int initialSrcX = srcX;
            int initialDstX = dstX;

            for (int i = 0; i < SelectedArea.Width * SelectedArea.Height; i++)
            {
                GameObject copiedObject = CurrentMapLayer.GetObject(srcX, srcY);
                CurrentMapLayer.SetObject(dstX, dstY, new GameObject(copiedObject));

                srcX++;
                dstX++;

                if (srcX >= SelectedArea.Width)
                {
                    srcX = initialSrcX;
                    srcY++;
                    dstX = initialDstX;
                    dstY++;
                }
            }

            if (eraseSrc)
                EraseSelectedArea();
        }

        public void EraseSelectedArea()
        {
            int x = SelectedArea.X;
            int y = SelectedArea.Y;
            int initialX = x;

            for (int i = 0; i < SelectedArea.Width * SelectedArea.Height; i++)
            {
                CurrentMapLayer.GetObject(x, y).Clear();
                x++;

                if (x >= SelectedArea.Width)
                {
                    x = initialX;
                    y++;
                }
            }
        }

        public Rectangle GetSelectedAreaInPixels()
        {
            return new Rectangle
            (
                SelectedArea.X * RenderedTileWidth,
                SelectedArea.Y * RenderedTileHeight,
                SelectedArea.Width * RenderedTileWidth,
                SelectedArea.Height * RenderedTileHeight
            );
        }

        public void SaveSelectedAreaAsImage(string filename)
        {
            Bitmap image = MapImage.Bitmap.Clone(
                GetSelectedAreaInPixels(), MapImage.Bitmap.PixelFormat);

            image.Save(filename);
        }

        public void SetZoom(int level)
        {
            if (level < MinZoom)
                level = MinZoom;
            else if (level > MaxZoom)
                level = MaxZoom;

            ZoomLevel = level;
            PixelWidth = level;
            PixelHeight = level;
            RenderedTileWidth = Tile.Width * PixelWidth;
            RenderedTileHeight = Tile.Height * PixelHeight;

            AdjustSize();
            InvalidateAllMapPositionsAndRefresh();
        }

        public void ZoomIn()
        {
            int level = ZoomLevel + 1;
            if (level <= MaxZoom)
                SetZoom(level);
        }

        public void ZoomOut()
        {
            int level = ZoomLevel - 1;
            if (level >= MinZoom)
                SetZoom(level);
        }

        private void MapBox_MouseLeave(object sender, EventArgs e)
        {
            if (EditorWindow != null)
                EditorWindow.ClearStatusBar();
        }

        public void InvalidateAllMapPositionsAndRefresh()
        {
            if (Map != null)
            {
                for (int y = 0; y < Map.Height; y++)
                    for (int x = 0; x < Map.Width; x++)
                        InvalidatedMapPositions.Add(new Point(x, y));
            }

            Refresh();
        }

        private void MapBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mev = (MouseEventArgs)e;
            Point pos = Tile.TranslateMousePosToTilePos(mev.X, mev.Y, PixelWidth, PixelHeight);
            GameObject o = CurrentMapLayer.GetObject(pos.X, pos.Y);
            if (o == null)
                return;

            EditorWindow.SetStatusBar(
                "Map size: " + Map.Width + "," + Map.Height + " " +
                "(" + (Map.Width * Tile.Width) + "," + (Map.Height * Tile.Height) + ") " +
                "Object: " + o.GetHashCode() + " at " + pos.X + "," + pos.Y + " " + o.ToString());

            bool ctrl = ModifierKeys == Keys.Control;

            if (Mode == OperationMode.Edit)
            {
                if (mev.Button == MouseButtons.Left)
                {
                    SetObjectTile(pos.X, pos.Y, EditorWindow.TileGraphics);
                    SetObjectData(pos.X, pos.Y, EditorWindow.ObjectBytes);
                }
                else if (mev.Button == MouseButtons.Right)
                {
                    GrabObjectTile(pos.X, pos.Y);
                    GrabObjectData(pos.X, pos.Y);
                }
            }
            else if (Mode == OperationMode.Select)
            {
                if (mev.Button == MouseButtons.Left)
                {
                    if (SelectedArea == Rectangle.Empty)
                    {
                        SelectedArea.Location = pos;
                        SelectedArea.Size = new Size(1, 1);
                    }
                    else
                    {
                        int w = pos.X - SelectedArea.X + 1;
                        int h = pos.Y - SelectedArea.Y + 1;

                        SelectedArea.Size = new Size(w > 0 ? w : 1, h > 0 ? h : 1);
                    }

                    Refresh();
                }
                if (mev.Button == MouseButtons.Right)
                {
                    DeselectArea();
                    Refresh();
                }
            }
        }

        private void SetObjectTile(int x, int y, TileGraphics tile)
        {
            if (x < 0 || y < 0 || x >= Map.Width || y >= Map.Height)
                return;

            CurrentMapLayer.SetObjectTile(x, y, tile);

            InvalidatedMapPositions.Add(new Point(x, y));
            Refresh();
        }

        private void GrabObjectTile(int x, int y)
        {
            EditorWindow.TileGraphics = CurrentMapLayer.GetObject(x, y).Graphics;
        }

        private void SetObjectData(int x, int y, List<byte> bytes)
        {
            if (x < 0 || y < 0 || x >= Map.Width || y >= Map.Height)
                return;

            CurrentMapLayer.SetObjectData(x, y, bytes);
        }

        private void GrabObjectData(int x, int y)
        {
            EditorWindow.ObjectBytes = CurrentMapLayer.GetObject(x, y).Bytes;
        }

        public void SetMap(Map map)
        {
            Map = map;
            AdjustSize();
        }

        public void AdjustSize()
        {
            if (Map == null)
                return;

            Size = new Size(Map.Width * RenderedTileWidth, Map.Height * RenderedTileHeight);
            MapImage = new FastBitmap(Size.Width, Size.Height);
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Map == null || MapImage == null)
                return;

            Graphics g = Graphics.FromImage(MapImage.Bitmap);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.SmoothingMode = SmoothingMode.HighSpeed;
            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            g.CompositingQuality = CompositingQuality.HighSpeed;

            if (BackgroundImage != null)
            {
                g.Clear(BackColor);
                g.DrawImage(BackgroundImage, 1, 1, MapImage.Bitmap.Width + 1, MapImage.Bitmap.Height + 1);
                DrawMap(g);
            }
            else
                DrawMapOnlyWhereNeeded(g);

            e.Graphics.DrawImage(MapImage.Bitmap, 0, 0);
            InvalidatedMapPositions.Clear();

            if (ShowGrid)
                DrawGrid(e.Graphics);
            if (ShowBoundary)
                DrawBoundary(e.Graphics);
            if (SelectedArea != Rectangle.Empty)
                DrawSelectedAreaIndicator(e.Graphics);
        }

        private void DrawGrid(Graphics g)
        {
            int x = 0;
            int y = 0;
            int height = Map == null ? Map.DefaultHeight : Map.Height;
            int width = Map == null ? Map.DefaultWidth : Map.Width;

            for (int i = 0; i < height; i++)
            {
                if (ShowViewport)
                {
                    if (i > 0 && i % ViewportHeight == 0)
                        GridPen.Color = ViewportColor;
                    else
                        GridPen.Color = GridColor;
                }
                else
                    GridPen.Color = GridColor;

                g.DrawLine(GridPen, x, y, x + (width * RenderedTileWidth), y);
                y += RenderedTileHeight;
            }

            x = 0;
            y = 0;

            for (int i = 0; i < width; i++)
            {
                if (ShowViewport)
                {
                    if (i > 0 && i % ViewportWidth == 0)
                        GridPen.Color = ViewportColor;
                    else
                        GridPen.Color = GridColor;
                }
                else
                    GridPen.Color = GridColor;

                g.DrawLine(GridPen, x, y, x, y + (height * RenderedTileHeight));
                x += RenderedTileWidth;
            }

            g.DrawRectangle(GridPen, -1, -1, 
                width * RenderedTileWidth, height * RenderedTileHeight);
        }

        private void DrawBoundary(Graphics g)
        {
            int height = Map == null ? Map.DefaultHeight : Map.Height;
            int width = Map == null ? Map.DefaultWidth : Map.Width;

            GridPen.Color = ViewportColor;

            g.DrawRectangle(GridPen, -1, -1,
                width * RenderedTileWidth, height * RenderedTileHeight);
        }

        private void DrawSelectedAreaIndicator(Graphics g)
        {
            Rectangle selectedAreaIndicatorRect = new Rectangle
            (
                SelectedArea.X * RenderedTileWidth, 
                SelectedArea.Y * RenderedTileHeight, 
                SelectedArea.Width * RenderedTileWidth, 
                SelectedArea.Height * RenderedTileHeight
            );

            Pen indicatorPen = new Pen(Color.FromArgb(100, 0, 0, 255));
            SolidBrush indicatorBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 255));

            g.CompositingMode = CompositingMode.SourceOver;
            g.FillRectangle(indicatorBrush, selectedAreaIndicatorRect);
            g.DrawRectangle(indicatorPen, selectedAreaIndicatorRect);
            g.CompositingMode = CompositingMode.SourceCopy;
        }

        private void DrawMap(Graphics g)
        {
            for (int y = 0; y < Map.Height; y++)
                for (int x = 0; x < Map.Width; x++)
                    DrawMapObject(g, x, y);
        }

        private void DrawMapOnlyWhereNeeded(Graphics g)
        {
            foreach (Point pos in InvalidatedMapPositions)
                DrawMapObject(g, pos.X, pos.Y);
        }

        private void ClearTile(Graphics g, int x, int y)
        {
            using (Brush brush = new SolidBrush(Palette[Map.BackColor]))
                g.FillRectangle(brush, x * RenderedTileWidth, y * RenderedTileHeight, 
                    RenderedTileWidth, RenderedTileHeight);
        }

        private void DrawMapObject(Graphics g, int x, int y)
        {
            if (BackgroundImage == null)
                ClearTile(g, x, y);

            if (DrawOnlyCurrentLayer)
                DrawMapObjectAtLayer(g, MapLayer, x, y);
            else
            {
                for (int i = 0; i < Map.Layers.Count; i++)
                    DrawMapObjectAtLayer(g, i, x, y);
            }
        }

        private void DrawMapObjectAtLayer(Graphics g, int layer, int x, int y)
        {
            TileGraphics tileGfx = Map.Layers[layer].GetObject(x, y).Graphics;
            Tileset[tileGfx.Index].Draw(g, x, y, PixelWidth, PixelHeight,
                Palette[tileGfx.Color1], Palette[tileGfx.Color2], Palette[tileGfx.Color3], true);
        }

        public void SaveScreenshot(string filename)
        {
            bool prevShowGrid = ShowGrid;
            ShowGrid = false;
            InvalidateAllMapPositionsAndRefresh();

            MapImage.Bitmap.Save(filename);

            ShowGrid = prevShowGrid;
            InvalidateAllMapPositionsAndRefresh();
        }
    }
}
