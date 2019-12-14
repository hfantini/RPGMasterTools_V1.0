namespace RPGMasterTools.Source.View.Character
{
    partial class ViewCharacter
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
            this.tLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tStripSound = new System.Windows.Forms.ToolStrip();
            this.btnSavePreset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeroes = new System.Windows.Forms.Panel();
            this.pnlEnemies = new System.Windows.Forms.Panel();
            this.tLayoutMain.SuspendLayout();
            this.tStripSound.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLayoutMain
            // 
            this.tLayoutMain.ColumnCount = 1;
            this.tLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutMain.Controls.Add(this.tStripSound, 0, 0);
            this.tLayoutMain.Controls.Add(this.pnlMain, 0, 1);
            this.tLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tLayoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.tLayoutMain.Name = "tLayoutMain";
            this.tLayoutMain.RowCount = 2;
            this.tLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutMain.Size = new System.Drawing.Size(828, 439);
            this.tLayoutMain.TabIndex = 0;
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
            this.tStripSound.Size = new System.Drawing.Size(828, 32);
            this.tStripSound.TabIndex = 3;
            this.tStripSound.Text = "toolStrip1";
            // 
            // btnSavePreset
            // 
            this.btnSavePreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSavePreset.Image = global::RPGMasterTools.Properties.Resources.ico_save;
            this.btnSavePreset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePreset.Name = "btnSavePreset";
            this.btnSavePreset.Size = new System.Drawing.Size(28, 29);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMain.Location = new System.Drawing.Point(3, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(822, 401);
            this.pnlMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlEnemies, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlHeroes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlHeroes
            // 
            this.pnlHeroes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlHeroes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeroes.Location = new System.Drawing.Point(0, 0);
            this.pnlHeroes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeroes.Name = "pnlHeroes";
            this.pnlHeroes.Padding = new System.Windows.Forms.Padding(5);
            this.pnlHeroes.Size = new System.Drawing.Size(409, 397);
            this.pnlHeroes.TabIndex = 0;
            // 
            // pnlEnemies
            // 
            this.pnlEnemies.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlEnemies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnemies.Location = new System.Drawing.Point(409, 0);
            this.pnlEnemies.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEnemies.Name = "pnlEnemies";
            this.pnlEnemies.Padding = new System.Windows.Forms.Padding(5);
            this.pnlEnemies.Size = new System.Drawing.Size(409, 397);
            this.pnlEnemies.TabIndex = 1;
            // 
            // ViewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLayoutMain);
            this.Name = "ViewCharacter";
            this.Size = new System.Drawing.Size(828, 439);
            this.tLayoutMain.ResumeLayout(false);
            this.tLayoutMain.PerformLayout();
            this.tStripSound.ResumeLayout(false);
            this.tStripSound.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLayoutMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStrip tStripSound;
        private System.Windows.Forms.ToolStripButton btnSavePreset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlHeroes;
        private System.Windows.Forms.Panel pnlEnemies;
    }
}
