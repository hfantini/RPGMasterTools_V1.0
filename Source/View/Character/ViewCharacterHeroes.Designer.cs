namespace RPGMasterTools.Source.View.Character
{
    partial class ViewCharacterHeroes
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
            this.tLayoutHeroes = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeroesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeroesContent = new System.Windows.Forms.Panel();
            this.tLayoutHeroes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLayoutHeroes
            // 
            this.tLayoutHeroes.ColumnCount = 1;
            this.tLayoutHeroes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutHeroes.Controls.Add(this.pnlHeroesContent, 0, 2);
            this.tLayoutHeroes.Controls.Add(this.lblHeroesTitle, 0, 0);
            this.tLayoutHeroes.Controls.Add(this.panel1, 0, 1);
            this.tLayoutHeroes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutHeroes.Location = new System.Drawing.Point(0, 0);
            this.tLayoutHeroes.Margin = new System.Windows.Forms.Padding(0);
            this.tLayoutHeroes.Name = "tLayoutHeroes";
            this.tLayoutHeroes.RowCount = 3;
            this.tLayoutHeroes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tLayoutHeroes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tLayoutHeroes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutHeroes.Size = new System.Drawing.Size(324, 506);
            this.tLayoutHeroes.TabIndex = 1;
            // 
            // lblHeroesTitle
            // 
            this.lblHeroesTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblHeroesTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeroesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeroesTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeroesTitle.Name = "lblHeroesTitle";
            this.lblHeroesTitle.Size = new System.Drawing.Size(324, 32);
            this.lblHeroesTitle.TabIndex = 2;
            this.lblHeroesTitle.Text = "CHARACTER.HEROES.TITLE";
            this.lblHeroesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 32);
            this.panel1.TabIndex = 3;
            // 
            // pnlHeroesContent
            // 
            this.pnlHeroesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeroesContent.Location = new System.Drawing.Point(0, 69);
            this.pnlHeroesContent.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlHeroesContent.Name = "pnlHeroesContent";
            this.pnlHeroesContent.Size = new System.Drawing.Size(324, 437);
            this.pnlHeroesContent.TabIndex = 4;
            // 
            // ViewCharacterHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLayoutHeroes);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewCharacterHeroes";
            this.Size = new System.Drawing.Size(324, 506);
            this.tLayoutHeroes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLayoutHeroes;
        private System.Windows.Forms.Label lblHeroesTitle;
        private System.Windows.Forms.Panel pnlHeroesContent;
        private System.Windows.Forms.Panel panel1;
    }
}
