using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

using TileStudio.Core;

namespace TileStudio.TileEditor
{
    class TilePictureBox : PictureBox
    {
        public MainWindow EditorWindow;
        public Tile Tile;
        public bool ShowGrid;
        public bool ShowCodes;
        public int ColorCode;

        public Color Color1 = Color.FromArgb(0, 0, 0);
        public Color Color2 = Color.FromArgb(100, 100, 100);
        public Color Color3 = Color.FromArgb(200, 200, 200);

        private Pen GridPen;
        private SolidBrush PixelBrush;

        private int PixelWidth;
        private int PixelHeight;

        public TilePictureBox()
        {
            Tile = new Tile();
            BackColor = Color.White;
            ShowGrid = true;
            ShowCodes = false;
            ColorCode = 1;
            GridPen = new Pen(Color.LightGray);
            GridPen.DashStyle = DashStyle.Dot;
            PixelBrush = new SolidBrush(Color.Empty);

            Click += TilePictureBox_Click;
            MouseDown += TilePictureBox_MouseDown;
            MouseMove += TilePictureBox_MouseMove;
        }

        private void TilePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            TilePictureBoxClicked(e);
        }

        private void TilePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            TilePictureBoxClicked(e);
        }

        private void TilePictureBox_Click(object sender, EventArgs e)
        {
            TilePictureBoxClicked((MouseEventArgs)e);
        }

        private void TilePictureBoxClicked(MouseEventArgs e)
        {
            Point pos = TranslateMousePos(e.X, e.Y);

            if (e.Button == MouseButtons.Left)
                SetPixel(pos.X, pos.Y, ColorCode);
            else if (e.Button == MouseButtons.Right)
                SetPixel(pos.X, pos.Y, 0);

            EditorWindow.UpdateTilePreview();
        }

        private Point TranslateMousePos(int mouseX, int mouseY)
        {
            return new Point(mouseX / PixelWidth, mouseY / PixelHeight);
        }

        private void SetPixel(int x, int y, int colorCode)
        {
            if (x < 0 || y < 0 || x >= Tile.Width || y >= Tile.Height)
                return;

            Tile.Pixels[y, x] = colorCode;

            Refresh();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            PixelWidth = Width / Tile.Width;
            PixelHeight = Height / Tile.Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawTile(e.Graphics);

            if (ShowGrid)
                DrawGrid(e.Graphics);
        }

        private void DrawTile(Graphics g)
        {
            for (int y = 0; y < Tile.Height; y++)
                for (int x = 0; x < Tile.Width; x++)
                    DrawPixel(g, x, y, Tile.Pixels[y, x]);
        }

        private void DrawPixel(Graphics g, int x, int y, int colorCode)
        {
            switch (colorCode)
            {
                case 0: PixelBrush.Color = BackColor; break; // Transparent

                case 1: PixelBrush.Color = Color1; break;
                case 2: PixelBrush.Color = Color2; break;
                case 3: PixelBrush.Color = Color3; break;
            }

            int px = x * PixelWidth;
            int py = y * PixelHeight;

            g.FillRectangle(PixelBrush, px, py, PixelWidth, PixelHeight);

            if (ShowCodes)
                g.DrawString(colorCode.ToString(), DefaultFont, Brushes.White, px + (PixelWidth / 3), py + (PixelHeight / 3));
        }

        private void DrawGrid(Graphics g)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < Tile.Height; i++)
            {
                g.DrawLine(GridPen, x, y, x + Width, y);
                y += PixelHeight;
            }

            x = 0;
            y = 0;

            for (int i = 0; i < Tile.Width; i++)
            {
                g.DrawLine(GridPen, x, y, x, y + Height);
                x += PixelWidth;
            }
        }
    }
}
