using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

using TileStudio.Core;

namespace TileStudio.TileEditor
{
    public partial class MainWindow : Form
    {
        public MapEditor.MainWindow MapEditorWindow;

        private Timer StatusClearTimer;
        private Tileset Tileset;
        private int TileIndex;
        private Tile ClipboardTile = new Tile();

        public MainWindow(Tileset tileset, int index = 0)
        {
            InitializeComponent();

            TileBox.EditorWindow = this;

            Tileset = tileset;
            TileIndex = index;

            StatusClearTimer = new Timer();
            StatusClearTimer.Tick += StatusClearTimer_Tick;

            MenuShowGrid.Checked = TileBox.ShowGrid;
            MenuShowColorIndexes.Checked = TileBox.ShowCodes;

            UpdateTileDisplay();
            UpdateTilePreview();
            UpdateButtonTexts();
            UpdateButtonColors();

            CmbExportImportMode.SelectedIndex = 0;

            PrintStatus("Ready");
        }

        private void UpdateTileDisplay()
        {
            int count = Tileset.Count - 1;
            if (count < 0)
                count = 0;

            LblTileIndex.Text = TileIndex.ToString() + " / " + count.ToString();

            if (TileIndex >= 0 && TileIndex < Tileset.Count)
            {
                TileBox.Tile = Tileset[TileIndex];
                TileBox.Refresh();
                UpdateTilePreview();
            }
        }

        private void StatusClearTimer_Tick(object sender, EventArgs e)
        {
            ClearStatus();
            StatusClearTimer.Stop();
        }

        private void ClearStatus()
        {
            LblStatus.Text = "";
        }

        private void PrintStatus(string text, int timeout = 1000)
        {
            LblStatus.Text = text;
            StatusClearTimer.Interval = timeout;
            StatusClearTimer.Start();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            bool ctrl = e.Modifiers == Keys.Control;
            Keys key = e.KeyCode;

            // Color selection
            if (key == Keys.D1 || key == Keys.NumPad1)
                SetColorCode(1);
            else if (key == Keys.D2 || key == Keys.NumPad2)
                SetColorCode(2);
            else if (key == Keys.D3 || key == Keys.NumPad3)
                SetColorCode(3);

            // Copy-paste
            else if (ctrl && key == Keys.C)
            {
                ClipboardTile = new Tile(TileBox.Tile.Pixels);
                PrintStatus("Tile copied to clipboard");
            }
            else if (ctrl && key == Keys.V)
            {
                Tileset[TileIndex] = new Tile(ClipboardTile.Pixels);
                UpdateTileDisplay();
                PrintStatus("Tile pasted from clipboard");
            }

            // Prev/Next
            else if (key == Keys.PageUp)
                BtnNext_Click(null, null);
            else if (key == Keys.PageDown)
                BtnPrev_Click(null, null);

            // Clear
            else if (key == Keys.Delete)
                BtnClear_Click(null, null);
            /*
            // Rotate
            else if (key == Keys.R)
                BtnRotate_Click(null, null);

            // Flips
            else if (key == Keys.V)
                BtnFlipY_Click(null, null);
            else if (key == Keys.H)
                BtnFlipX_Click(null, null);

            // Shifts
            else if (ctrl && key == Keys.Right)
            {
                TileBox.Tile.ShiftX(1);
                TileBox.Refresh();
                UpdateTilePreview();
            }
            else if (ctrl && key == Keys.Left)
            {
                TileBox.Tile.ShiftX(-1);
                TileBox.Refresh();
                UpdateTilePreview();
            }
            else if (ctrl && key == Keys.Down)
            {
                TileBox.Tile.ShiftY(1);
                TileBox.Refresh();
                UpdateTilePreview();
            }
            else if (ctrl && key == Keys.Up)
            {
                TileBox.Tile.ShiftY(-1);
                TileBox.Refresh();
                UpdateTilePreview();
            }*/
        }

        private void BtnColorCode_Click(object sender, EventArgs e)
        {
            if (sender == Btn1)
                SetColorCode(1);
            else if (sender == Btn2)
                SetColorCode(2);
            else if (sender == Btn3)
                SetColorCode(3);
        }

        private void SetColorCode(int code)
        {
            TileBox.ColorCode = code;

            UpdateButtonTexts();
        }

        private void Btn1Select_Click(object sender, EventArgs e)
        {
            SelectColor(1);
        }

        private void Btn2Select_Click(object sender, EventArgs e)
        {
            SelectColor(2);
        }

        private void Btn3Select_Click(object sender, EventArgs e)
        {
            SelectColor(3);
        }

        private void SelectColor(int code)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = TileBox.BackColor;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            if (code == 1)
                TileBox.Color1 = dialog.Color;
            else if (code == 2)
                TileBox.Color2 = dialog.Color;
            else if (code == 3)
                TileBox.Color3 = dialog.Color;

            UpdateButtonColors();
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void UpdateButtonTexts()
        {
            if (TileBox.ColorCode == 1)
                Btn1.Focus();
            if (TileBox.ColorCode == 2)
                Btn2.Focus();
            if (TileBox.ColorCode == 3)
                Btn3.Focus();

            Btn1.Text = TileBox.ColorCode == 1 ? "[ 1 ]" : "1";
            Btn2.Text = TileBox.ColorCode == 2 ? "[ 2 ]" : "2";
            Btn3.Text = TileBox.ColorCode == 3 ? "[ 3 ]" : "3";
        }

