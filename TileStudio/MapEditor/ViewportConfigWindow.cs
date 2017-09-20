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
    public partial class ViewportConfigWindow : Form
    {
        public int NewWidth = Map.DefaultWidth / 2;
        public int NewHeight = Map.DefaultHeight / 2;

        public ViewportConfigWindow(int curWidth, int curHeight)
        {
            InitializeComponent();

            TxtWidth.Text = curWidth.ToString();
            TxtHeight.Text = curHeight.ToString();
        }

        private void TxtSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try { NewWidth = int.Parse(TxtWidth.Text); } catch { }
                try { NewHeight = int.Parse(TxtHeight.Text); } catch { }

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
