namespace TileStudio.CommonCtrl
{
    partial class BytesViewWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BytesViewWindow));
            this.GrdBytes = new TileStudio.CommonCtrl.BytesView();
            this.SuspendLayout();
            // 
            // GrdBytes
            // 
            this.GrdBytes.Bytes = ((System.Collections.Generic.List<byte>)(resources.GetObject("GrdBytes.Bytes")));
            this.GrdBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdBytes.Location = new System.Drawing.Point(0, 0);
            this.GrdBytes.Name = "GrdBytes";
            this.GrdBytes.Size = new System.Drawing.Size(284, 262);
            this.GrdBytes.TabIndex = 0;
            // 
            // BytesViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.GrdBytes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "BytesViewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BytesViewWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private BytesView GrdBytes;
    }
}