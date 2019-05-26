using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using TileStudio.Core;
using TileStudio.CommonCtrl;

namespace TileStudio.MapEditor
{
    public partial class MainWindow : Form
    {
        private const string MapFileExtension = "bin";

        private string DataDirectory;
        private string TilesetFile;
        private string DefaultTilesetFile;
        private string PaletteFile;

        public Tileset Tileset;
        public Palette Palette;
        public Map Map;

        private string CurrentMapFile;

        #region Game Object Properties

        public int TileIndex
        {
            set { TxtTileIndex.Text = value.ToString(); UpdateTilePreview(); }
            get { return int.Parse(TxtTileIndex.Text); }
        }

        public int TileColor1
        {
            set { TxtColor1.Text = value.ToString(); PnlColor1.BackColor = Palette[value]; UpdateTilePreview(); }
            get { return int.Parse(TxtColor1.Text); }
        }

        public int TileColor2
        {
            set { TxtColor2.Text = value.ToString(); PnlColor2.BackColor = Palette[value]; UpdateTilePreview(); }
            get { return int.Parse(TxtColor2.Text); }
        }

        public int TileColor3
        {
            set { TxtColor3.Text = value.ToString(); PnlColor3.BackColor = Palette[value]; UpdateTilePreview(); }
            get { return int.Parse(TxtColor3.Text); }
        }

        public TileGraphics TileGraphics
        {
            set
            {
                TileIndex = value.Index;
                TileColor1 = value.Color1;
                TileColor2 = value.Color2;
                TileColor3 = value.Color3;
            }

            get { return new TileGraphics(TileIndex, TileColor1, TileColor2, TileColor3); }
        }

        public List<byte> ObjectBytes
        {
            set { GrdBytes.Bytes = value; }
            get { return GrdBytes.Bytes; }
        }

        public GameObject CurrentObject
        {
            get
            {
                return new GameObject(TileGraphics, ObjectBytes);
            }
        }

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            DataDirectory = Path.Combine(@"C:\Fernando\Proj\Windows\TileStudio\TileStudio\bin\Debug", "data");
            TilesetFile = Path.Combine(DataDirectory, "tileset.dat");
            DefaultTilesetFile = Path.Combine(DataDirectory, "default_tileset.dat");
            PaletteFile = Path.Combine(DataDirectory, "palette.dat");

            ClearLog();
            ClearStatusBar();

            Palette = new Palette();
            Palette.Load(PaletteFile);
            Log("Palette loaded from " + PaletteFile);

            Tileset = new Tileset();
            Tileset.Load(TilesetFile);
            Log("Tileset loaded from " + TilesetFile);
            TilesetBox.EditorWindow = this;
            TilesetBox.Tileset = Tileset;
            UpdateTilesetPageIndicator();

            Map = new Map();
            MapBox.SetMap(Map);
            MapBox.EditorWindow = this;
            MapBox.Tileset = Tileset;
            MapBox.Palette = Palette;

            MouseWheel += Map_MouseWheel;
            MapBox.MouseWheel += Map_MouseWheel;

            UpdateMapLayerList();

            TileGraphics = new TileGraphics();
            TxtMapName.Text = Map.Name;
            SetCurrentMapFile(null);

            TxtCommand.Text = "";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateDirectoryTree();
        }

        public void ClearLog()
        {
            TxtLog.Text = "";
        }

        public void Log(string text)
        {
            string timestamp = "[" + DateTime.Now + "]";

            TxtLog.AppendText(timestamp + " " + text + Environment.NewLine);
        }

        public void ClearStatusBar()
        {
            SetStatusBar("");
        }

        public void SetStatusBar(string text)
        {
            LblStatus.Text = text;
        }

        public void UpdateTilesetPageIndicator()
        {
            LblTilesetPage.Text = TilesetBox.GetPageIndicator();
        }

        public void UpdateTilePreview()
        {
            const int zoom = 4;

            Bitmap preview = new Bitmap(Tile.Width * zoom, Tile.Height * zoom);
            Graphics g = Graphics.FromImage(preview);

            if (TileIndex < Tileset.Count)
            {
                Tileset[TileIndex].Draw(g, 0, 0, zoom, zoom,
                    Palette[TileColor1], Palette[TileColor2], Palette[TileColor3], true);
            }

            PreviewTileBox.BackColor = Palette[Map.BackColor];
            PreviewTileBox.Image = preview;
            PreviewTileBox.Refresh();
        }

        private void BtnTilesetPrevPage_Click(object sender, EventArgs e)
        {
            TilesetBox.PrevPage();
        }

