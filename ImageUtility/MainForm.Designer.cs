namespace ImageUtility
{
    partial class MainForm
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
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_ShowImgMode = new System.Windows.Forms.ToolStripMenuItem();
            this.checkImageFileValidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractVideoFileToImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.basicToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(661, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuStrip_OpenImgFile
            // 
            this.MenuStrip_OpenImgFile.Name = "MenuStrip_OpenImgFile";
            this.MenuStrip_OpenImgFile.ShortcutKeyDisplayString = "(Ctrl+O)";
            this.MenuStrip_OpenImgFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuStrip_OpenImgFile.Size = new System.Drawing.Size(203, 22);
            this.MenuStrip_OpenImgFile.Text = "Open";
            this.MenuStrip_OpenImgFile.ToolTipText = "Open a image file";
            this.MenuStrip_OpenImgFile.Click += new System.EventHandler(this.MenuStrip_OpenImgFile_Click);
            // 
            // MenuStrip_SaveImgFile
            // 
            this.MenuStrip_SaveImgFile.Name = "MenuStrip_SaveImgFile";
            this.MenuStrip_SaveImgFile.ShortcutKeyDisplayString = "(Ctrl+S)";
            this.MenuStrip_SaveImgFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuStrip_SaveImgFile.Size = new System.Drawing.Size(203, 22);
            this.MenuStrip_SaveImgFile.Text = "Save";
            this.MenuStrip_SaveImgFile.ToolTipText = "Save a image file";
            this.MenuStrip_SaveImgFile.Click += new System.EventHandler(this.MenuStrip_SaveImgFile_Click);
            // 
            // MenuStrip_SaveAsImgFile
            // 
            this.MenuStrip_SaveAsImgFile.Name = "MenuStrip_SaveAsImgFile";
            this.MenuStrip_SaveAsImgFile.ShortcutKeyDisplayString = "(Ctrl+Shift+S)";
            this.MenuStrip_SaveAsImgFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuStrip_SaveAsImgFile.Size = new System.Drawing.Size(203, 22);
            this.MenuStrip_SaveAsImgFile.Text = "Save as";
            this.MenuStrip_SaveAsImgFile.ToolTipText = "Save a image file";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_ShowImgMode,
            this.checkImageFileValidToolStripMenuItem,
            this.extractVideoFileToImageToolStripMenuItem});
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.basicToolStripMenuItem.Text = "Basic";
            // 
            // MenuStrip_ShowImgMode
            // 
            this.MenuStrip_ShowImgMode.CheckOnClick = true;
            this.MenuStrip_ShowImgMode.Name = "MenuStrip_ShowImgMode";
            this.MenuStrip_ShowImgMode.Size = new System.Drawing.Size(227, 22);
            this.MenuStrip_ShowImgMode.Text = "Show Image Mode";
            // 
            // checkImageFileValidToolStripMenuItem
            // 
            this.checkImageFileValidToolStripMenuItem.Name = "checkImageFileValidToolStripMenuItem";
            this.checkImageFileValidToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.checkImageFileValidToolStripMenuItem.Text = "Check Image File is Valid";
            // 
            // extractVideoFileToImageToolStripMenuItem
            // 
            this.extractVideoFileToImageToolStripMenuItem.Name = "extractVideoFileToImageToolStripMenuItem";
            this.extractVideoFileToImageToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.extractVideoFileToImageToolStripMenuItem.Text = "Extract Video File to Image";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 269);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
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
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_ShowImgMode;
        private System.Windows.Forms.ToolStripMenuItem checkImageFileValidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractVideoFileToImageToolStripMenuItem;
    }
}

