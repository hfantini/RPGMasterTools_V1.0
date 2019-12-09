namespace RPGMasterTools.Source.View.Sound
{
    partial class ViewSoundRightAmbience
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
            this.tblAmbience = new System.Windows.Forms.TableLayoutPanel();
            this.fLayoutAmbience = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tblAmbience.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblAmbience
            // 
            this.tblAmbience.ColumnCount = 1;
            this.tblAmbience.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAmbience.Controls.Add(this.fLayoutAmbience, 0, 0);
            this.tblAmbience.Controls.Add(this.pnlBottom, 0, 1);
            this.tblAmbience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAmbience.Location = new System.Drawing.Point(0, 0);
            this.tblAmbience.Name = "tblAmbience";
            this.tblAmbience.RowCount = 2;
            this.tblAmbience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAmbience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblAmbience.Size = new System.Drawing.Size(453, 677);
            this.tblAmbience.TabIndex = 0;
            // 
            // fLayoutAmbience
            // 
            this.fLayoutAmbience.AutoScroll = true;
            this.fLayoutAmbience.BackColor = System.Drawing.Color.White;
            this.fLayoutAmbience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayoutAmbience.Location = new System.Drawing.Point(0, 5);
            this.fLayoutAmbience.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.fLayoutAmbience.Name = "fLayoutAmbience";
            this.fLayoutAmbience.Size = new System.Drawing.Size(453, 622);
            this.fLayoutAmbience.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Location = new System.Drawing.Point(0, 627);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(453, 50);
            this.pnlBottom.TabIndex = 2;
            // 
            // ViewSoundRightAmbience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblAmbience);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewSoundRightAmbience";
            this.Size = new System.Drawing.Size(453, 677);
            this.tblAmbience.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAmbience;
        private System.Windows.Forms.FlowLayoutPanel fLayoutAmbience;
        private System.Windows.Forms.Panel pnlBottom;
    }
}
