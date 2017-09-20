namespace TileStudio.MapEditor
{
    partial class ColorPicker
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
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PaletteBox = new System.Windows.Forms.PictureBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtIndicator = new System.Windows.Forms.TextBox();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlMain.Controls.Add(this.PaletteBox);
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(260, 260);
            this.PnlMain.TabIndex = 0;
            // 
            // PaletteBox
            // 
            this.PaletteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaletteBox.Location = new System.Drawing.Point(0, 0);
            this.PaletteBox.Name = "PaletteBox";
            this.PaletteBox.Size = new System.Drawing.Size(256, 256);
            this.PaletteBox.TabIndex = 0;
            this.PaletteBox.TabStop = false;
            this.PaletteBox.Click += new System.EventHandler(this.PaletteBox_Click);
            this.PaletteBox.MouseLeave += new System.EventHandler(this.PaletteBox_MouseLeave);
            this.PaletteBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaletteBox_MouseMove);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(0, 258);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(130, 23);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(130, 258);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtIndicator
            // 
            this.TxtIndicator.Location = new System.Drawing.Point(0, 282);
            this.TxtIndicator.Name = "TxtIndicator";
            this.TxtIndicator.ReadOnly = true;
            this.TxtIndicator.Size = new System.Drawing.Size(260, 20);
            this.TxtIndicator.TabIndex = 3;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 303);
            this.Controls.Add(this.TxtIndicator);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.PnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "ColorPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorPicker";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorPicker_KeyDown);
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaletteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox PaletteBox;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtIndicator;
    }
}