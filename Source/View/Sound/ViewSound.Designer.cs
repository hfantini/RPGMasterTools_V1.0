namespace RPGMasterTools.Source.View.Sound
{
    partial class ViewSound
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblSoundLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSoundRight = new System.Windows.Forms.Panel();
            this.pnlSoundLeft = new System.Windows.Forms.Panel();
            this.tStripSound = new System.Windows.Forms.ToolStrip();
            this.btnSavePreset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblSoundLayout.SuspendLayout();
            this.tStripSound.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tblSoundLayout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tStripSound, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1387, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tblSoundLayout
            // 
            this.tblSoundLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSoundLayout.AutoSize = true;
            this.tblSoundLayout.ColumnCount = 2;
            this.tblSoundLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74751F));
            this.tblSoundLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.25249F));
            this.tblSoundLayout.Controls.Add(this.pnlSoundRight, 1, 0);
            this.tblSoundLayout.Controls.Add(this.pnlSoundLeft, 0, 0);
            this.tblSoundLayout.Location = new System.Drawing.Point(0, 50);
            this.tblSoundLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblSoundLayout.Name = "tblSoundLayout";
            this.tblSoundLayout.RowCount = 1;
            this.tblSoundLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.22052F));
            this.tblSoundLayout.Size = new System.Drawing.Size(1387, 603);
            this.tblSoundLayout.TabIndex = 1;
            // 
            // pnlSoundRight
            // 
            this.pnlSoundRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSoundRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSoundRight.Location = new System.Drawing.Point(360, 3);
            this.pnlSoundRight.Name = "pnlSoundRight";
            this.pnlSoundRight.Size = new System.Drawing.Size(1024, 597);
            this.pnlSoundRight.TabIndex = 1;
            // 
            // pnlSoundLeft
            // 
            this.pnlSoundLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSoundLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlSoundLeft.Name = "pnlSoundLeft";
            this.pnlSoundLeft.Size = new System.Drawing.Size(351, 597);
            this.pnlSoundLeft.TabIndex = 2;
            // 
            // tStripSound
            // 
            this.tStripSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tStripSound.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tStripSound.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSavePreset,
            this.toolStripSeparator1});
            this.tStripSound.Location = new System.Drawing.Point(0, 0);
            this.tStripSound.Name = "tStripSound";
            this.tStripSound.Size = new System.Drawing.Size(1387, 50);
            this.tStripSound.TabIndex = 2;
            this.tStripSound.Text = "toolStrip1";
            // 
            // btnSavePreset
            // 
            this.btnSavePreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSavePreset.Image = global::RPGMasterTools.Properties.Resources.ico_save;
            this.btnSavePreset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePreset.Name = "btnSavePreset";
            this.btnSavePreset.Size = new System.Drawing.Size(28, 47);
            this.btnSavePreset.Click += new System.EventHandler(this.btnSavePreset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // ViewSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewSound";
            this.Size = new System.Drawing.Size(1387, 653);
            this.Load += new System.EventHandler(this.ViewSound_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblSoundLayout.ResumeLayout(false);
            this.tStripSound.ResumeLayout(false);
            this.tStripSound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblSoundLayout;
        private System.Windows.Forms.Panel pnlSoundRight;
        private System.Windows.Forms.Panel pnlSoundLeft;
        private System.Windows.Forms.ToolStrip tStripSound;
        private System.Windows.Forms.ToolStripButton btnSavePreset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
