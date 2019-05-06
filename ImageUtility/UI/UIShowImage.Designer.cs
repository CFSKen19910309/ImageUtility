namespace ImageUtility.UI
{
    partial class UIShowImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIShowImage));
            this.ZoomPanBox = new ZoomPanBox.ZoomPanBox();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripBtn_OepnImg = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtn_SaveImg = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZoomPanBox
            // 
            this.ZoomPanBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZoomPanBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ZoomPanBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomPanBox.Location = new System.Drawing.Point(0, 0);
            this.ZoomPanBox.Name = "ZoomPanBox";
            this.ZoomPanBox.Size = new System.Drawing.Size(1031, 489);
            this.ZoomPanBox.TabIndex = 0;
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBtn_OepnImg,
            this.ToolStripBtn_SaveImg});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1031, 26);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripBtn_OepnImg
            // 
            this.ToolStripBtn_OepnImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripBtn_OepnImg.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtn_OepnImg.Image")));
            this.ToolStripBtn_OepnImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtn_OepnImg.Name = "ToolStripBtn_OepnImg";
            this.ToolStripBtn_OepnImg.Size = new System.Drawing.Size(99, 23);
            this.ToolStripBtn_OepnImg.Text = "Open Image";
            this.ToolStripBtn_OepnImg.Click += new System.EventHandler(this.ToolStripBtn_OepnImg_Click);
            // 
            // ToolStripBtn_SaveImg
            // 
            this.ToolStripBtn_SaveImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripBtn_SaveImg.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtn_SaveImg.Image")));
            this.ToolStripBtn_SaveImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtn_SaveImg.Name = "ToolStripBtn_SaveImg";
            this.ToolStripBtn_SaveImg.Size = new System.Drawing.Size(94, 23);
            this.ToolStripBtn_SaveImg.Text = "Save Image";
            // 
            // UIShowImage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 489);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.ZoomPanBox);
            this.DoubleBuffered = true;
            this.Name = "UIShowImage";
            this.Text = "UIShowImage";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZoomPanBox.ZoomPanBox ZoomPanBox;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ToolStripBtn_OepnImg;
        private System.Windows.Forms.ToolStripButton ToolStripBtn_SaveImg;
    }
}