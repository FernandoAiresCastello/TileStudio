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

namespace TileStudio.TileEditor
{
    public partial class TileIndexInputWindow : Form
    {
        public int TileIndex = 0;

        public TileIndexInputWindow()
        {
            InitializeComponent();
        }

        private void TxtTileIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    TileIndex = int.Parse(TxtTileIndex.Text);
                }
                catch
                {
                }

                DialogResult = DialogResult.OK;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
