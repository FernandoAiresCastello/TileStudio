using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TileStudio.Core;

namespace TileStudio.CommonCtrl
{
    public partial class DataBlockView : UserControl
    {
        public DataGridView Grid
        {
            get { return GrdData; }
        }

        public DataBlockView()
        {
            InitializeComponent();
        }

        private void GrdData_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == GrdData.Rows.Count - 1)
                return;

            DataGridViewCell keyCell = GrdData.Rows[e.RowIndex].Cells[0];
            DataGridViewCell valueCell = GrdData.Rows[e.RowIndex].Cells[1];

            if (keyCell.Value == null || string.IsNullOrEmpty(keyCell.Value.ToString().Trim()))
                keyCell.Value = "null";
            if (valueCell.Value == null || string.IsNullOrEmpty(valueCell.Value.ToString().Trim()))
                valueCell.Value = "null";
        }

        public DataBlock DataBlock
        {
            set
            {
                DataBlock data = value;

                GrdData.Rows.Clear();
                foreach (KeyValuePair<string, string> item in data)
                    GrdData.Rows.Add(item.Key, item.Value);
            }

            get
            {
                DataBlock data = new DataBlock();

                foreach (DataGridViewRow row in GrdData.Rows)
                {
                    DataGridViewCell keyCell = row.Cells[0];
                    DataGridViewCell valueCell = row.Cells[1];

                    if (keyCell.Value != null && valueCell.Value != null)
                        if (!string.IsNullOrEmpty(keyCell.Value.ToString()) && !string.IsNullOrEmpty(valueCell.Value.ToString()))
                            data.Add(keyCell.Value.ToString().Trim(), valueCell.Value.ToString().Trim());
                }

                return data;
            }
        }
    }
}
