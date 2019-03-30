namespace ImageUtility
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_OpenImgFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_SaveImgFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_SaveAsImgFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(991, 32);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_OpenImgFile,
            this.MenuStrip_SaveImgFile,
            this.MenuStrip_SaveAsImgFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuStrip_OpenImgFile
            // 
            this.MenuStrip_OpenImgFile.Name = "MenuStrip_OpenImgFile";
            this.MenuStrip_OpenImgFile.ShortcutKeyDisplayString = "(Ctrl+O)";
            this.MenuStrip_OpenImgFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuStrip_OpenImgFile.Size = new System.Drawing.Size(282, 30);
            this.MenuStrip_OpenImgFile.Text = "Open";
            this.MenuStrip_OpenImgFile.ToolTipText = "Open a image file";
            // 
            // MenuStrip_SaveImgFile
            // 
            this.MenuStrip_SaveImgFile.Name = "MenuStrip_SaveImgFile";
            this.MenuStrip_SaveImgFile.ShortcutKeyDisplayString = "(Ctrl+S)";
            this.MenuStrip_SaveImgFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuStrip_SaveImgFile.Size = new System.Drawing.Size(282, 30);
            this.MenuStrip_SaveImgFile.Text = "Save";
            this.MenuStrip_SaveImgFile.ToolTipText = "Save a image file";
            // 
            // MenuStrip_SaveAsImgFile
            // 
            this.MenuStrip_SaveAsImgFile.Name = "MenuStrip_SaveAsImgFile";
            this.MenuStrip_SaveAsImgFile.ShortcutKeyDisplayString = "(Ctrl+Shift+S)";
            this.MenuStrip_SaveAsImgFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuStrip_SaveAsImgFile.Size = new System.Drawing.Size(282, 30);
            this.MenuStrip_SaveAsImgFile.Text = "Save as";
            this.MenuStrip_SaveAsImgFile.ToolTipText = "Save a image file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 403);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_OpenImgFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_SaveImgFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_SaveAsImgFile;
    }
}

