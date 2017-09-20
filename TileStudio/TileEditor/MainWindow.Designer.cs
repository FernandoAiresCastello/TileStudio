namespace TileStudio.TileEditor
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
            this.TileBoxPanel = new System.Windows.Forms.Panel();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShowColorIndexes = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn3Select = new System.Windows.Forms.Button();
            this.Btn2Select = new System.Windows.Forms.Button();
            this.Btn1Select = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtExportImport = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LblTileIndex = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.ToolStripButton();
            this.BtnNext = new System.Windows.Forms.ToolStripButton();
            this.BtnAddPage = new System.Windows.Forms.ToolStripButton();
            this.BtnCopy = new System.Windows.Forms.ToolStripButton();
            this.BtnPaste = new System.Windows.Forms.ToolStripButton();
            this.BtnClear = new System.Windows.Forms.ToolStripButton();
            this.BtnFill = new System.Windows.Forms.ToolStripButton();
            this.BtnRotate = new System.Windows.Forms.ToolStripButton();
            this.BtnFlip = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnFlipH = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFlipV = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnShift = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnShiftUp = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnShiftDown = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnShiftRight = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnShiftLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnUpdateMap2 = new System.Windows.Forms.ToolStripButton();
            this.BtnImportExport = new System.Windows.Forms.ToolStripButton();
            this.PreviewTileBox = new System.Windows.Forms.PictureBox();
            this.CmbExportImportMode = new System.Windows.Forms.ComboBox();
            this.TileBox = new TileStudio.TileEditor.TilePictureBox();
            this.TileBoxPanel.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewTileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TileBoxPanel
            // 
            this.TileBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TileBoxPanel.Controls.Add(this.TileBox);
            this.TileBoxPanel.Location = new System.Drawing.Point(12, 33);
            this.TileBoxPanel.Name = "TileBoxPanel";
            this.TileBoxPanel.Size = new System.Drawing.Size(260, 260);
            this.TileBoxPanel.TabIndex = 1;
            // 
            // Btn1
            // 
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn1.Location = new System.Drawing.Point(282, 35);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(50, 25);
            this.Btn1.TabIndex = 2;
            this.Btn1.TabStop = false;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.BtnColorCode_Click);
            // 
            // Btn2
            // 
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn2.Location = new System.Drawing.Point(282, 66);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(50, 25);
            this.Btn2.TabIndex = 3;
            this.Btn2.TabStop = false;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.BtnColorCode_Click);
            // 
            // Btn3
            // 
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn3.Location = new System.Drawing.Point(282, 97);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(50, 25);
            this.Btn3.TabIndex = 4;
            this.Btn3.TabStop = false;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.BtnColorCode_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 387);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(401, 22);
            this.StatusBar.TabIndex = 5;
            this.StatusBar.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(39, 17);
            this.LblStatus.Text = "Status";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(401, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBackColor,
            this.MenuShowGrid,
            this.MenuShowColorIndexes});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // MenuBackColor
            // 
            this.MenuBackColor.Name = "MenuBackColor";
            this.MenuBackColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.MenuBackColor.Size = new System.Drawing.Size(218, 22);
            this.MenuBackColor.Text = "Background color...";
            this.MenuBackColor.Click += new System.EventHandler(this.MenuBackColor_Click);
            // 
            // MenuShowGrid
            // 
            this.MenuShowGrid.Checked = true;
            this.MenuShowGrid.CheckOnClick = true;
            this.MenuShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuShowGrid.Name = "MenuShowGrid";
            this.MenuShowGrid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.MenuShowGrid.Size = new System.Drawing.Size(218, 22);
            this.MenuShowGrid.Text = "Show grid";
            this.MenuShowGrid.Click += new System.EventHandler(this.MenuShowGrid_Click);
            // 
            // MenuShowColorIndexes
            // 
            this.MenuShowColorIndexes.CheckOnClick = true;
            this.MenuShowColorIndexes.Name = "MenuShowColorIndexes";
            this.MenuShowColorIndexes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.MenuShowColorIndexes.Size = new System.Drawing.Size(218, 22);
            this.MenuShowColorIndexes.Text = "Show color indexes";
            this.MenuShowColorIndexes.Click += new System.EventHandler(this.MenuShowColorIndexes_Click);
            // 
            // Btn3Select
            // 
            this.Btn3Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn3Select.Location = new System.Drawing.Point(338, 97);
            this.Btn3Select.Name = "Btn3Select";
            this.Btn3Select.Size = new System.Drawing.Size(50, 25);
            this.Btn3Select.TabIndex = 12;
            this.Btn3Select.TabStop = false;
            this.Btn3Select.UseVisualStyleBackColor = true;
            this.Btn3Select.Click += new System.EventHandler(this.Btn3Select_Click);
            // 
            // Btn2Select
            // 
            this.Btn2Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn2Select.Location = new System.Drawing.Point(338, 66);
            this.Btn2Select.Name = "Btn2Select";
            this.Btn2Select.Size = new System.Drawing.Size(50, 25);
            this.Btn2Select.TabIndex = 11;
            this.Btn2Select.TabStop = false;
            this.Btn2Select.UseVisualStyleBackColor = true;
            this.Btn2Select.Click += new System.EventHandler(this.Btn2Select_Click);
            // 
            // Btn1Select
            // 
            this.Btn1Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn1Select.Location = new System.Drawing.Point(338, 35);
            this.Btn1Select.Name = "Btn1Select";
            this.Btn1Select.Size = new System.Drawing.Size(50, 25);
            this.Btn1Select.TabIndex = 10;
            this.Btn1Select.TabStop = false;
            this.Btn1Select.UseVisualStyleBackColor = true;
            this.Btn1Select.Click += new System.EventHandler(this.Btn1Select_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CmbExportImportMode);
            this.panel2.Controls.Add(this.BtnExport);
            this.panel2.Controls.Add(this.BtnImport);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.TileBoxPanel);
            this.panel2.Controls.Add(this.Btn1);
            this.panel2.Controls.Add(this.Btn3Select);
            this.panel2.Controls.Add(this.Btn2Select);
            this.panel2.Controls.Add(this.Btn1Select);
            this.panel2.Controls.Add(this.Btn3);
            this.panel2.Controls.Add(this.Btn2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 363);
            this.panel2.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtExportImport);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 49);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Export / Import";
            // 
            // TxtExportImport
            // 
            this.TxtExportImport.Location = new System.Drawing.Point(6, 19);
            this.TxtExportImport.Name = "TxtExportImport";
            this.TxtExportImport.Size = new System.Drawing.Size(360, 20);
            this.TxtExportImport.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnPrev,
            this.LblTileIndex,
            this.BtnNext,
            this.BtnAddPage,
            this.BtnCopy,
            this.BtnPaste,
            this.BtnClear,
            this.BtnFill,
            this.BtnRotate,
            this.BtnFlip,
            this.BtnShift,
            this.BtnUpdateMap2,
            this.BtnImportExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(401, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LblTileIndex
            // 
            this.LblTileIndex.BackColor = System.Drawing.SystemColors.Window;
            this.LblTileIndex.Name = "LblTileIndex";
            this.LblTileIndex.Size = new System.Drawing.Size(54, 22);
            this.LblTileIndex.Text = "000 / 000";
            this.LblTileIndex.Click += new System.EventHandler(this.TxtTileIndex_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PreviewTileBox);
            this.panel1.Location = new System.Drawing.Point(314, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 36);
            this.panel1.TabIndex = 33;
            // 
            // BtnExport
            // 
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExport.Image = global::TileStudio.Properties.Resources.bullet_arrow_down;
            this.BtnExport.Location = new System.Drawing.Point(282, 266);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(50, 25);
            this.BtnExport.TabIndex = 36;
            this.BtnExport.TabStop = false;
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImport.Image = global::TileStudio.Properties.Resources.bullet_arrow_up;
            this.BtnImport.Location = new System.Drawing.Point(338, 266);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(50, 25);
            this.BtnImport.TabIndex = 35;
            this.BtnImport.TabStop = false;
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrev.Image = global::TileStudio.Properties.Resources.bullet_arrow_left;
            this.BtnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(23, 22);
            this.BtnPrev.Text = "Previous tile";
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNext.Image = global::TileStudio.Properties.Resources.bullet_arrow_right;
            this.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(23, 22);
            this.BtnNext.Text = "Next tile";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnAddPage
            // 
            this.BtnAddPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAddPage.Image = global::TileStudio.Properties.Resources.page_white_add;
            this.BtnAddPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddPage.Name = "BtnAddPage";
            this.BtnAddPage.Size = new System.Drawing.Size(23, 22);
            this.BtnAddPage.Text = "New page (add 256 tiles)";
            this.BtnAddPage.Click += new System.EventHandler(this.BtnAddPage_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCopy.Image = global::TileStudio.Properties.Resources.page_copy;
            this.BtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(23, 22);
            this.BtnCopy.Text = "toolStripButton1";
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnPaste
            // 
            this.BtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPaste.Image = global::TileStudio.Properties.Resources.page_paste;
            this.BtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPaste.Name = "BtnPaste";
            this.BtnPaste.Size = new System.Drawing.Size(23, 22);
            this.BtnPaste.Text = "toolStripButton2";
            this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnClear.Image = global::TileStudio.Properties.Resources.broom;
            this.BtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(23, 22);
            this.BtnClear.Text = "Clear current tile";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnFill
            // 
            this.BtnFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFill.Image = global::TileStudio.Properties.Resources.paintcan;
            this.BtnFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFill.Name = "BtnFill";
            this.BtnFill.Size = new System.Drawing.Size(23, 22);
            this.BtnFill.Text = "Fill";
            this.BtnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // BtnRotate
            // 
            this.BtnRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRotate.Image = global::TileStudio.Properties.Resources.arrow_rotate_anticlockwise;
            this.BtnRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRotate.Name = "BtnRotate";
            this.BtnRotate.Size = new System.Drawing.Size(23, 22);
            this.BtnRotate.Text = "Rotate";
            this.BtnRotate.Click += new System.EventHandler(this.BtnRotate_Click);
            // 
            // BtnFlip
            // 
            this.BtnFlip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFlip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnFlipH,
            this.BtnFlipV});
            this.BtnFlip.Image = global::TileStudio.Properties.Resources.transform_flip;
            this.BtnFlip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFlip.Name = "BtnFlip";
            this.BtnFlip.Size = new System.Drawing.Size(32, 22);
            this.BtnFlip.Text = "Flip";
            // 
            // BtnFlipH
            // 
            this.BtnFlipH.Name = "BtnFlipH";
            this.BtnFlipH.Size = new System.Drawing.Size(158, 22);
            this.BtnFlipH.Text = "Flip horizontally";
            this.BtnFlipH.Click += new System.EventHandler(this.BtnFlipX_Click);
            // 
            // BtnFlipV
            // 
            this.BtnFlipV.Name = "BtnFlipV";
            this.BtnFlipV.Size = new System.Drawing.Size(158, 22);
            this.BtnFlipV.Text = "Flip vertically";
            this.BtnFlipV.Click += new System.EventHandler(this.BtnFlipY_Click);
            // 
            // BtnShift
            // 
            this.BtnShift.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnShift.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnShiftUp,
            this.BtnShiftDown,
            this.BtnShiftRight,
            this.BtnShiftLeft});
            this.BtnShift.Image = global::TileStudio.Properties.Resources.transform_move;
            this.BtnShift.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnShift.Name = "BtnShift";
            this.BtnShift.Size = new System.Drawing.Size(32, 22);
            this.BtnShift.Text = "Shift";
            // 
            // BtnShiftUp
            // 
            this.BtnShiftUp.Name = "BtnShiftUp";
            this.BtnShiftUp.Size = new System.Drawing.Size(131, 22);
            this.BtnShiftUp.Text = "Shift up";
            this.BtnShiftUp.Click += new System.EventHandler(this.BtnShiftUp_Click);
            // 
            // BtnShiftDown
            // 
            this.BtnShiftDown.Name = "BtnShiftDown";
            this.BtnShiftDown.Size = new System.Drawing.Size(131, 22);
            this.BtnShiftDown.Text = "Shift down";
            this.BtnShiftDown.Click += new System.EventHandler(this.BtnShiftDown_Click);
            // 
            // BtnShiftRight
            // 
            this.BtnShiftRight.Name = "BtnShiftRight";
            this.BtnShiftRight.Size = new System.Drawing.Size(131, 22);
            this.BtnShiftRight.Text = "Shift right";
            this.BtnShiftRight.Click += new System.EventHandler(this.BtnShiftRight_Click);
            // 
            // BtnShiftLeft
            // 
            this.BtnShiftLeft.Name = "BtnShiftLeft";
            this.BtnShiftLeft.Size = new System.Drawing.Size(131, 22);
            this.BtnShiftLeft.Text = "Shift left";
            this.BtnShiftLeft.Click += new System.EventHandler(this.BtnShiftLeft_Click);
            // 
            // BtnUpdateMap2
            // 
            this.BtnUpdateMap2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnUpdateMap2.Image = global::TileStudio.Properties.Resources.map_go;
            this.BtnUpdateMap2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUpdateMap2.Name = "BtnUpdateMap2";
            this.BtnUpdateMap2.Size = new System.Drawing.Size(23, 22);
            this.BtnUpdateMap2.Text = "Update map";
            this.BtnUpdateMap2.Click += new System.EventHandler(this.BtnUpdateMap_Click);
            // 
            // BtnImportExport
            // 
            this.BtnImportExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnImportExport.Image = global::TileStudio.Properties.Resources.script_binary;
            this.BtnImportExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnImportExport.Name = "BtnImportExport";
            this.BtnImportExport.Size = new System.Drawing.Size(23, 22);
            this.BtnImportExport.Text = "Import/Export";
            this.BtnImportExport.Click += new System.EventHandler(this.BtnImportExport_Click);
            // 
            // PreviewTileBox
            // 
            this.PreviewTileBox.BackColor = System.Drawing.Color.White;
            this.PreviewTileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewTileBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewTileBox.Name = "PreviewTileBox";
            this.PreviewTileBox.Size = new System.Drawing.Size(32, 32);
            this.PreviewTileBox.TabIndex = 0;
            this.PreviewTileBox.TabStop = false;
            // 
            // CmbExportImportMode
            // 
            this.CmbExportImportMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbExportImportMode.FormattingEnabled = true;
            this.CmbExportImportMode.Items.AddRange(new object[] {
            "String",
            "Binary",
            "Color"});
            this.CmbExportImportMode.Location = new System.Drawing.Point(282, 239);
            this.CmbExportImportMode.Name = "CmbExportImportMode";
            this.CmbExportImportMode.Size = new System.Drawing.Size(106, 21);
            this.CmbExportImportMode.TabIndex = 37;
            // 
            // TileBox
            // 
            this.TileBox.BackColor = System.Drawing.Color.White;
            this.TileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TileBox.Location = new System.Drawing.Point(0, 0);
            this.TileBox.Name = "TileBox";
            this.TileBox.Size = new System.Drawing.Size(256, 256);
            this.TileBox.TabIndex = 0;
            this.TileBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 409);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tile Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.TileBoxPanel.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewTileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TileBoxPanel;
        private TilePictureBox TileBox;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuShowGrid;
        private System.Windows.Forms.ToolStripMenuItem MenuShowColorIndexes;
        private System.Windows.Forms.ToolStripMenuItem MenuBackColor;
        private System.Windows.Forms.Button Btn3Select;
        private System.Windows.Forms.Button Btn2Select;
        private System.Windows.Forms.Button Btn1Select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PreviewTileBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnPrev;
        private System.Windows.Forms.ToolStripLabel LblTileIndex;
        private System.Windows.Forms.ToolStripButton BtnNext;
        private System.Windows.Forms.ToolStripButton BtnClear;
        private System.Windows.Forms.ToolStripButton BtnFill;
        private System.Windows.Forms.ToolStripButton BtnRotate;
        private System.Windows.Forms.ToolStripSplitButton BtnFlip;
        private System.Windows.Forms.ToolStripSplitButton BtnShift;
        private System.Windows.Forms.ToolStripMenuItem BtnFlipH;
        private System.Windows.Forms.ToolStripMenuItem BtnFlipV;
        private System.Windows.Forms.ToolStripMenuItem BtnShiftUp;
        private System.Windows.Forms.ToolStripMenuItem BtnShiftDown;
        private System.Windows.Forms.ToolStripMenuItem BtnShiftRight;
        private System.Windows.Forms.ToolStripMenuItem BtnShiftLeft;
        private System.Windows.Forms.ToolStripButton BtnAddPage;
        private System.Windows.Forms.ToolStripButton BtnUpdateMap2;
        private System.Windows.Forms.ToolStripButton BtnImportExport;
        private System.Windows.Forms.TextBox TxtExportImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.ToolStripButton BtnCopy;
        private System.Windows.Forms.ToolStripButton BtnPaste;
        private System.Windows.Forms.ComboBox CmbExportImportMode;
    }
}