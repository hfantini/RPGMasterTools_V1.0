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
            this.lblEnemiesTitle = new System.Windows.Forms.Label();
            this.pnlEnemiesToolbar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblHeroesToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fLayoutEnemies = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tLayoutHeroes.SuspendLayout();
            this.pnlEnemiesToolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tblHeroesToolbar.SuspendLayout();
            this.fLayoutEnemies.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLayoutHeroes
            // 
            this.tLayoutHeroes.ColumnCount = 1;
            this.tLayoutHeroes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutHeroes.Controls.Add(this.fLayoutEnemies, 0, 2);
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
            this.tLayoutHeroes.Size = new System.Drawing.Size(440, 770);
            this.tLayoutHeroes.TabIndex = 2;
            // 
            // lblEnemiesTitle
            // 
            this.lblEnemiesTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEnemiesTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnemiesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemiesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblEnemiesTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblEnemiesTitle.Name = "lblEnemiesTitle";
            this.lblEnemiesTitle.Size = new System.Drawing.Size(440, 49);
            this.lblEnemiesTitle.TabIndex = 2;
            this.lblEnemiesTitle.Text = "CHARACTER.ENEMIES.TITLE";
            this.lblEnemiesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEnemiesToolbar
            // 
            this.pnlEnemiesToolbar.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlEnemiesToolbar.Controls.Add(this.panel1);
            this.pnlEnemiesToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnemiesToolbar.Location = new System.Drawing.Point(0, 49);
            this.pnlEnemiesToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEnemiesToolbar.Name = "pnlEnemiesToolbar";
            this.pnlEnemiesToolbar.Size = new System.Drawing.Size(440, 49);
            this.pnlEnemiesToolbar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.tblHeroesToolbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(440, 49);
            this.panel1.TabIndex = 4;
            // 
            // tblHeroesToolbar
            // 
            this.tblHeroesToolbar.ColumnCount = 2;
            this.tblHeroesToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblHeroesToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeroesToolbar.Controls.Add(this.btnAdd, 0, 0);
            this.tblHeroesToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeroesToolbar.Location = new System.Drawing.Point(5, 5);
            this.tblHeroesToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.tblHeroesToolbar.Name = "tblHeroesToolbar";
            this.tblHeroesToolbar.RowCount = 1;
            this.tblHeroesToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeroesToolbar.Size = new System.Drawing.Size(430, 39);
            this.tblHeroesToolbar.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fLayoutEnemies
            // 
            this.fLayoutEnemies.BackColor = System.Drawing.Color.White;
            this.fLayoutEnemies.Controls.Add(this.flowLayoutPanel1);
            this.fLayoutEnemies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayoutEnemies.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLayoutEnemies.Location = new System.Drawing.Point(0, 98);
            this.fLayoutEnemies.Margin = new System.Windows.Forms.Padding(0);
            this.fLayoutEnemies.Name = "fLayoutEnemies";
            this.fLayoutEnemies.Size = new System.Drawing.Size(440, 672);
            this.fLayoutEnemies.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ViewCharacterEnemies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLayoutHeroes);
            this.Name = "ViewCharacterEnemies";
            this.Size = new System.Drawing.Size(440, 770);
            this.Load += new System.EventHandler(this.ViewCharacterEnemies_Load);
            this.tLayoutHeroes.ResumeLayout(false);
            this.pnlEnemiesToolbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tblHeroesToolbar.ResumeLayout(false);
            this.fLayoutEnemies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLayoutHeroes;
        private System.Windows.Forms.Label lblEnemiesTitle;
        private System.Windows.Forms.Panel pnlEnemiesToolbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblHeroesToolbar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel fLayoutEnemies;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
