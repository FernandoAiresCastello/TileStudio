using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using TileStudio.Core;

namespace TileStudio.MapEditor
{
    public class TilesetBox : PictureBox
    {
        public MainWindow EditorWindow { set; get; }
        public Tileset Tileset { set; get; }

        public int PageCount
        {
            get { return Tileset.Count / PageSize; }
        }

        public const int PixelWidth = 2;
        public const int PixelHeight = 2;
        public const int RenderedTileWidth = Tile.Width * PixelWidth;
        public const int RenderedTileHeight = Tile.Height * PixelHeight;
        public const int MaxTilesInRow = 16;
        public const int MaxTilesInCol = 16;
        public const int PageSize = 256;

        public int SelectedPage = 0;
        public bool ShowGrid = false;

        private Pen GridPen;

        public TilesetBox()
        {
            BackColor = Color.White;
            GridPen = new Pen(Brushes.LightGray);
            GridPen.DashStyle = DashStyle.Dot;

            Click += TilesetBox_Click;
            DoubleClick += TilesetBox_DoubleClick;
            MouseEnter += TilesetBox_MouseEnter;
            MouseMove += TilesetBox_MouseMove;
            MouseLeave += TilesetBox_MouseLeave;
        }

        private void TilesetBox_MouseLeave(object sender, EventArgs e)
        {
            if (EditorWindow != null)
                EditorWindow.ClearStatusBar();
        }

        private void TilesetBox_MouseMove(object sender, MouseEventArgs e)
        {
            EditorWindow.SetStatusBar("Tile index: " + GetTileIndexUnderMouseCursor(e.X, e.Y));
        }

        private void TilesetBox_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs mev = (MouseEventArgs)e;

            if (mev.Button == MouseButtons.Left)
                EditorWindow.EditSelectedTile();
        }

        private void TilesetBox_MouseEnter(object sender, EventArgs e)
        {
            Focus();
        }

        public string GetPageIndicator()
        {
            return (SelectedPage + 1) + " / " + PageCount;
        }

        private int GetTileIndexUnderMouseCursor(int mouseX, int mouseY)
        {
            Point pos = Tile.TranslateMousePosToTilePos(mouseX, mouseY, PixelWidth, PixelHeight);

            return (pos.Y * MaxTilesInRow + pos.X) + (PageSize * SelectedPage);
        }

        private void TilesetBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mev = (MouseEventArgs)e;

            if (mev.Button == MouseButtons.Left)
                EditorWindow.TileIndex = GetTileIndexUnderMouseCursor(mev.X, mev.Y);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Size = new Size(MaxTilesInRow * PixelWidth * Tile.Width, MaxTilesInCol * PixelHeight * Tile.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Tileset == null)
                return;

            DrawTileset(e.Graphics);
            if (ShowGrid)
                DrawGrid(e.Graphics);
        }
        
        public void NextPage()
        {
            SelectedPage++;
            if (SelectedPage >= PageCount)
                SelectedPage = 0;

            Refresh();
            EditorWindow.UpdateTilesetPageIndicator();
        }

        public void PrevPage()
        {
            SelectedPage--;
            if (SelectedPage < 0)
                SelectedPage = PageCount - 1;

            Refresh();
            EditorWindow.UpdateTilesetPageIndicator();
        }

        private void DrawTileset(Graphics g)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < PageSize; i++)
            {
                int index = i + (PageSize * SelectedPage);
                Tile tile = Tileset[index];
                tile.Draw(g, x, y, PixelWidth, PixelHeight, Color.Black, Color.Gray, Color.LightGray, true);

                x++;
                if (x >= MaxTilesInRow)
                {
                    x = 0;
                    y++;
                }
            }
        }

        private void DrawGrid(Graphics g)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < MaxTilesInCol; i++)
            {
                g.DrawLine(GridPen, x, y, x + Width, y);
                y += RenderedTileHeight;
            }

            x = 0;
            y = 0;

            for (int i = 0; i < MaxTilesInRow; i++)
            {
                g.DrawLine(GridPen, x, y, x, y + Height);
                x += RenderedTileWidth;
            }
        }
    }
}
