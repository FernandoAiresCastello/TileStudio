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
    public partial class ImportExportWindow : Form
    {
        private Tileset Tileset;
        private int TileIndex;

        public ImportExportWindow(Tileset tileset, int index)
        {
            InitializeComponent();

            Tileset = tileset;
            TileIndex = index;
        }
    }
}