        private void UpdateButtonColors()
        {
            Btn1Select.BackColor = TileBox.Color1;
            Btn2Select.BackColor = TileBox.Color2;
            Btn3Select.BackColor = TileBox.Color3;
        }

        private void MenuBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = TileBox.BackColor;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            TileBox.BackColor = dialog.Color;
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void MenuShowGrid_Click(object sender, EventArgs e)
        {
            TileBox.ShowGrid = MenuShowGrid.Checked;
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void MenuShowColorIndexes_Click(object sender, EventArgs e)
        {
            TileBox.ShowCodes = MenuShowColorIndexes.Checked;
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TileBox.Tile.Clear();
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            TileBox.Tile.Fill(TileBox.ColorCode);
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            TileBox.Tile.Swap();
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            TileBox.Tile.Rotate();
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnFlipX_Click(object sender, EventArgs e)
        {
            TileBox.Tile.FlipX();
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnFlipY_Click(object sender, EventArgs e)
        {
            TileBox.Tile.FlipY();
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            TileIndex++;
            if (TileIndex >= Tileset.Count)
                TileIndex = 0;

            UpdateTileDisplay();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            TileIndex--;
            if (TileIndex < 0)
                TileIndex = Tileset.Count - 1;

            UpdateTileDisplay();
        }

        private void BtnAddPage_Click(object sender, EventArgs e)
        {
            Tileset.AddPage();
            UpdateTileDisplay();
            PrintStatus("Tileset page created");
        }

        private void BtnDelPage_Click(object sender, EventArgs e)
        {
            PrintStatus("Function not implemented");
        }

        private void TxtTileIndex_Click(object sender, EventArgs e)
        {
            TileIndexInputWindow input = new TileIndexInputWindow();
            input.Location = MousePosition;
            if (input.ShowDialog(this) != DialogResult.OK)
                return;

            TileIndex = input.TileIndex;

            if (TileIndex < 0)
                TileIndex = 0;
            else if (TileIndex >= Tileset.Count)
                TileIndex = Tileset.Count - 1;

            UpdateTileDisplay();
        }

        private void BtnShiftUp_Click(object sender, EventArgs e)
        {
            TileBox.Tile.ShiftY(-1);
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnShiftLeft_Click(object sender, EventArgs e)
        {
            TileBox.Tile.ShiftX(-1);
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnShiftRight_Click(object sender, EventArgs e)
        {
            TileBox.Tile.ShiftX(1);
            TileBox.Refresh();
            UpdateTilePreview();
        }

        private void BtnShiftDown_Click(object sender, EventArgs e)
        {
            TileBox.Tile.ShiftY(1);
            TileBox.Refresh();
            UpdateTilePreview();
        }

        public void UpdateTilePreview()
        {
            const int zoom = 2;

            Bitmap preview = new Bitmap(Tile.Width * 2 * zoom, Tile.Height * 2 * zoom);
            Graphics g = Graphics.FromImage(preview);
            Tile tile = Tileset[TileIndex];

            tile.Draw(g, 0, 0, zoom, zoom, TileBox.Color1, TileBox.Color2, TileBox.Color3, true);
            tile.Draw(g, 1, 0, zoom, zoom, TileBox.Color1, TileBox.Color2, TileBox.Color3, true);
            tile.Draw(g, 0, 1, zoom, zoom, TileBox.Color1, TileBox.Color2, TileBox.Color3, true);
            tile.Draw(g, 1, 1, zoom, zoom, TileBox.Color1, TileBox.Color2, TileBox.Color3, true);

            PreviewTileBox.BackColor = TileBox.BackColor;
            PreviewTileBox.Image = preview;
            PreviewTileBox.Refresh();
        }

        private void BtnUpdateMap_Click(object sender, EventArgs e)
        {
            MapEditorWindow.UpdateTileViews();
        }

        private void BtnImportExport_Click(object sender, EventArgs e)
        {
            ImportExportWindow win = new ImportExportWindow(Tileset, TileIndex);
            win.ShowDialog(this);
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            ClipboardTile = new Tile(TileBox.Tile.Pixels);
            PrintStatus("Tile copied to clipboard");
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            Tileset[TileIndex] = new Tile(ClipboardTile.Pixels);
            UpdateTileDisplay();
            PrintStatus("Tile pasted from clipboard");
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            switch (CmbExportImportMode.SelectedIndex)
            {
                case 0: // 000111100110220120333...
                    TxtExportImport.Text = TileBox.Tile.ToStringPlain();
                    break;
                case 1: // 0x00,0x2A,0x3F,0xAB,0x94,0xC7,0xFF,0xFF,0xFE...
                    TxtExportImport.Text = TileBox.Tile.ToStringBinaryHex();
                    break;
                case 2: // 0xFFFFFFFF,0x00000000,0xFFFF00FF...
                    TxtExportImport.Text = TileBox.Tile.ToStringColor(
                        TileBox.Color1, TileBox.Color2, TileBox.Color3);
                    break;
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
