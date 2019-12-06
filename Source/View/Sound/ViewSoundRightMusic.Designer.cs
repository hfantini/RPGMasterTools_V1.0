namespace RPGMasterTools.Source.View.Sound
{
    partial class ViewSoundRightMusic
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tblSoundRightMusic = new System.Windows.Forms.TableLayoutPanel();
            this.fLayItems = new System.Windows.Forms.FlowLayoutPanel();
            this.tblSoundRightMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 454);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(422, 200);
            this.pnlBottom.TabIndex = 1;
            // 
            // tblSoundRightMusic
            // 
            this.tblSoundRightMusic.ColumnCount = 1;
            this.tblSoundRightMusic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSoundRightMusic.Controls.Add(this.pnlBottom, 0, 1);
            this.tblSoundRightMusic.Controls.Add(this.fLayItems, 0, 0);
            this.tblSoundRightMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSoundRightMusic.Location = new System.Drawing.Point(0, 0);
            this.tblSoundRightMusic.Margin = new System.Windows.Forms.Padding(0);
            this.tblSoundRightMusic.Name = "tblSoundRightMusic";
            this.tblSoundRightMusic.RowCount = 2;
            this.tblSoundRightMusic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSoundRightMusic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblSoundRightMusic.Size = new System.Drawing.Size(422, 654);
            this.tblSoundRightMusic.TabIndex = 0;
            // 
            // fLayItems
            // 
            this.fLayItems.AutoScroll = true;
            this.fLayItems.BackColor = System.Drawing.Color.White;
            this.fLayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLayItems.Location = new System.Drawing.Point(0, 0);
            this.fLayItems.Margin = new System.Windows.Forms.Padding(0);
            this.fLayItems.Name = "fLayItems";
            this.fLayItems.Size = new System.Drawing.Size(422, 454);
            this.fLayItems.TabIndex = 2;
            this.fLayItems.WrapContents = false;
            // 
            // ViewSoundRightMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblSoundRightMusic);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewSoundRightMusic";
            this.Size = new System.Drawing.Size(422, 654);
            this.tblSoundRightMusic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TableLayoutPanel tblSoundRightMusic;
        private System.Windows.Forms.FlowLayoutPanel fLayItems;
    }
}
