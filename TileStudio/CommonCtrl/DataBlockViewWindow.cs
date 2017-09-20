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

namespace TileStudio.CommonCtrl
{
    public partial class DataBlockViewWindow : Form
    {
        public DataBlock DataBlock { get { return GrdData.DataBlock; } }

        public DataBlockViewWindow(string title, DataBlock data)
        {
            InitializeComponent();

            Text = title;
            GrdData.DataBlock = data;
        }
    }
}
