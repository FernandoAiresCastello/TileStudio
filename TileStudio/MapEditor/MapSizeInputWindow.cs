using System;
using System.Windows.Forms;

using TileStudio.Core;

namespace TileStudio.MapEditor
{
    public partial class MapSizeInputWindow : Form
    {
        public int NewWidth = Map.DefaultWidth;
        public int NewHeight = Map.DefaultHeight;

        public MapSizeInputWindow(int curWidth, int curHeight)
        {
            InitializeComponent();

            TxtWidth.Text = curWidth.ToString();
            TxtHeight.Text = curHeight.ToString();
        }

        private void TxtSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try { NewWidth = int.Parse(TxtWidth.Text); } catch {}
                try { NewHeight = int.Parse(TxtHeight.Text); } catch {}

                if (NewWidth < Map.MinWidth)
                    NewWidth = Map.MinWidth;
                else if (NewWidth >= Map.MaxWidth)
                    NewWidth = Map.MaxWidth - 1;

                if (NewHeight < Map.MinHeight)
                    NewHeight = Map.MinHeight;
                else if (NewHeight >= Map.MaxHeight)
                    NewHeight = Map.MaxHeight - 1;

                DialogResult = DialogResult.OK;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
