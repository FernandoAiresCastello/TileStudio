using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using WorldEditor.Core;

namespace WorldEditor
{
    class TilesetBox : PictureBox
    {
        public MainWindow MainWindow { set; get; }
        public Tileset Tileset { set; get; }

        public int PageCount
        {
            get { return Tileset.Count / PageSize; }
        }

        public const int PixelWidth = 2;
        public const int PixelHeight = 2;
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
            MouseWheel += TilesetBox_MouseWheel;
            MouseEnter += TilesetBox_MouseEnter;
        }

        private void TilesetBox_DoubleClick(object sender, EventArgs e)
        {
            MainWindow.EditSelectedTile();
        }

        private void TilesetBox_MouseEnter(object sender, EventArgs e)
        {
            Focus();
        }

        private void TilesetBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                NextPage();
            else if (e.Delta < 0)
                PrevPage();
        }

        public string GetPageIndicator()
        {
            return (SelectedPage + 1) + " / " + PageCount;
        }

        private void TilesetBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mev = (MouseEventArgs)e;

            int x = mev.X / (PixelWidth * Tile.Width);
            int y = mev.Y / (PixelHeight * Tile.Height);

            int selectedTile = (y * MaxTilesInRow + x) + (PageSize * SelectedPage);

            MainWindow.TileIndex = selectedTile;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Location = new Point(0, 0);
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
            MainWindow.UpdateTilesetPageIndicator();
        }

        public void PrevPage()
        {
            SelectedPage--;
            if (SelectedPage < 0)
                SelectedPage = PageCount - 1;

            Refresh();
            MainWindow.UpdateTilesetPageIndicator();
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
                y += Tile.Height * PixelHeight;
            }

            x = 0;
            y = 0;

            for (int i = 0; i < MaxTilesInRow; i++)
            {
                g.DrawLine(GridPen, x, y, x, y + Height);
                x += Tile.Width * PixelWidth;
            }
        }
    }
}
