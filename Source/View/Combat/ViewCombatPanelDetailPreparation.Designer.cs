namespace RPGMasterTools.Source.View.Combat
{
    partial class ViewCombatPanelDetailPreparation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInitiativeRandomEnemies = new System.Windows.Forms.Button();
            this.btnInitiativeRandomPlayers = new System.Windows.Forms.Button();
            this.btnInitiativeRandomAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1242, 733);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTIONS";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(108, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 331);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnInitiativeRandomEnemies, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnInitiativeRandomPlayers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnInitiativeRandomAll, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1016, 331);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnInitiativeRandomEnemies
            // 
            this.btnInitiativeRandomEnemies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInitiativeRandomEnemies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitiativeRandomEnemies.Location = new System.Drawing.Point(3, 163);
            this.btnInitiativeRandomEnemies.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnInitiativeRandomEnemies.Name = "btnInitiativeRandomEnemies";
            this.btnInitiativeRandomEnemies.Size = new System.Drawing.Size(1010, 67);
            this.btnInitiativeRandomEnemies.TabIndex = 2;
            this.btnInitiativeRandomEnemies.Text = "RANDOM_ENEMIES";
            this.btnInitiativeRandomEnemies.UseVisualStyleBackColor = true;
            this.btnInitiativeRandomEnemies.Click += new System.EventHandler(this.btnInitiativeRandomEnemies_Click);
            // 
            // btnInitiativeRandomPlayers
            // 
            this.btnInitiativeRandomPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInitiativeRandomPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitiativeRandomPlayers.Location = new System.Drawing.Point(3, 83);
            this.btnInitiativeRandomPlayers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnInitiativeRandomPlayers.Name = "btnInitiativeRandomPlayers";
            this.btnInitiativeRandomPlayers.Size = new System.Drawing.Size(1010, 67);
            this.btnInitiativeRandomPlayers.TabIndex = 1;
            this.btnInitiativeRandomPlayers.Text = "RANDOM_PLAYERS";
            this.btnInitiativeRandomPlayers.UseVisualStyleBackColor = true;
            this.btnInitiativeRandomPlayers.Click += new System.EventHandler(this.btnInitiativeRandomPlayers_Click);
            // 
            // btnInitiativeRandomAll
            // 
            this.btnInitiativeRandomAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInitiativeRandomAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitiativeRandomAll.Location = new System.Drawing.Point(3, 3);
            this.btnInitiativeRandomAll.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnInitiativeRandomAll.Name = "btnInitiativeRandomAll";
            this.btnInitiativeRandomAll.Size = new System.Drawing.Size(1010, 67);
            this.btnInitiativeRandomAll.TabIndex = 0;
            this.btnInitiativeRandomAll.Text = "RANDOM_ALL";
            this.btnInitiativeRandomAll.UseVisualStyleBackColor = true;
            this.btnInitiativeRandomAll.Click += new System.EventHandler(this.btnInitiativeRandomAll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1242, 150);
            this.panel1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(20, 20);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1202, 110);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START BATTLE";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ViewCombatPanelDetailPreparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewCombatPanelDetailPreparation";
            this.Size = new System.Drawing.Size(1242, 733);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnInitiativeRandomAll;
        private System.Windows.Forms.Button btnInitiativeRandomEnemies;
        private System.Windows.Forms.Button btnInitiativeRandomPlayers;
        private System.Windows.Forms.Button btnStart;
    }
}
