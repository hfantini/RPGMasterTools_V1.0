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
            this.tblSoundLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSoundRight = new System.Windows.Forms.Panel();
            this.pnlSoundLeft = new System.Windows.Forms.Panel();
            this.tblSoundLayout.SuspendLayout();
            this.SuspendLayout();
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
            this.tblSoundLayout.Location = new System.Drawing.Point(0, 0);
            this.tblSoundLayout.Name = "tblSoundLayout";
            this.tblSoundLayout.RowCount = 1;
            this.tblSoundLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.22052F));
            this.tblSoundLayout.Size = new System.Drawing.Size(1387, 653);
            this.tblSoundLayout.TabIndex = 0;
            // 
            // pnlSoundRight
            // 
            this.pnlSoundRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSoundRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSoundRight.Location = new System.Drawing.Point(360, 3);
            this.pnlSoundRight.Name = "pnlSoundRight";
            this.pnlSoundRight.Size = new System.Drawing.Size(1024, 647);
            this.pnlSoundRight.TabIndex = 1;
            // 
            // pnlSoundLeft
            // 
            this.pnlSoundLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSoundLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlSoundLeft.Name = "pnlSoundLeft";
            this.pnlSoundLeft.Size = new System.Drawing.Size(351, 647);
            this.pnlSoundLeft.TabIndex = 2;
            // 
            // ViewSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblSoundLayout);
            this.Name = "ViewSound";
            this.Size = new System.Drawing.Size(1387, 653);
            this.Load += new System.EventHandler(this.ViewSound_Load);
            this.tblSoundLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSoundLayout;
        private System.Windows.Forms.Panel pnlSoundRight;
        private System.Windows.Forms.Panel pnlSoundLeft;
    }
}
