namespace RPGMasterTools.Source.View.Character
{
    partial class ViewCharacterEnemies
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
            this.pnlEnemiesContent = new System.Windows.Forms.Panel();
            this.lblEnemiesTitle = new System.Windows.Forms.Label();
            this.pnlEnemiesToolbar = new System.Windows.Forms.Panel();
            this.tLayoutHeroes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLayoutHeroes
            // 
            this.tLayoutHeroes.ColumnCount = 1;
            this.tLayoutHeroes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutHeroes.Controls.Add(this.pnlEnemiesContent, 0, 2);
            this.tLayoutHeroes.Controls.Add(this.lblEnemiesTitle, 0, 0);
            this.tLayoutHeroes.Controls.Add(this.pnlEnemiesToolbar, 0, 1);
            this.tLayoutHeroes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutHeroes.Location = new System.Drawing.Point(0, 0);
            this.tLayoutHeroes.Margin = new System.Windows.Forms.Padding(0);
            this.tLayoutHeroes.Name = "tLayoutHeroes";
            this.tLayoutHeroes.RowCount = 3;
            this.tLayoutHeroes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tLayoutHeroes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tLayoutHeroes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutHeroes.Size = new System.Drawing.Size(682, 770);
            this.tLayoutHeroes.TabIndex = 2;
            // 
            // pnlEnemiesContent
            // 
            this.pnlEnemiesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnemiesContent.Location = new System.Drawing.Point(0, 106);
            this.pnlEnemiesContent.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlEnemiesContent.Name = "pnlEnemiesContent";
            this.pnlEnemiesContent.Size = new System.Drawing.Size(682, 664);
            this.pnlEnemiesContent.TabIndex = 4;
            // 
            // lblEnemiesTitle
            // 
            this.lblEnemiesTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEnemiesTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnemiesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemiesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblEnemiesTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblEnemiesTitle.Name = "lblEnemiesTitle";
            this.lblEnemiesTitle.Size = new System.Drawing.Size(682, 49);
            this.lblEnemiesTitle.TabIndex = 2;
            this.lblEnemiesTitle.Text = "CHARACTER.ENEMIES.TITLE";
            this.lblEnemiesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEnemiesToolbar
            // 
            this.pnlEnemiesToolbar.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlEnemiesToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnemiesToolbar.Location = new System.Drawing.Point(0, 49);
            this.pnlEnemiesToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEnemiesToolbar.Name = "pnlEnemiesToolbar";
            this.pnlEnemiesToolbar.Size = new System.Drawing.Size(682, 49);
            this.pnlEnemiesToolbar.TabIndex = 3;
            // 
            // ViewCharacterEnemies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLayoutHeroes);
            this.Name = "ViewCharacterEnemies";
            this.Size = new System.Drawing.Size(682, 770);
            this.tLayoutHeroes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLayoutHeroes;
        private System.Windows.Forms.Panel pnlEnemiesContent;
        private System.Windows.Forms.Label lblEnemiesTitle;
        private System.Windows.Forms.Panel pnlEnemiesToolbar;
    }
}
