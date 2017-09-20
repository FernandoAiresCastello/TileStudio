using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TileStudio.Core;

namespace TileStudio.MapEditor
{
    public partial class ColorPicker : Form
    {
        public int SelectedColor = 0;
        public Palette Palette;

        private Bitmap PaletteImage;
        private readonly int SwatchWidth;
        private readonly int SwatchHeight;

        public ColorPicker(Palette palette, string title)
        {
            InitializeComponent();

            Text = title;
            Palette = palette;
            PaletteImage = new Bitmap(PaletteBox.Width, PaletteBox.Height);

            SwatchWidth = PaletteImage.Width / 16;
            SwatchHeight = PaletteImage.Height / 16;

            Graphics g = Graphics.FromImage(PaletteImage);

            int x = 0;
            int y = 0;

            for (int i = 0; i < Palette.Count; i++)
            {
                using (Brush brush = new SolidBrush(Palette[i]))
                    g.FillRectangle(brush, x, y, SwatchWidth, SwatchHeight);

                x += SwatchWidth;
                if (x >= PaletteImage.Width)
                {
                    x = 0;
                    y += SwatchHeight;
                }
            }

            PaletteBox.Image = PaletteImage;
        }

        private int GetColorUnderCursor(int mouseX, int mouseY)
        {
            int x = mouseX / SwatchWidth;
            int y = mouseY / SwatchHeight;

            return y * 16 + x;
        }

        private void PaletteBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
            {
                SelectedColor = GetColorUnderCursor(me.X, me.Y);
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
        }

        private void ColorPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }

        private void PaletteBox_MouseMove(object sender, MouseEventArgs e)
        {
            int selectedColor = GetColorUnderCursor(e.X, e.Y);
            int r = Palette[selectedColor].R;
            int g = Palette[selectedColor].G;
            int b = Palette[selectedColor].B;
            int a = Palette[selectedColor].A;

            TxtIndicator.Text = 
                "Color " + selectedColor + " (RGBA " + r + "," + g + "," + b + "," + a + ")";
        }

        private void PaletteBox_MouseLeave(object sender, EventArgs e)
        {
            TxtIndicator.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
