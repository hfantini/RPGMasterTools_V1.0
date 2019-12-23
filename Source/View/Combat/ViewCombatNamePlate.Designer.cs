namespace RPGMasterTools.Source.View.Combat
{
    partial class ViewCombatNamePlate
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
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pBoxIcon = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 2;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.pBoxIcon, 0, 0);
            this.tblLayout.Controls.Add(this.lblName, 1, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Size = new System.Drawing.Size(519, 85);
            this.tblLayout.TabIndex = 0;
            // 
            // pBoxIcon
            // 
            this.pBoxIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxIcon.Image = global::RPGMasterTools.Properties.Resources.ico_combat;
            this.pBoxIcon.Location = new System.Drawing.Point(10, 10);
            this.pBoxIcon.Margin = new System.Windows.Forms.Padding(10);
            this.pBoxIcon.Name = "pBoxIcon";
            this.pBoxIcon.Size = new System.Drawing.Size(65, 65);
            this.pBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxIcon.TabIndex = 0;
            this.pBoxIcon.TabStop = false;
            this.pBoxIcon.Click += new System.EventHandler(this.pBoxIcon_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(88, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(428, 85);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "COMBAT_NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // ViewCombatNamePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.tblLayout);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Name = "ViewCombatNamePlate";
            this.Size = new System.Drawing.Size(519, 85);
            this.Click += new System.EventHandler(this.ViewCombatNamePlate_Click);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.PictureBox pBoxIcon;
        private System.Windows.Forms.Label lblName;
    }
}