        private void BtnTilesetNextPage_Click(object sender, EventArgs e)
        {
            TilesetBox.NextPage();
        }

        private void PnlColor_Click(object sender, EventArgs e)
        {
            string title = "";

            if (sender == PnlColor1)
                title = "Pick tile color 1";
            else if (sender == PnlColor2)
                title = "Pick tile color 2";
            else if (sender == PnlColor3)
                title = "Pick tile color 3";

            ColorPicker picker = new ColorPicker(Palette, title);
            if (picker.ShowDialog() != DialogResult.OK)
                return;

            if (sender == PnlColor1)
                TileColor1 = picker.SelectedColor;
            else if (sender == PnlColor2)
                TileColor2 = picker.SelectedColor;
            else if (sender == PnlColor3)
                TileColor3 = picker.SelectedColor;
        }

        public void EditSelectedTile()
        {
            TileEditor.MainWindow editor = new TileEditor.MainWindow(Tileset, TileIndex);
            editor.MapEditorWindow = this;
            editor.ShowDialog(this);

            TilesetBox.Refresh();
            UpdateTilesetPageIndicator();
            UpdateTilePreview();

            Tileset.Save(TilesetFile);
            Log("Tileset saved to " + TilesetFile);

            MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        public void ShowMessage(string title, string text, MessageBoxIcon icon)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, icon);
        }

        private void ChkTilesetGrid_Click(object sender, EventArgs e)
        {
            TilesetBox.ShowGrid = (sender as ToolStripMenuItem).Checked;
            TilesetBox.Refresh();
        }

        public void UpdateTileViews()
        {
            TilesetBox.Refresh();
            MapBox.InvalidateAllMapPositionsAndRefresh();
            UpdateTilePreview();
        }

        private void PreviewTileBox_Click(object sender, EventArgs e)
        {
            EditSelectedTile();
        }

        private void BtnMapClear_Click(object sender, EventArgs e)
        {
            if (Confirm("Clear the current map layer?"))
            {
                MapBox.CurrentMapLayer.Clear();
                MapBox.InvalidateAllMapPositionsAndRefresh();
            }
        }

        private bool Confirm(string message)
        {
            DialogResult result = MessageBox.Show(
                message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfo(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetCurrentMapFile(string filename)
        {
            CurrentMapFile = filename;

            if (filename == null)
                LblCurrentMapFile.Text = "New file";
            else
                LblCurrentMapFile.Text = filename;
        }

        private void LoadMap(string filename)
        {
            try
            {
                Map.Load(filename);
                UpdateMapLayerList(false);
                MapBox.AdjustSize();
                MapBox.InvalidateAllMapPositionsAndRefresh();
                TxtMapName.Text = Map.Name;
                UpdateTilePreview();

                Log("Map loaded from file " + filename);
                SetCurrentMapFile(filename);
            }
            catch (Exception ex)
            {
                ShowError("Error loading map from file " + filename + ":" +
                    Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void SaveEmptyMap(string filename)
        {
            try
            {
                filename = AddFileMapExtension(filename);

                Map emptyMap = new Map();
                emptyMap.Save(filename);
                Log("Empty map saved to file " + filename);
                UpdateDirectoryTree();
            }
            catch (Exception ex)
            {
                ShowError("Error saving empty map to file " + filename + ":" +
                    Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void SaveMap(string filename)
        {
            try
            {
                filename = AddFileMapExtension(filename);

                Map.Save(filename);
                SetCurrentMapFile(filename);
                Log("Map saved to file " + filename);
                UpdateDirectoryTree();
            }
            catch (Exception ex)
            {
                ShowError("Error saving map to file " + filename + ":" +
                    Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private string AddFileMapExtension(string path)
        {
            if (Path.GetExtension(path) != "." + MapFileExtension)
                path += "." + MapFileExtension;

            return path;
        }

        private void BtnMapSave_Click(object sender, EventArgs e)
        {
            if (CurrentMapFile == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = DataDirectory;
                dialog.Filter = "Map files|*." + MapFileExtension;
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                SaveMap(dialog.FileName);
            }
            else
                SaveMap(CurrentMapFile);
        }

        private void BtnMapLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = DataDirectory;
            dialog.Filter = "Map files|*." + MapFileExtension;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            LoadMap(dialog.FileName);
        }

        private void BtnMapFill_Click(object sender, EventArgs e)
        {
            if (Confirm("Fill current map layer with selected object?"))
            {
                MapBox.CurrentMapLayer.FillObject(CurrentObject);
                MapBox.InvalidateAllMapPositionsAndRefresh();
            }
        }

        private void BtnEraseObject_Click(object sender, EventArgs e)
        {
            TileGraphics = new TileGraphics();
            ObjectBytes = new List<byte>();
        }

        private void TxtMapName_TextChanged(object sender, EventArgs e)
        {
            Map.Name = TxtMapName.Text.Trim();
        }

        private void BtnMapSetData_Click(object sender, EventArgs e)
        {
            BytesViewWindow dialog = new BytesViewWindow("Map Header", Map.Bytes);
            dialog.ShowDialog(this);

            Map.Bytes = dialog.DataBlock;
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            string path = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];

            LoadMap(path);
        }

        private void UpdateDirectoryTree()
        {
            PnlDirectory.Nodes.Clear();
            PnlDirectory.Nodes.Add(DataDirectory, Path.GetFileName(DataDirectory), 0);

            DirectoryInfo dir = new DirectoryInfo(DataDirectory);
            FileInfo[] files = dir.GetFiles("*." + MapFileExtension);

            foreach (FileInfo file in files)
                PnlDirectory.TopNode.Nodes.Add(file.FullName, file.Name, 1, 1);

            PnlDirectory.ExpandAll();
        }

        private void BtnDirectoryAdd_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = DataDirectory;
            dialog.Filter = "Map files|*." + MapFileExtension;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            SaveEmptyMap(dialog.FileName);
        }

        private void BtnDirectoryDelete_Click(object sender, EventArgs e)
        {
            TreeNode node = PnlDirectory.SelectedNode;
            if (node == null || node == PnlDirectory.TopNode)
                return;

            if (Confirm("Delete selected map " + node.Name + " from disk?"))
            {
                File.Delete(node.Name);
                Log("Map file " + node.Name + " deleted");
                UpdateDirectoryTree();
            }
        }

        private void PnlDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            LoadMap(e.Node.Name);
        }

        private void BtnDirectoryOpen_Click(object sender, EventArgs e)
        {
            Process.Start(PnlDirectory.TopNode.Name);
        }

        private void BtnMapAddLayer_Click(object sender, EventArgs e)
        {
            AddEmptyMapLayer();
        }

        private void AddEmptyMapLayer()
        {
            Map.Layers.Add(new MapLayer(Map.DefaultWidth, Map.DefaultHeight));
            UpdateMapLayerList();
        }

        private void SelectMapLayer(int layer)
        {
            MapBox.MapLayer = layer;
            CmbMapLayer.SelectedIndex = layer;
        }

        private void UpdateMapLayerList(bool selectLast = true)
        {
            CmbMapLayer.Items.Clear();

            for (int i = 0; i < Map.Layers.Count; i++)
                CmbMapLayer.Items.Add("Layer " + i);

            if (selectLast)
                SelectMapLayer(Map.Layers.Count - 1);

            BtnLayers.Text = CmbMapLayer.Items.Count.ToString();
        }

        private void CmbMapLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapBox.MapLayer = CmbMapLayer.SelectedIndex;
            if (MapBox.DrawOnlyCurrentLayer)
                MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        private void BtnMapDeleteLayer_Click(object sender, EventArgs e)
        {
            DeleteCurrentMapLayer();
        }

        private void DeleteCurrentMapLayer()
        {
            int index = CmbMapLayer.SelectedIndex;

            if (index == 0)
            {
                ShowWarning("Layer 0 cannot be deleted");
                return;
            }

            MapBox.Map.Layers.RemoveAt(index);
            UpdateMapLayerList();
            MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        private void BtnMapShowCurLayerOnly_Click(object sender, EventArgs e)
        {
            MapBox.DrawOnlyCurrentLayer = BtnMapShowCurLayerOnly.Checked;
            MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        private void BtnMapResize_Click(object sender, EventArgs e)
        {
            MapSizeInputWindow dialog = new MapSizeInputWindow(Map.Width, Map.Height);
            dialog.Location = MousePosition;
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            if (dialog.NewWidth < Map.Width || dialog.NewHeight < Map.Height)
            {
                string oldSizeStr = "(" + Map.Width + "," + Map.Height + ")";
                string newSizeStr = "(" + dialog.NewWidth + "," + dialog.NewHeight + ")";

                if (!Confirm("The new size " + newSizeStr + " is smaller than the current size " + oldSizeStr +
                    ". This will delete objects that are out of bounds. Are you sure?"))
                    return;
            }

            Map.Resize(dialog.NewWidth, dialog.NewHeight);
            MapBox.AdjustSize();
            MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        private void BtnMapZoomIn_Click(object sender, EventArgs e)
        {
            MapBox.ZoomIn();
        }

        private void BtnMapZoomOut_Click(object sender, EventArgs e)
        {
            MapBox.ZoomOut();
        }

        private void Map_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                MapBox.ZoomIn();
            else if (e.Delta < 0)
                MapBox.ZoomOut();
        }

        private void BtnExecCommand_Click(object sender, EventArgs e)
        {
            ExecCommandList();
        }

        private void TxtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ExecCommandList();
            }
        }

        private void ExecCommandList()
        {
            try
            {
                string[] lines = TxtCommand.Text.Trim().Split(Environment.NewLine.ToCharArray());
                foreach (string line in lines)
                    ExecCommand(line.Trim().Split(' '));
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ExecCommand(string[] command)
        {
            MapLayer map = MapBox.CurrentMapLayer;
            command[0] = command[0].Trim().ToLower();

            if (command[0] == "set")
            {
                int x = int.Parse(command[1]);
                int y = int.Parse(command[2]);

                map.SetObject(x, y, CurrentObject);
            }
            else if (command[0] == "fill")
            {
                map.FillObject(CurrentObject);
            }
            else if (command[0] == "clear")
            {
                map.Clear();
            }
            else if (command[0] == "rect")
            {
                int x = int.Parse(command[1]);
                int y = int.Parse(command[2]);
                int w = int.Parse(command[3]);
                int h = int.Parse(command[4]);

                for (int py = y; py < y + h; py++)
                    for (int px = x; px < x + w; px++)
                        map.SetObject(px, py, CurrentObject);
            }
            else if (command[0] == "hline")
            {
                int x = int.Parse(command[1]);
                int y = int.Parse(command[2]);
                int w = int.Parse(command[3]);

                for (int px = x; px < x + w; px++)
                    map.SetObject(px, y, CurrentObject);
            }
            else if (command[0] == "vline")
            {
                int x = int.Parse(command[1]);
                int y = int.Parse(command[2]);
                int h = int.Parse(command[3]);

                for (int py = y; py < y + h; py++)
                    map.SetObject(x, py, CurrentObject);
            }
            else if (command[0] == "box")
            {
                int x = int.Parse(command[1]);
                int y = int.Parse(command[2]);
                int w = int.Parse(command[3]);
                int h = int.Parse(command[4]);

                for (int px = x; px < x + w + 1; px++)
                {
                    map.SetObject(px, y, CurrentObject);
                    map.SetObject(px, y + h, CurrentObject);
                }
                for (int py = y; py < y + h; py++)
                {
                    map.SetObject(x, py, CurrentObject);
                    map.SetObject(x + w, py, CurrentObject);
                }
            }
            else if (command[0].StartsWith("print"))
            {
                int x = int.Parse(command[1]);
                int y = int.Parse(command[2]);
                int px = x;
                int py = y;

                string text = command[3];

                if (command.Length > 4)
                {
                    for (int i = 4; i < command.Length; i++)
                        text += " " + command[i];
                }

                foreach (char ch in text)
                {
                    GameObject o = new GameObject(CurrentObject);
                    o.Bytes.Clear();
                    o.Graphics.Index = ch;

                    if (ch == '\\')
                    {
                        px = x;
                        py++;
                    }
                    else
                    {
                        map.SetObject(px++, py, o);
                    }
                }
            }
            else if (command[0] == "select")
            {
                MapBox.SelectArea(
                    int.Parse(command[1]), int.Parse(command[2]), 
                    int.Parse(command[3]), int.Parse(command[4]));

                MapBox.InvalidateAllMapPositionsAndRefresh();
                Log("Area selected: " + MapBox.GetSelectedArea());
            }
            else if (command[0] == "deselect")
            {
                MapBox.DeselectArea();
                MapBox.InvalidateAllMapPositionsAndRefresh();
                Log("Area deselected");
            }
            else if (command[0] == "erase")
            {
                MapBox.EraseSelectedArea();
                MapBox.InvalidateAllMapPositionsAndRefresh();
                Log("Selected area erased");
            }
            else if (command[0] == "copy")
            {
                int x = int.Parse(command[1]);
                int y = int.Parse(command[2]);

                MapBox.CopySelectedAreaTo(x, y, false);
                MapBox.InvalidateAllMapPositionsAndRefresh();
                Log("Selected area copied to X:" + x + ",Y:" + y);
            }
            else if (command[0] == "cut")
            {
                int x = int.Parse(command[1]);
                int y = int.Parse(command[2]);

                MapBox.CopySelectedAreaTo(x, y, true);
                MapBox.InvalidateAllMapPositionsAndRefresh();
                Log("Selected area cut and pasted to X:" + x + ",Y:" + y);
            }
            else if (command[0] == "savesel")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = DataDirectory;
                dialog.Filter = "PNG image files|*.png";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                MapBox.SaveSelectedAreaAsImage(dialog.FileName);
                Log("Selected area saved to file:" + dialog.FileName);
            }

            MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        private void BtnMapBackColor_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker(Palette, "Pick map background color");
            picker.Location = MousePosition;
            if (picker.ShowDialog() != DialogResult.OK)
                return;

            Map.BackColor = picker.SelectedColor;
            MapBox.InvalidateAllMapPositionsAndRefresh();
            UpdateTilePreview();
        }

        private void MenuSaveScreenshot_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = DataDirectory;
            dialog.Filter = "PNG image files|*.png";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            MapBox.SaveScreenshot(dialog.FileName);
            Log("Map screenshot saved to file " + dialog.FileName);
        }

        private void MenuShowMapGrid_Click(object sender, EventArgs e)
        {
            MapBox.ShowGrid = MenuShowMapGrid.Checked;
            MapBox.Refresh();
        }

        private void MenuShowMapViewport_Click(object sender, EventArgs e)
        {
            MapBox.ShowViewport = MenuShowMapViewport.Checked;
            MapBox.Refresh();
        }

        private void MenuSetMapViewport_Click(object sender, EventArgs e)
        {
            ViewportConfigWindow dialog = new ViewportConfigWindow(MapBox.ViewportWidth, MapBox.ViewportHeight);
            dialog.Location = MousePosition;
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            MapBox.ViewportWidth = dialog.NewWidth;
            MapBox.ViewportHeight = dialog.NewHeight;

            MapBox.Refresh();
        }

        private void MenuViewMapFileInfo_Click(object sender, EventArgs e)
        {
            if (CurrentMapFile == null)
            {
                ShowWarning("The current map is not saved on disk");
                return;
            }

            FileInfo file = new FileInfo(CurrentMapFile);

            string info =
                "Name: " + file.Name + Environment.NewLine +
                "Size: " + (file.Length / 1024) + " KB" + Environment.NewLine +
                "Created: " + file.CreationTime + Environment.NewLine +
                "Last modified: " + file.LastWriteTime + Environment.NewLine;

            ShowInfo("Map File Information", info);
        }

        private void MenuSetBackgroundImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = DataDirectory;
            dialog.Filter = "Image files|*.png";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            MapBox.BackgroundImage = Image.FromFile(dialog.FileName);
            MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        private void MenuRemoveBackgroundImage_Click(object sender, EventArgs e)
        {
            MapBox.BackgroundImage = null;
            MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        private void BtnMapSelectArea_Click(object sender, EventArgs e)
        {
            MapBox.Mode = BtnMapSelectArea.Checked ?
                MapBox.OperationMode.Select : MapBox.OperationMode.Edit;
        }

        private void BtnTilesetEdit_Click(object sender, EventArgs e)
        {
            EditSelectedTile();
        }

        private void MenuShowMapBoundary_Click(object sender, EventArgs e)
        {
            MapBox.ShowBoundary = MenuShowMapBoundary.Checked;
            MapBox.InvalidateAllMapPositionsAndRefresh();
        }

        private void BtnTilesetExport_Click(object sender, EventArgs e)
        {
            ExportTileset();
        }

        private void BtnTilesetImport_Click(object sender, EventArgs e)
        {
            ImportTileset();
        }

        private void ExportTileset()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = DataDirectory;
            dialog.Filter = "Tileset files|*.dat";
            dialog.DefaultExt = "dat";
            dialog.AddExtension = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Tileset.Save(dialog.FileName);
                Log("Tileset exported to file " + dialog.FileName);
            }
        }

        private void ImportTileset()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = DataDirectory;
            dialog.Filter = "Tileset files|*.dat";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Tileset.Load(dialog.FileName);

                TileIndex = 0;
                TilesetBox.Refresh();
                UpdateTilesetPageIndicator();
                UpdateTilePreview();
                MapBox.InvalidateAllMapPositionsAndRefresh();

                Log("Tileset imported from file " + dialog.FileName);
            }
        }

        private void BtnTilesetClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This will load the default tileset. Are you sure?", 
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Tileset.Load(DefaultTilesetFile);

                TileIndex = 0;
                TilesetBox.Refresh();
                UpdateTilesetPageIndicator();
                UpdateTilePreview();
                MapBox.InvalidateAllMapPositionsAndRefresh();

                Log("Tileset imported from file " + DefaultTilesetFile);
            }
        }
    }
}
