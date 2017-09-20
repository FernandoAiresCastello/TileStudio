namespace TileStudio.CommonCtrl
{
    partial class DataBlockViewWindow
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
            this.GrdData = new TileStudio.CommonCtrl.DataBlockView();
            this.SuspendLayout();
            // 
            // GrdData
            // 
            this.GrdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdData.Location = new System.Drawing.Point(0, 0);
            this.GrdData.Name = "GrdData";
            this.GrdData.Size = new System.Drawing.Size(272, 267);
            this.GrdData.TabIndex = 0;
            // 
            // DataBlockViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 267);
            this.Controls.Add(this.GrdData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DataBlockViewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Block Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private DataBlockView GrdData;
    }
}