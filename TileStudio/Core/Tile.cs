using System;
using System.Windows.Forms;
using System.Drawing;

namespace TileStudio.Core
{
    public class Tile
    {
        public const int Width = 8;
        public const int Height = 8;
        public const int Size = Width * Height;

        public int[,] Pixels = new int[Height, Width];

        public Tile()
        {
            Clear();
        }

        public Tile(int[,] pixels)
        {
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    Pixels[y, x] = pixels[y, x];
        }

        public void Clear()
        {
            Fill(0);
        }

        public void Fill(int color)
        {
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    Pixels[y, x] = color;
        }

        public void Swap()
        {
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    SwapPixel(ref Pixels[y, x]);
        }

        public void SwapPixel(ref int pixel)
        {
            if (pixel == 0)
                return;

            pixel++;
            if (pixel > 3)
                pixel = 1;
        }

        public void ShiftX(int sign)
        {
            if (sign > 0) // Shift right
            {
                for (int y = 0; y < Height; y++)
                {
                    int last = Pixels[y, Width - 1];
                    for (int x = Width - 1; x > 0; x--)
                        Pixels[y, x] = Pixels[y, x - 1];

                    Pixels[y, 0] = last;
                }
            }
            else if (sign < 0) // Shift left
            {
                for (int y = 0; y < Height; y++)
                {
                    int first = Pixels[y, 0];
                    for (int x = 0; x < Width - 1; x++)
                        Pixels[y, x] = Pixels[y, x + 1];

                    Pixels[y, Width - 1] = first;
                }
            }
        }

        public void ShiftY(int sign)
        {
            if (sign > 0) // Shift down
            {
                for (int x = 0; x < Width; x++)
                {
                    int last = Pixels[Height - 1, x];
                    for (int y = Height - 1; y > 0; y--)
                        Pixels[y, x] = Pixels[y - 1, x];

                    Pixels[0, x] = last;
                }
            }
            else if (sign < 0) // Shift up
            {
                for (int x = 0; x < Width; x++)
                {
                    int first = Pixels[0, x];
                    for (int y = 0; y < Height - 1; y++)
                        Pixels[y, x] = Pixels[y + 1, x];

                    Pixels[Height - 1, x] = first;
                }
            }
        }

        public void FlipX()
        {
            Tile flipped = new Tile();

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    flipped.Pixels[y, x] = Pixels[y, (Width - 1) - x];

            Pixels = flipped.Pixels;
        }

        public void FlipY()
        {
            Tile flipped = new Tile();

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    flipped.Pixels[y, x] = Pixels[(Height - 1) - y, x];

            Pixels = flipped.Pixels;
        }

        public void Rotate()
        {
            Tile rotated = new Tile();

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    rotated.Pixels[y, x] = Pixels[x, (Height - 1) - y];

            Pixels = rotated.Pixels;
        }

        public void Draw(Graphics g, int x, int y, int pixelWidth, int pixelHeight, 
            Color color1, Color color2, Color color3, bool snapToGrid)
        {
            SolidBrush brush = new SolidBrush(Color.Empty);

            if (snapToGrid)
            {
                x *= pixelWidth * Width;
                y *= pixelHeight * Height;
            }

            for (int py = 0; py < Height; py++)
            {
                for (int px = 0; px < Width; px++)
                {
                    brush.Color = Color.FromArgb(0, 0, 0, 0);
                    int color = Pixels[py, px];

                    if (color == 1)
                        brush.Color = color1;
                    else if (color == 2)
                        brush.Color = color2;
                    else if (color == 3)
                        brush.Color = color3;

                    if (brush.Color.A > 0)
                        g.FillRectangle(brush, x + (px * pixelWidth), y + (py * pixelHeight), pixelWidth, pixelHeight);
                }
            }

            brush.Dispose();
        }

        public static Point TranslateMousePosToTilePos(int mouseX, int mouseY, int pixelWidth, int pixelHeight)
        {
            return new Point(
                mouseX / (pixelWidth * Width),
                mouseY / (pixelHeight * Height));
        }

        public string ToStringPlain()
        {
            string str = "";

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    str += Pixels[y, x];

            return str;
        }

        public string ToStringColor(Color color1, Color color2, Color color3)
        {
            string str = "";
            SolidBrush brush = new SolidBrush(Color.Empty);

            for (int py = 0; py < Height; py++)
            {
                for (int px = 0; px < Width; px++)
                {
                    brush.Color = Color.FromArgb(0, 0, 0, 0);
                    int color = Pixels[py, px];

                    if (color == 1)
                        brush.Color = color1;
                    else if (color == 2)
                        brush.Color = color2;
                    else if (color == 3)
                        brush.Color = color3;

                    str += "0x" + brush.Color.ToArgb().ToString("X8") + ",";
                }
            }

            brush.Dispose();
            return str.Remove(str.Length-1);
        }

        public string ToStringBinaryHex()
        {
            string str = "";

            for (int y = 0; y < Height; y++)
            {
                string bits = "";
                for (int x = 0; x < Width; x++)
                    bits += Pixels[y, x] > 0 ? 1 : 0;

                str += "0x" + Convert.ToByte(bits, 2).ToString("X2") + ",";
            }

            return str.Remove(str.Length - 1);
        }
    }
}
