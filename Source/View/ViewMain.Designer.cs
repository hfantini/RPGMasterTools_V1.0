namespace RPGMasterTools.Source.View
{
    partial class ViewMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mItemMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tpnlMain = new System.Windows.Forms.TabControl();
            this.tabSound = new System.Windows.Forms.TabPage();
            this.mnuMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tpnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemMain});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1253, 33);
            this.mnuMain.TabIndex = 0;
            // 
            // mItemMain
            // 
            this.mItemMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemExit});
            this.mItemMain.Name = "mItemMain";
            this.mItemMain.Size = new System.Drawing.Size(174, 29);
            this.mItemMain.Text = "MAIN.MENU.MAIN";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(234, 30);
            this.mnuItemExit.Text = "MAIN.MENU.EXIT";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.tpnlMain);
            this.pnlMain.Location = new System.Drawing.Point(0, 36);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1253, 583);
            this.pnlMain.TabIndex = 1;
            // 
            // tpnlMain
            // 
            this.tpnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpnlMain.Controls.Add(this.tabSound);
            this.tpnlMain.Location = new System.Drawing.Point(3, 3);
            this.tpnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.SelectedIndex = 0;
            this.tpnlMain.Size = new System.Drawing.Size(1250, 580);
            this.tpnlMain.TabIndex = 0;
            // 
            // tabSound
            // 
            this.tabSound.Location = new System.Drawing.Point(4, 29);
            this.tabSound.Margin = new System.Windows.Forms.Padding(0);
            this.tabSound.Name = "tabSound";
            this.tabSound.Size = new System.Drawing.Size(1242, 547);
            this.tabSound.TabIndex = 0;
            this.tabSound.Text = "MAIN.TAB.SOUND";
            this.tabSound.UseVisualStyleBackColor = true;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 617);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewMain";
            this.Text = "MAIN.TITLE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewMain_FormClosing);
            this.Load += new System.EventHandler(this.ViewMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tpnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mItemMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tpnlMain;
        private System.Windows.Forms.TabPage tabSound;
    }
}