namespace RPGMasterTools.Source.View.Combat
{
    partial class ViewCombatPanelCharacter
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDamage = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnCharEffect = new System.Windows.Forms.Button();
            this.btnDeath = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pBoxInititive = new System.Windows.Forms.PictureBox();
            this.txtInitiative = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLifeMax = new System.Windows.Forms.TextBox();
            this.txtLife = new System.Windows.Forms.TextBox();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.pBoxIndicator = new System.Windows.Forms.PictureBox();
            this.tblMain.SuspendLayout();
            this.tblLayout.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInititive)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlIndicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblLayout, 1, 0);
            this.tblMain.Controls.Add(this.pnlIndicator, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(718, 78);
            this.tblMain.TabIndex = 0;
            // 
            // tblLayout
            // 
            this.tblLayout.BackColor = System.Drawing.SystemColors.Control;
            this.tblLayout.ColumnCount = 5;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayout.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tblLayout.Controls.Add(this.panel1, 0, 0);
            this.tblLayout.Controls.Add(this.panel2, 4, 0);
            this.tblLayout.Controls.Add(this.panel3, 2, 0);
            this.tblLayout.Controls.Add(this.panel4, 3, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(20, 3);
            this.tblLayout.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Size = new System.Drawing.Size(695, 72);
            this.tblLayout.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStatus, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(80, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(295, 72);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(295, 43);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "CHAR_NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 46);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(295, 26);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "CHAR_STATE";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pBoxIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(80, 72);
            this.panel1.TabIndex = 6;
            // 
            // pBoxIcon
            // 
            this.pBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxIcon.Image = global::RPGMasterTools.Properties.Resources.ico_class_none;
            this.pBoxIcon.Location = new System.Drawing.Point(10, 10);
            this.pBoxIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pBoxIcon.Name = "pBoxIcon";
            this.pBoxIcon.Size = new System.Drawing.Size(56, 48);
            this.pBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxIcon.TabIndex = 1;
            this.pBoxIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tblButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(615, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 72);
            this.panel2.TabIndex = 7;
            // 
            // tblButton
            // 
            this.tblButton.BackColor = System.Drawing.SystemColors.Control;
            this.tblButton.ColumnCount = 2;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Controls.Add(this.btnDamage, 0, 0);
            this.tblButton.Controls.Add(this.btnHeal, 1, 0);
            this.tblButton.Controls.Add(this.btnCharEffect, 0, 1);
            this.tblButton.Controls.Add(this.btnDeath, 1, 1);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(0, 0);
            this.tblButton.Margin = new System.Windows.Forms.Padding(0);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 2;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Size = new System.Drawing.Size(76, 68);
            this.tblButton.TabIndex = 6;
            // 
            // btnDamage
            // 
            this.btnDamage.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_damage_2;
            this.btnDamage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDamage.Location = new System.Drawing.Point(3, 2);
            this.btnDamage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(32, 30);
            this.btnDamage.TabIndex = 0;
            this.btnDamage.UseVisualStyleBackColor = true;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_heal_2;
            this.btnHeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHeal.Location = new System.Drawing.Point(41, 2);
            this.btnHeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(32, 30);
            this.btnHeal.TabIndex = 1;
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnCharEffect
            // 
            this.btnCharEffect.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_char_state;
            this.btnCharEffect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCharEffect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCharEffect.Location = new System.Drawing.Point(3, 36);
            this.btnCharEffect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCharEffect.Name = "btnCharEffect";
            this.btnCharEffect.Size = new System.Drawing.Size(32, 30);
            this.btnCharEffect.TabIndex = 2;
            this.btnCharEffect.UseVisualStyleBackColor = true;
            // 
            // btnDeath
            // 
            this.btnDeath.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_skull;
            this.btnDeath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeath.Location = new System.Drawing.Point(41, 36);
            this.btnDeath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeath.Name = "btnDeath";
            this.btnDeath.Size = new System.Drawing.Size(32, 30);
            this.btnDeath.TabIndex = 3;
            this.btnDeath.UseVisualStyleBackColor = true;
            this.btnDeath.Click += new System.EventHandler(this.btnDeath_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(375, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 72);
            this.panel3.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pBoxInititive, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtInitiative, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(76, 68);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pBoxInititive
            // 
            this.pBoxInititive.BackColor = System.Drawing.SystemColors.Control;
            this.pBoxInititive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxInititive.Image = global::RPGMasterTools.Properties.Resources.ico_d20;
            this.pBoxInititive.Location = new System.Drawing.Point(0, 3);
            this.pBoxInititive.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pBoxInititive.Name = "pBoxInititive";
            this.pBoxInititive.Size = new System.Drawing.Size(76, 23);
            this.pBoxInititive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxInititive.TabIndex = 0;
            this.pBoxInititive.TabStop = false;
            // 
            // txtInitiative
            // 
            this.txtInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInitiative.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInitiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitiative.Location = new System.Drawing.Point(3, 32);
            this.txtInitiative.MaxLength = 2;
            this.txtInitiative.Name = "txtInitiative";
            this.txtInitiative.Size = new System.Drawing.Size(70, 32);
            this.txtInitiative.TabIndex = 1;
            this.txtInitiative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInitiative.TextChanged += new System.EventHandler(this.txtInitiative_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(455, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 72);
            this.panel4.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(156, 68);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RPGMasterTools.Properties.Resources.ico_life;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtLifeMax, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLife, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(156, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtLifeMax
            // 
            this.txtLifeMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLifeMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLifeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLifeMax.Location = new System.Drawing.Point(81, 3);
            this.txtLifeMax.MaxLength = 3;
            this.txtLifeMax.Name = "txtLifeMax";
            this.txtLifeMax.Size = new System.Drawing.Size(72, 32);
            this.txtLifeMax.TabIndex = 3;
            this.txtLifeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLife
            // 
            this.txtLife.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLife.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLife.Location = new System.Drawing.Point(3, 3);
            this.txtLife.MaxLength = 3;
            this.txtLife.Name = "txtLife";
            this.txtLife.Size = new System.Drawing.Size(72, 32);
            this.txtLife.TabIndex = 2;
            this.txtLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlIndicator
            // 
            this.pnlIndicator.Controls.Add(this.pBoxIndicator);
            this.pnlIndicator.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIndicator.Location = new System.Drawing.Point(5, 5);
            this.pnlIndicator.Margin = new System.Windows.Forms.Padding(5);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(10, 68);
            this.pnlIndicator.TabIndex = 0;
            // 
            // pBoxIndicator
            // 
            this.pBoxIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxIndicator.Image = global::RPGMasterTools.Properties.Resources.ico_stop;
            this.pBoxIndicator.Location = new System.Drawing.Point(0, 0);
            this.pBoxIndicator.Margin = new System.Windows.Forms.Padding(0);
            this.pBoxIndicator.Name = "pBoxIndicator";
            this.pBoxIndicator.Size = new System.Drawing.Size(10, 68);
            this.pBoxIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxIndicator.TabIndex = 1;
            this.pBoxIndicator.TabStop = false;
            // 
            // ViewCombatPanelCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.Name = "ViewCombatPanelCharacter";
            this.Size = new System.Drawing.Size(718, 78);
            this.Load += new System.EventHandler(this.ViewCombatPanelCharacter_Load);
            this.tblMain.ResumeLayout(false);
            this.tblLayout.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tblButton.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInititive)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlIndicator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlIndicator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnDamage;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnCharEffect;
        private System.Windows.Forms.Button btnDeath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pBoxInititive;
        private System.Windows.Forms.TextBox txtInitiative;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBoxIndicator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtLifeMax;
        private System.Windows.Forms.TextBox txtLife;
    }
}
