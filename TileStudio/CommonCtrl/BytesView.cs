using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileStudio.CommonCtrl
{
    public partial class BytesView : UserControl
    {
        public BytesView()
        {
            InitializeComponent();
        }

        private void GrdBytes_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == GrdBytes.Rows.Count - 1)
                return;

            DataGridViewCell cell = GrdBytes.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value != null)
            {
                int value = 0;
                int.TryParse(cell.Value.ToString(), out value);

                if (value < 0)
                    value = 0;
                else if (value > 255)
                    value = 255;

                cell.Value = value;
            }
        }

        public List<byte> Bytes
        {
            get
            {
                List<byte> bytes = new List<byte>();

                for (int y = 0; y < GrdBytes.RowCount; y++)
                {
                    for (int x = 0; x < GrdBytes.ColumnCount; x++)
                    {
                        DataGridViewCell cell = GrdBytes.Rows[y].Cells[x];
                        if (cell.Value != null)
                            bytes.Add(byte.Parse(cell.Value.ToString()));
                    }
                }

                return bytes;
            }

            set
            {
                int rowCount = (int)Math.Ceiling((double)(value.Count / GrdBytes.ColumnCount));

                GrdBytes.Rows.Clear();
                if (rowCount > 0)
                    GrdBytes.Rows.Add(rowCount);

                int i = 0;
                for (int y = 0; y < GrdBytes.RowCount; y++)
                {
                    for (int x = 0; x < GrdBytes.ColumnCount; x++)
                    {
                        if (i < value.Count)
                            GrdBytes.Rows[y].Cells[x].Value = value[i++];
                    }
                }
            }
        }

        private void GrdBytes_KeyDown(object sender, KeyEventArgs e)
        {
            if (GrdBytes.SelectedCells.Count < 1)
                return;

            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                foreach (DataGridViewCell cell in GrdBytes.SelectedCells)
                    cell.Value = null;
            }
        }
    }
}
