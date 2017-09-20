using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileStudio.CommonCtrl
{
    public partial class BytesViewWindow : Form
    {
        public List<byte> DataBlock { get { return GrdBytes.Bytes; } }

        public BytesViewWindow(string title, List<byte> bytes)
        {
            InitializeComponent();

            Text = title;
            GrdBytes.Bytes = bytes;
        }
    }
}
