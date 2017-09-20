namespace TileStudio.MapEditor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlTileset = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.LblTilesetPage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.PnlMapAndToolbar = new System.Windows.Forms.Panel();
            this.PnlMap = new System.Windows.Forms.Panel();
            this.MapTools = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TxtMapName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CmbMapLayer = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlColor3 = new System.Windows.Forms.Panel();
            this.PnlColor2 = new System.Windows.Forms.Panel();
            this.PnlColor1 = new System.Windows.Forms.Panel();
            this.TxtColor3 = new System.Windows.Forms.TextBox();
            this.TxtColor2 = new System.Windows.Forms.TextBox();
            this.TxtColor1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtTileIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCurrentMapFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PnlTileGfx = new System.Windows.Forms.Panel();
            this.PnlObject = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PnlDirectoryAndToolbar = new System.Windows.Forms.Panel();
            this.PnlDirectory = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.TbpLog = new System.Windows.Forms.TabPage();
            this.TbpCommand = new System.Windows.Forms.TabPage();
            this.TxtCommand = new System.Windows.Forms.TextBox();
            this.BtnDirectoryOpen = new System.Windows.Forms.ToolStripButton();
            this.BtnDirectoryAdd = new System.Windows.Forms.ToolStripButton();
            this.BtnDirectoryDelete = new System.Windows.Forms.ToolStripButton();
            this.BtnPresets = new System.Windows.Forms.Button();
            this.BtnEraseObject = new System.Windows.Forms.Button();
            this.PreviewTileBox = new System.Windows.Forms.PictureBox();
            this.BtnTilesetPrevPage = new System.Windows.Forms.ToolStripButton();
            this.BtnTilesetNextPage = new System.Windows.Forms.ToolStripButton();
            this.BtnTilesetEdit = new System.Windows.Forms.ToolStripButton();
            this.BtnTilesetExport = new System.Windows.Forms.ToolStripButton();
            this.BtnMapLoad = new System.Windows.Forms.ToolStripButton();
            this.BtnMapSave = new System.Windows.Forms.ToolStripButton();
            this.BtnMapSetData = new System.Windows.Forms.ToolStripButton();
            this.BtnMapResize = new System.Windows.Forms.ToolStripButton();
            this.BtnMapBackColor = new System.Windows.Forms.ToolStripButton();
            this.BtnLayers = new System.Windows.Forms.ToolStripButton();
            this.BtnMapAddLayer = new System.Windows.Forms.ToolStripButton();
            this.BtnMapDeleteLayer = new System.Windows.Forms.ToolStripButton();
            this.BtnMapShowCurLayerOnly = new System.Windows.Forms.ToolStripButton();
            this.BtnMapSelectArea = new System.Windows.Forms.ToolStripButton();
            this.BtnMapFill = new System.Windows.Forms.ToolStripButton();
            this.BtnMapClear = new System.Windows.Forms.ToolStripButton();
            this.BtnMapZoomIn = new System.Windows.Forms.ToolStripButton();
            this.BtnMapZoomOut = new System.Windows.Forms.ToolStripButton();
            this.BtnOtherTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuShowMapGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShowMapBoundary = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShowMapViewport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetMapViewport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSetBackgroundImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRemoveBackgroundImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveScreenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuViewMapFileInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTilesetImport = new System.Windows.Forms.ToolStripButton();
            this.BtnTilesetClear = new System.Windows.Forms.ToolStripButton();
            this.GrdBytes = new TileStudio.CommonCtrl.BytesView();
            this.TilesetBox = new TileStudio.MapEditor.TilesetBox();
            this.MapBox = new TileStudio.MapEditor.MapBox();
            this.MainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.PnlTileset.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.PnlMapAndToolbar.SuspendLayout();
            this.PnlMap.SuspendLayout();
            this.MapTools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlTileGfx.SuspendLayout();
            this.PnlObject.SuspendLayout();
            this.PnlDirectoryAndToolbar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.TbpLog.SuspendLayout();
            this.TbpCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewTileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TilesetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1130, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 656);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1130, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.LblStatus.Size = new System.Drawing.Size(1115, 17);
            this.LblStatus.Spring = true;
            this.LblStatus.Text = "Status";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlTileset
            // 
            this.PnlTileset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlTileset.Controls.Add(this.toolStrip2);
            this.PnlTileset.Controls.Add(this.TilesetBox);
            this.PnlTileset.Location = new System.Drawing.Point(0, 23);
            this.PnlTileset.Name = "PnlTileset";
            this.PnlTileset.Size = new System.Drawing.Size(260, 285);
            this.PnlTileset.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnTilesetPrevPage,
            this.LblTilesetPage,
            this.BtnTilesetNextPage,
            this.toolStripSeparator7,
            this.BtnTilesetEdit,
            this.BtnTilesetExport,
            this.BtnTilesetImport,
            this.BtnTilesetClear});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(256, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // LblTilesetPage
            // 
            this.LblTilesetPage.BackColor = System.Drawing.SystemColors.Window;
            this.LblTilesetPage.Name = "LblTilesetPage";
            this.LblTilesetPage.Size = new System.Drawing.Size(30, 22);
            this.LblTilesetPage.Text = "0 / 0";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // PnlMapAndToolbar
            // 
            this.PnlMapAndToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMapAndToolbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlMapAndToolbar.Controls.Add(this.PnlMap);
            this.PnlMapAndToolbar.Controls.Add(this.MapTools);
            this.PnlMapAndToolbar.Location = new System.Drawing.Point(278, 55);
            this.PnlMapAndToolbar.Name = "PnlMapAndToolbar";
            this.PnlMapAndToolbar.Size = new System.Drawing.Size(644, 443);
            this.PnlMapAndToolbar.TabIndex = 4;
            // 
            // PnlMap
            // 
            this.PnlMap.AutoScroll = true;
            this.PnlMap.BackColor = System.Drawing.Color.Black;
            this.PnlMap.Controls.Add(this.MapBox);
            this.PnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMap.Location = new System.Drawing.Point(0, 25);
            this.PnlMap.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMap.Name = "PnlMap";
            this.PnlMap.Size = new System.Drawing.Size(640, 414);
            this.PnlMap.TabIndex = 2;
            // 
            // MapTools
            // 
            this.MapTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMapLoad,
            this.BtnMapSave,
            this.toolStripSeparator2,
            this.TxtMapName,
            this.BtnMapSetData,
            this.BtnMapResize,
            this.BtnMapBackColor,
            this.toolStripSeparator3,
            this.BtnLayers,
            this.CmbMapLayer,
            this.BtnMapAddLayer,
            this.BtnMapDeleteLayer,
            this.BtnMapShowCurLayerOnly,
            this.toolStripSeparator1,
            this.BtnMapSelectArea,
            this.BtnMapFill,
            this.BtnMapClear,
            this.BtnMapZoomIn,
            this.BtnMapZoomOut,
            this.toolStripSeparator4,
            this.BtnOtherTools});
            this.MapTools.Location = new System.Drawing.Point(0, 0);
            this.MapTools.Name = "MapTools";
            this.MapTools.Size = new System.Drawing.Size(640, 25);
            this.MapTools.TabIndex = 1;
            this.MapTools.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TxtMapName
            // 
            this.TxtMapName.Name = "TxtMapName";
            this.TxtMapName.Size = new System.Drawing.Size(120, 25);
            this.TxtMapName.TextChanged += new System.EventHandler(this.TxtMapName_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // CmbMapLayer
            // 
            this.CmbMapLayer.AutoSize = false;
            this.CmbMapLayer.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.CmbMapLayer.Name = "CmbMapLayer";
            this.CmbMapLayer.Size = new System.Drawing.Size(70, 23);
            this.CmbMapLayer.SelectedIndexChanged += new System.EventHandler(this.CmbMapLayer_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "IX";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlColor3
            // 
            this.PnlColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlColor3.Location = new System.Drawing.Point(167, 19);
            this.PnlColor3.Name = "PnlColor3";
            this.PnlColor3.Size = new System.Drawing.Size(56, 36);
            this.PnlColor3.TabIndex = 7;
            this.PnlColor3.Click += new System.EventHandler(this.PnlColor_Click);
            // 
            // PnlColor2
            // 
            this.PnlColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlColor2.Location = new System.Drawing.Point(111, 19);
            this.PnlColor2.Name = "PnlColor2";
            this.PnlColor2.Size = new System.Drawing.Size(56, 36);
            this.PnlColor2.TabIndex = 7;
            this.PnlColor2.Click += new System.EventHandler(this.PnlColor_Click);
            // 
            // PnlColor1
            // 
            this.PnlColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlColor1.Location = new System.Drawing.Point(55, 19);
            this.PnlColor1.Name = "PnlColor1";
            this.PnlColor1.Size = new System.Drawing.Size(56, 36);
            this.PnlColor1.TabIndex = 6;
            this.PnlColor1.Click += new System.EventHandler(this.PnlColor_Click);
            // 
            // TxtColor3
            // 
            this.TxtColor3.Enabled = false;
            this.TxtColor3.Location = new System.Drawing.Point(167, 55);
            this.TxtColor3.Name = "TxtColor3";
            this.TxtColor3.ReadOnly = true;
            this.TxtColor3.Size = new System.Drawing.Size(54, 20);
            this.TxtColor3.TabIndex = 8;
            this.TxtColor3.Text = "0";
            this.TxtColor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtColor2
            // 
            this.TxtColor2.Enabled = false;
            this.TxtColor2.Location = new System.Drawing.Point(111, 55);
            this.TxtColor2.Name = "TxtColor2";
            this.TxtColor2.ReadOnly = true;
            this.TxtColor2.Size = new System.Drawing.Size(54, 20);
            this.TxtColor2.TabIndex = 7;
            this.TxtColor2.Text = "0";
            this.TxtColor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtColor1
            // 
            this.TxtColor1.Enabled = false;
            this.TxtColor1.Location = new System.Drawing.Point(55, 55);
            this.TxtColor1.Name = "TxtColor1";
            this.TxtColor1.ReadOnly = true;
            this.TxtColor1.Size = new System.Drawing.Size(54, 20);
            this.TxtColor1.TabIndex = 6;
            this.TxtColor1.Text = "0";
            this.TxtColor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PreviewTileBox);
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 36);
            this.panel1.TabIndex = 5;
            // 
            // TxtTileIndex
            // 
            this.TxtTileIndex.Enabled = false;
            this.TxtTileIndex.Location = new System.Drawing.Point(0, 55);
            this.TxtTileIndex.Name = "TxtTileIndex";
            this.TxtTileIndex.ReadOnly = true;
            this.TxtTileIndex.Size = new System.Drawing.Size(54, 20);
            this.TxtTileIndex.TabIndex = 4;
            this.TxtTileIndex.Text = "0";
            this.TxtTileIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(167, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "C3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(111, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "C2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "C1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtLog
            // 
            this.TxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLog.Location = new System.Drawing.Point(3, 3);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(1091, 97);
            this.TxtLog.TabIndex = 15;
            this.TxtLog.Text = "Log window";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 310);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Graphics";
            // 
            // LblCurrentMapFile
            // 
            this.LblCurrentMapFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCurrentMapFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblCurrentMapFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCurrentMapFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentMapFile.ForeColor = System.Drawing.Color.White;
            this.LblCurrentMapFile.Location = new System.Drawing.Point(278, 34);
            this.LblCurrentMapFile.Name = "LblCurrentMapFile";
            this.LblCurrentMapFile.Padding = new System.Windows.Forms.Padding(2);
            this.LblCurrentMapFile.Size = new System.Drawing.Size(642, 20);
            this.LblCurrentMapFile.TabIndex = 17;
            this.LblCurrentMapFile.Text = "Map";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(260, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tileset";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.RoyalBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 500);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(2);
            this.label9.Size = new System.Drawing.Size(1105, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Log / Command";
            // 
            // PnlTileGfx
            // 
            this.PnlTileGfx.Controls.Add(this.BtnPresets);
            this.PnlTileGfx.Controls.Add(this.BtnEraseObject);
            this.PnlTileGfx.Controls.Add(this.panel1);
            this.PnlTileGfx.Controls.Add(this.label4);
            this.PnlTileGfx.Controls.Add(this.label5);
            this.PnlTileGfx.Controls.Add(this.PnlColor3);
            this.PnlTileGfx.Controls.Add(this.label6);
            this.PnlTileGfx.Controls.Add(this.PnlColor2);
            this.PnlTileGfx.Controls.Add(this.label7);
            this.PnlTileGfx.Controls.Add(this.PnlColor1);
            this.PnlTileGfx.Controls.Add(this.TxtTileIndex);
            this.PnlTileGfx.Controls.Add(this.TxtColor3);
            this.PnlTileGfx.Controls.Add(this.TxtColor1);
            this.PnlTileGfx.Controls.Add(this.TxtColor2);
            this.PnlTileGfx.Location = new System.Drawing.Point(0, 332);
            this.PnlTileGfx.Name = "PnlTileGfx";
            this.PnlTileGfx.Size = new System.Drawing.Size(258, 79);
            this.PnlTileGfx.TabIndex = 11;
            // 
            // PnlObject
            // 
            this.PnlObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlObject.Controls.Add(this.GrdBytes);
            this.PnlObject.Controls.Add(this.label8);
            this.PnlObject.Controls.Add(this.PnlTileGfx);
            this.PnlObject.Controls.Add(this.PnlTileset);
            this.PnlObject.Controls.Add(this.label1);
            this.PnlObject.Controls.Add(this.label3);
            this.PnlObject.Location = new System.Drawing.Point(12, 34);
            this.PnlObject.Name = "PnlObject";
            this.PnlObject.Size = new System.Drawing.Size(260, 462);
            this.PnlObject.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 411);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2);
            this.label8.Size = new System.Drawing.Size(260, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Data";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.RoyalBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(926, 34);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2);
            this.label10.Size = new System.Drawing.Size(191, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Directory";
            // 
            // PnlDirectoryAndToolbar
            // 
            this.PnlDirectoryAndToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDirectoryAndToolbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlDirectoryAndToolbar.Controls.Add(this.PnlDirectory);
            this.PnlDirectoryAndToolbar.Controls.Add(this.toolStrip1);
            this.PnlDirectoryAndToolbar.Location = new System.Drawing.Point(926, 55);
            this.PnlDirectoryAndToolbar.Name = "PnlDirectoryAndToolbar";
            this.PnlDirectoryAndToolbar.Size = new System.Drawing.Size(193, 441);
            this.PnlDirectoryAndToolbar.TabIndex = 23;
            // 
            // PnlDirectory
            // 
            this.PnlDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDirectory.ImageIndex = 0;
            this.PnlDirectory.ImageList = this.imageList1;
            this.PnlDirectory.Location = new System.Drawing.Point(0, 25);
            this.PnlDirectory.Name = "PnlDirectory";
            treeNode1.Name = "Root";
            treeNode1.Text = "Root";
            this.PnlDirectory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.PnlDirectory.SelectedImageIndex = 0;
            this.PnlDirectory.Size = new System.Drawing.Size(189, 412);
            this.PnlDirectory.TabIndex = 23;
            this.PnlDirectory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PnlDirectory_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "map.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnDirectoryOpen,
            this.BtnDirectoryAdd,
            this.BtnDirectoryDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(189, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TabPanel
            // 
            this.TabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPanel.Controls.Add(this.TbpLog);
            this.TabPanel.Controls.Add(this.TbpCommand);
            this.TabPanel.Location = new System.Drawing.Point(12, 524);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(1105, 129);
            this.TabPanel.TabIndex = 24;
            // 
            // TbpLog
            // 
            this.TbpLog.Controls.Add(this.TxtLog);
            this.TbpLog.Location = new System.Drawing.Point(4, 22);
            this.TbpLog.Name = "TbpLog";
            this.TbpLog.Padding = new System.Windows.Forms.Padding(3);
            this.TbpLog.Size = new System.Drawing.Size(1097, 103);
            this.TbpLog.TabIndex = 0;
            this.TbpLog.Text = "Log";
            this.TbpLog.UseVisualStyleBackColor = true;
            // 
            // TbpCommand
            // 
            this.TbpCommand.Controls.Add(this.TxtCommand);
            this.TbpCommand.Location = new System.Drawing.Point(4, 22);
            this.TbpCommand.Name = "TbpCommand";
            this.TbpCommand.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCommand.Size = new System.Drawing.Size(1097, 103);
            this.TbpCommand.TabIndex = 1;
            this.TbpCommand.Text = "Command";
            this.TbpCommand.UseVisualStyleBackColor = true;
            // 
            // TxtCommand
            // 
            this.TxtCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCommand.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCommand.Location = new System.Drawing.Point(3, 3);
            this.TxtCommand.Multiline = true;
            this.TxtCommand.Name = "TxtCommand";
            this.TxtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtCommand.Size = new System.Drawing.Size(1091, 97);
            this.TxtCommand.TabIndex = 16;
            this.TxtCommand.Text = "Command window";
            this.TxtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCommand_KeyDown);
            // 
            // BtnDirectoryOpen
            // 
            this.BtnDirectoryOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDirectoryOpen.Image = global::TileStudio.Properties.Resources.folder_vertical_open;
            this.BtnDirectoryOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDirectoryOpen.Name = "BtnDirectoryOpen";
            this.BtnDirectoryOpen.Size = new System.Drawing.Size(23, 22);
            this.BtnDirectoryOpen.Text = "Open directory";
            this.BtnDirectoryOpen.Click += new System.EventHandler(this.BtnDirectoryOpen_Click);
            // 
            // BtnDirectoryAdd
            // 
            this.BtnDirectoryAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDirectoryAdd.Image = global::TileStudio.Properties.Resources.add;
            this.BtnDirectoryAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDirectoryAdd.Name = "BtnDirectoryAdd";
            this.BtnDirectoryAdd.Size = new System.Drawing.Size(23, 22);
            this.BtnDirectoryAdd.Text = "Add empty map file";
            this.BtnDirectoryAdd.Click += new System.EventHandler(this.BtnDirectoryAdd_Click);
            // 
            // BtnDirectoryDelete
            // 
            this.BtnDirectoryDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDirectoryDelete.Image = global::TileStudio.Properties.Resources.delete;
            this.BtnDirectoryDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDirectoryDelete.Name = "BtnDirectoryDelete";
            this.BtnDirectoryDelete.Size = new System.Drawing.Size(23, 22);
            this.BtnDirectoryDelete.Text = "Delete selected map file";
            this.BtnDirectoryDelete.Click += new System.EventHandler(this.BtnDirectoryDelete_Click);
            // 
            // BtnPresets
            // 
            this.BtnPresets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPresets.Image = global::TileStudio.Properties.Resources.application_view_icons;
            this.BtnPresets.Location = new System.Drawing.Point(224, 38);
            this.BtnPresets.Name = "BtnPresets";
            this.BtnPresets.Size = new System.Drawing.Size(34, 37);
            this.BtnPresets.TabIndex = 12;
            this.BtnPresets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPresets.UseVisualStyleBackColor = true;
            // 
            // BtnEraseObject
            // 
            this.BtnEraseObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEraseObject.Image = global::TileStudio.Properties.Resources.draw_eraser;
            this.BtnEraseObject.Location = new System.Drawing.Point(224, 0);
            this.BtnEraseObject.Name = "BtnEraseObject";
            this.BtnEraseObject.Size = new System.Drawing.Size(34, 37);
            this.BtnEraseObject.TabIndex = 11;
            this.BtnEraseObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEraseObject.UseVisualStyleBackColor = true;
            this.BtnEraseObject.Click += new System.EventHandler(this.BtnEraseObject_Click);
            // 
            // PreviewTileBox
            // 
            this.PreviewTileBox.BackColor = System.Drawing.Color.Black;
            this.PreviewTileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewTileBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewTileBox.Name = "PreviewTileBox";
            this.PreviewTileBox.Size = new System.Drawing.Size(52, 32);
            this.PreviewTileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PreviewTileBox.TabIndex = 0;
            this.PreviewTileBox.TabStop = false;
            this.PreviewTileBox.Click += new System.EventHandler(this.PreviewTileBox_Click);
            // 
            // BtnTilesetPrevPage
            // 
            this.BtnTilesetPrevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnTilesetPrevPage.Image = global::TileStudio.Properties.Resources.bullet_arrow_left;
            this.BtnTilesetPrevPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTilesetPrevPage.Name = "BtnTilesetPrevPage";
            this.BtnTilesetPrevPage.Size = new System.Drawing.Size(23, 22);
            this.BtnTilesetPrevPage.Text = "Previous page";
            this.BtnTilesetPrevPage.Click += new System.EventHandler(this.BtnTilesetNextPage_Click);
            // 
            // BtnTilesetNextPage
            // 
            this.BtnTilesetNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnTilesetNextPage.Image = global::TileStudio.Properties.Resources.bullet_arrow_right;
            this.BtnTilesetNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTilesetNextPage.Name = "BtnTilesetNextPage";
            this.BtnTilesetNextPage.Size = new System.Drawing.Size(23, 22);
            this.BtnTilesetNextPage.Text = "Next page";
            this.BtnTilesetNextPage.Click += new System.EventHandler(this.BtnTilesetPrevPage_Click);
            // 
            // BtnTilesetEdit
            // 
            this.BtnTilesetEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnTilesetEdit.Image = global::TileStudio.Properties.Resources.pencil;
            this.BtnTilesetEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTilesetEdit.Name = "BtnTilesetEdit";
            this.BtnTilesetEdit.Size = new System.Drawing.Size(23, 22);
            this.BtnTilesetEdit.Text = "Edit tileset";
            this.BtnTilesetEdit.Click += new System.EventHandler(this.BtnTilesetEdit_Click);
            // 
            // BtnTilesetExport
            // 
            this.BtnTilesetExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnTilesetExport.Image = global::TileStudio.Properties.Resources.diskette;
            this.BtnTilesetExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTilesetExport.Name = "BtnTilesetExport";
            this.BtnTilesetExport.Size = new System.Drawing.Size(23, 22);
            this.BtnTilesetExport.Text = "Export tileset";
            this.BtnTilesetExport.Click += new System.EventHandler(this.BtnTilesetExport_Click);
            // 
            // BtnMapLoad
            // 
            this.BtnMapLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapLoad.Image = global::TileStudio.Properties.Resources.folder;
            this.BtnMapLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapLoad.Name = "BtnMapLoad";
            this.BtnMapLoad.Size = new System.Drawing.Size(23, 22);
            this.BtnMapLoad.Text = "Load map";
            this.BtnMapLoad.Click += new System.EventHandler(this.BtnMapLoad_Click);
            // 
            // BtnMapSave
            // 
            this.BtnMapSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapSave.Image = global::TileStudio.Properties.Resources.diskette;
            this.BtnMapSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapSave.Name = "BtnMapSave";
            this.BtnMapSave.Size = new System.Drawing.Size(23, 22);
            this.BtnMapSave.Text = "Save map";
            this.BtnMapSave.Click += new System.EventHandler(this.BtnMapSave_Click);
            // 
            // BtnMapSetData
            // 
            this.BtnMapSetData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapSetData.Image = global::TileStudio.Properties.Resources.map_edit;
            this.BtnMapSetData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapSetData.Name = "BtnMapSetData";
            this.BtnMapSetData.Size = new System.Drawing.Size(23, 22);
            this.BtnMapSetData.Text = "Set map header data";
            this.BtnMapSetData.Click += new System.EventHandler(this.BtnMapSetData_Click);
            // 
            // BtnMapResize
            // 
            this.BtnMapResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapResize.Image = global::TileStudio.Properties.Resources.layer_resize;
            this.BtnMapResize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapResize.Name = "BtnMapResize";
            this.BtnMapResize.Size = new System.Drawing.Size(23, 22);
            this.BtnMapResize.Text = "Resize map";
            this.BtnMapResize.Click += new System.EventHandler(this.BtnMapResize_Click);
            // 
            // BtnMapBackColor
            // 
            this.BtnMapBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapBackColor.Image = global::TileStudio.Properties.Resources.color_wheel;
            this.BtnMapBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapBackColor.Name = "BtnMapBackColor";
            this.BtnMapBackColor.Size = new System.Drawing.Size(23, 22);
            this.BtnMapBackColor.Text = "Set map background color";
            this.BtnMapBackColor.Click += new System.EventHandler(this.BtnMapBackColor_Click);
            // 
            // BtnLayers
            // 
            this.BtnLayers.AutoToolTip = false;
            this.BtnLayers.Image = global::TileStudio.Properties.Resources.layers;
            this.BtnLayers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLayers.Name = "BtnLayers";
            this.BtnLayers.Size = new System.Drawing.Size(33, 22);
            this.BtnLayers.Text = "0";
            // 
            // BtnMapAddLayer
            // 
            this.BtnMapAddLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapAddLayer.Image = global::TileStudio.Properties.Resources.layer_add;
            this.BtnMapAddLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapAddLayer.Name = "BtnMapAddLayer";
            this.BtnMapAddLayer.Size = new System.Drawing.Size(23, 22);
            this.BtnMapAddLayer.Text = "Add empty layer";
            this.BtnMapAddLayer.Click += new System.EventHandler(this.BtnMapAddLayer_Click);
            // 
            // BtnMapDeleteLayer
            // 
            this.BtnMapDeleteLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapDeleteLayer.Image = global::TileStudio.Properties.Resources.layer_delete;
            this.BtnMapDeleteLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapDeleteLayer.Name = "BtnMapDeleteLayer";
            this.BtnMapDeleteLayer.Size = new System.Drawing.Size(23, 22);
            this.BtnMapDeleteLayer.Text = "Delete layer";
            this.BtnMapDeleteLayer.Click += new System.EventHandler(this.BtnMapDeleteLayer_Click);
            // 
            // BtnMapShowCurLayerOnly
            // 
            this.BtnMapShowCurLayerOnly.CheckOnClick = true;
            this.BtnMapShowCurLayerOnly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapShowCurLayerOnly.Image = global::TileStudio.Properties.Resources.eye;
            this.BtnMapShowCurLayerOnly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapShowCurLayerOnly.Name = "BtnMapShowCurLayerOnly";
            this.BtnMapShowCurLayerOnly.Size = new System.Drawing.Size(23, 22);
            this.BtnMapShowCurLayerOnly.Text = "Show only current layer";
            this.BtnMapShowCurLayerOnly.Click += new System.EventHandler(this.BtnMapShowCurLayerOnly_Click);
            // 
            // BtnMapSelectArea
            // 
            this.BtnMapSelectArea.CheckOnClick = true;
            this.BtnMapSelectArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapSelectArea.Image = global::TileStudio.Properties.Resources.select;
            this.BtnMapSelectArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapSelectArea.Name = "BtnMapSelectArea";
            this.BtnMapSelectArea.Size = new System.Drawing.Size(23, 22);
            this.BtnMapSelectArea.Text = "Select area";
            this.BtnMapSelectArea.Click += new System.EventHandler(this.BtnMapSelectArea_Click);
            // 
            // BtnMapFill
            // 
            this.BtnMapFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapFill.Image = global::TileStudio.Properties.Resources.paintcan;
            this.BtnMapFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapFill.Name = "BtnMapFill";
            this.BtnMapFill.Size = new System.Drawing.Size(23, 22);
            this.BtnMapFill.Text = "Fill layer";
            this.BtnMapFill.Click += new System.EventHandler(this.BtnMapFill_Click);
            // 
            // BtnMapClear
            // 
            this.BtnMapClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapClear.Image = global::TileStudio.Properties.Resources.broom;
            this.BtnMapClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapClear.Name = "BtnMapClear";
            this.BtnMapClear.Size = new System.Drawing.Size(23, 22);
            this.BtnMapClear.Text = "Clear layer";
            this.BtnMapClear.Click += new System.EventHandler(this.BtnMapClear_Click);
            // 
            // BtnMapZoomIn
            // 
            this.BtnMapZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapZoomIn.Image = global::TileStudio.Properties.Resources.zoom_in;
            this.BtnMapZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapZoomIn.Name = "BtnMapZoomIn";
            this.BtnMapZoomIn.Size = new System.Drawing.Size(23, 22);
            this.BtnMapZoomIn.Text = "Zoom in";
            this.BtnMapZoomIn.Click += new System.EventHandler(this.BtnMapZoomIn_Click);
            // 
            // BtnMapZoomOut
            // 
            this.BtnMapZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMapZoomOut.Image = global::TileStudio.Properties.Resources.zoom_out;
            this.BtnMapZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMapZoomOut.Name = "BtnMapZoomOut";
            this.BtnMapZoomOut.Size = new System.Drawing.Size(23, 22);
            this.BtnMapZoomOut.Text = "Zoom out";
            this.BtnMapZoomOut.Click += new System.EventHandler(this.BtnMapZoomOut_Click);
            // 
            // BtnOtherTools
            // 
            this.BtnOtherTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOtherTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuShowMapGrid,
            this.MenuShowMapBoundary,
            this.MenuShowMapViewport,
            this.MenuSetMapViewport,
            this.toolStripSeparator5,
            this.MenuSetBackgroundImage,
            this.MenuRemoveBackgroundImage,
            this.MenuSaveScreenshot,
            this.toolStripSeparator6,
            this.MenuViewMapFileInfo});
            this.BtnOtherTools.Image = global::TileStudio.Properties.Resources.combo_box;
            this.BtnOtherTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOtherTools.Name = "BtnOtherTools";
            this.BtnOtherTools.Size = new System.Drawing.Size(29, 22);
            this.BtnOtherTools.Text = "Other options";
            // 
            // MenuShowMapGrid
            // 
            this.MenuShowMapGrid.Checked = true;
            this.MenuShowMapGrid.CheckOnClick = true;
            this.MenuShowMapGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuShowMapGrid.Image = global::TileStudio.Properties.Resources.layouts_four_grid;
            this.MenuShowMapGrid.Name = "MenuShowMapGrid";
            this.MenuShowMapGrid.Size = new System.Drawing.Size(220, 22);
            this.MenuShowMapGrid.Text = "Show grid";
            this.MenuShowMapGrid.Click += new System.EventHandler(this.MenuShowMapGrid_Click);
            // 
            // MenuShowMapBoundary
            // 
            this.MenuShowMapBoundary.Checked = true;
            this.MenuShowMapBoundary.CheckOnClick = true;
            this.MenuShowMapBoundary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuShowMapBoundary.Image = global::TileStudio.Properties.Resources.select_restangular;
            this.MenuShowMapBoundary.Name = "MenuShowMapBoundary";
            this.MenuShowMapBoundary.Size = new System.Drawing.Size(220, 22);
            this.MenuShowMapBoundary.Text = "Show boundary";
            this.MenuShowMapBoundary.Click += new System.EventHandler(this.MenuShowMapBoundary_Click);
            // 
            // MenuShowMapViewport
            // 
            this.MenuShowMapViewport.CheckOnClick = true;
            this.MenuShowMapViewport.Image = global::TileStudio.Properties.Resources.layer_arrange;
            this.MenuShowMapViewport.Name = "MenuShowMapViewport";
            this.MenuShowMapViewport.Size = new System.Drawing.Size(220, 22);
            this.MenuShowMapViewport.Text = "Show viewport";
            this.MenuShowMapViewport.Click += new System.EventHandler(this.MenuShowMapViewport_Click);
            // 
            // MenuSetMapViewport
            // 
            this.MenuSetMapViewport.Name = "MenuSetMapViewport";
            this.MenuSetMapViewport.Size = new System.Drawing.Size(220, 22);
            this.MenuSetMapViewport.Text = "Set viewport size";
            this.MenuSetMapViewport.Click += new System.EventHandler(this.MenuSetMapViewport_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(217, 6);
            // 
            // MenuSetBackgroundImage
            // 
            this.MenuSetBackgroundImage.Image = global::TileStudio.Properties.Resources.picture_add;
            this.MenuSetBackgroundImage.Name = "MenuSetBackgroundImage";
            this.MenuSetBackgroundImage.Size = new System.Drawing.Size(220, 22);
            this.MenuSetBackgroundImage.Text = "Set background image";
            this.MenuSetBackgroundImage.Click += new System.EventHandler(this.MenuSetBackgroundImage_Click);
            // 
            // MenuRemoveBackgroundImage
            // 
            this.MenuRemoveBackgroundImage.Image = global::TileStudio.Properties.Resources.picture_delete;
            this.MenuRemoveBackgroundImage.Name = "MenuRemoveBackgroundImage";
            this.MenuRemoveBackgroundImage.Size = new System.Drawing.Size(220, 22);
            this.MenuRemoveBackgroundImage.Text = "Remove background image";
            this.MenuRemoveBackgroundImage.Click += new System.EventHandler(this.MenuRemoveBackgroundImage_Click);
            // 
            // MenuSaveScreenshot
            // 
            this.MenuSaveScreenshot.Image = global::TileStudio.Properties.Resources.camera;
            this.MenuSaveScreenshot.Name = "MenuSaveScreenshot";
            this.MenuSaveScreenshot.Size = new System.Drawing.Size(220, 22);
            this.MenuSaveScreenshot.Text = "Save screenshot";
            this.MenuSaveScreenshot.Click += new System.EventHandler(this.MenuSaveScreenshot_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(217, 6);
            // 
            // MenuViewMapFileInfo
            // 
            this.MenuViewMapFileInfo.Image = global::TileStudio.Properties.Resources.information;
            this.MenuViewMapFileInfo.Name = "MenuViewMapFileInfo";
            this.MenuViewMapFileInfo.Size = new System.Drawing.Size(220, 22);
            this.MenuViewMapFileInfo.Text = "View map file info";
            this.MenuViewMapFileInfo.Click += new System.EventHandler(this.MenuViewMapFileInfo_Click);
            // 
            // BtnTilesetImport
            // 
            this.BtnTilesetImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnTilesetImport.Image = global::TileStudio.Properties.Resources.folder;
            this.BtnTilesetImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTilesetImport.Name = "BtnTilesetImport";
            this.BtnTilesetImport.Size = new System.Drawing.Size(23, 22);
            this.BtnTilesetImport.Text = "Import tileset";
            this.BtnTilesetImport.Click += new System.EventHandler(this.BtnTilesetImport_Click);
            // 
            // BtnTilesetClear
            // 
            this.BtnTilesetClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnTilesetClear.Image = global::TileStudio.Properties.Resources.broom;
            this.BtnTilesetClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTilesetClear.Name = "BtnTilesetClear";
            this.BtnTilesetClear.Size = new System.Drawing.Size(23, 22);
            this.BtnTilesetClear.Text = "Reset tileset";
            this.BtnTilesetClear.Click += new System.EventHandler(this.BtnTilesetClear_Click);
            // 
            // GrdBytes
            // 
            this.GrdBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GrdBytes.Bytes = ((System.Collections.Generic.List<byte>)(resources.GetObject("GrdBytes.Bytes")));
            this.GrdBytes.Location = new System.Drawing.Point(0, 432);
            this.GrdBytes.Name = "GrdBytes";
            this.GrdBytes.Size = new System.Drawing.Size(260, 29);
            this.GrdBytes.TabIndex = 20;
            // 
            // TilesetBox
            // 
            this.TilesetBox.BackColor = System.Drawing.Color.White;
            this.TilesetBox.EditorWindow = null;
            this.TilesetBox.Location = new System.Drawing.Point(0, 25);
            this.TilesetBox.Name = "TilesetBox";
            this.TilesetBox.Size = new System.Drawing.Size(256, 256);
            this.TilesetBox.TabIndex = 0;
            this.TilesetBox.TabStop = false;
            this.TilesetBox.Tileset = null;
            // 
            // MapBox
            // 
            this.MapBox.BackColor = System.Drawing.Color.Black;
            this.MapBox.Location = new System.Drawing.Point(0, 0);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(640, 480);
            this.MapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 678);
            this.Controls.Add(this.TabPanel);
            this.Controls.Add(this.PnlDirectoryAndToolbar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PnlObject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblCurrentMapFile);
            this.Controls.Add(this.PnlMapAndToolbar);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tile Studio";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.PnlTileset.ResumeLayout(false);
            this.PnlTileset.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.PnlMapAndToolbar.ResumeLayout(false);
            this.PnlMapAndToolbar.PerformLayout();
            this.PnlMap.ResumeLayout(false);
            this.PnlMap.PerformLayout();
            this.MapTools.ResumeLayout(false);
            this.MapTools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PnlTileGfx.ResumeLayout(false);
            this.PnlTileGfx.PerformLayout();
            this.PnlObject.ResumeLayout(false);
            this.PnlDirectoryAndToolbar.ResumeLayout(false);
            this.PnlDirectoryAndToolbar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TabPanel.ResumeLayout(false);
            this.TbpLog.ResumeLayout(false);
            this.TbpLog.PerformLayout();
            this.TbpCommand.ResumeLayout(false);
            this.TbpCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewTileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TilesetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.Panel PnlTileset;
        private System.Windows.Forms.Panel PnlMapAndToolbar;
        private System.Windows.Forms.Panel PnlColor3;
        private System.Windows.Forms.Panel PnlColor2;
        private System.Windows.Forms.Panel PnlColor1;
        private System.Windows.Forms.TextBox TxtColor3;
        private System.Windows.Forms.TextBox TxtColor2;
        private System.Windows.Forms.TextBox TxtColor1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private TilesetBox TilesetBox;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.TextBox TxtTileIndex;
        private System.Windows.Forms.PictureBox PreviewTileBox;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Label LblCurrentMapFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private MapBox MapBox;
        private System.Windows.Forms.ToolStrip MapTools;
        private System.Windows.Forms.Panel PnlMap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlTileGfx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnMapClear;
        private System.Windows.Forms.Panel PnlObject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton BtnMapSave;
        private System.Windows.Forms.ToolStripButton BtnMapLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnMapFill;
        private System.Windows.Forms.ToolStripTextBox TxtMapName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnMapSetData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PnlDirectoryAndToolbar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView PnlDirectory;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton BtnDirectoryAdd;
        private System.Windows.Forms.ToolStripButton BtnDirectoryDelete;
        private System.Windows.Forms.ToolStripButton BtnDirectoryOpen;
        private System.Windows.Forms.ToolStripButton BtnMapAddLayer;
        private System.Windows.Forms.ToolStripButton BtnMapDeleteLayer;
        private System.Windows.Forms.ToolStripComboBox CmbMapLayer;
        private System.Windows.Forms.ToolStripButton BtnLayers;
        private System.Windows.Forms.ToolStripButton BtnMapShowCurLayerOnly;
        private System.Windows.Forms.ToolStripButton BtnMapResize;
        private System.Windows.Forms.ToolStripButton BtnMapZoomIn;
        private System.Windows.Forms.ToolStripButton BtnMapZoomOut;
        private System.Windows.Forms.Button BtnEraseObject;
        private System.Windows.Forms.Button BtnPresets;
        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage TbpLog;
        private System.Windows.Forms.TabPage TbpCommand;
        private System.Windows.Forms.TextBox TxtCommand;
        private System.Windows.Forms.ToolStripButton BtnMapBackColor;
        private CommonCtrl.BytesView GrdBytes;
        private System.Windows.Forms.ToolStripDropDownButton BtnOtherTools;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveScreenshot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuShowMapGrid;
        private System.Windows.Forms.ToolStripMenuItem MenuSetMapViewport;
        private System.Windows.Forms.ToolStripMenuItem MenuViewMapFileInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MenuSetBackgroundImage;
        private System.Windows.Forms.ToolStripMenuItem MenuRemoveBackgroundImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem MenuShowMapViewport;
        private System.Windows.Forms.ToolStripButton BtnMapSelectArea;
        private System.Windows.Forms.ToolStripMenuItem MenuShowMapBoundary;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel LblTilesetPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton BtnTilesetPrevPage;
        private System.Windows.Forms.ToolStripButton BtnTilesetNextPage;
        private System.Windows.Forms.ToolStripButton BtnTilesetEdit;
        private System.Windows.Forms.ToolStripButton BtnTilesetExport;
        private System.Windows.Forms.ToolStripButton BtnTilesetImport;
        private System.Windows.Forms.ToolStripButton BtnTilesetClear;
    }
}