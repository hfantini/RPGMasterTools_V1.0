namespace RPGMasterTools.Source.View.Sound
{
    partial class ViewSoundRightMusicPlate
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
            this.pBoxActionDelete = new System.Windows.Forms.PictureBox();
            this.lblMscName = new System.Windows.Forms.Label();
            this.pBoxImageStatus = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxActionDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImageStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pBoxActionDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMscName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBoxImageStatus, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pBoxActionDelete
            // 
            this.pBoxActionDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxActionDelete.Image = global::RPGMasterTools.Properties.Resources.ico_trash;
            this.pBoxActionDelete.Location = new System.Drawing.Point(529, 15);
            this.pBoxActionDelete.Margin = new System.Windows.Forms.Padding(15);
            this.pBoxActionDelete.Name = "pBoxActionDelete";
            this.pBoxActionDelete.Size = new System.Drawing.Size(20, 20);
            this.pBoxActionDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxActionDelete.TabIndex = 2;
            this.pBoxActionDelete.TabStop = false;
            // 
            // lblMscName
            // 
            this.lblMscName.AutoSize = true;
            this.lblMscName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMscName.Location = new System.Drawing.Point(53, 0);
            this.lblMscName.Name = "lblMscName";
            this.lblMscName.Size = new System.Drawing.Size(458, 50);
            this.lblMscName.TabIndex = 0;
            this.lblMscName.Text = "MUSIC_NAME";
            this.lblMscName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMscName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMscName_MouseDoubleClick);
            // 
            // pBoxImageStatus
            // 
            this.pBoxImageStatus.Image = global::RPGMasterTools.Properties.Resources.ico_stop;
            this.pBoxImageStatus.Location = new System.Drawing.Point(15, 15);
            this.pBoxImageStatus.Margin = new System.Windows.Forms.Padding(15);
            this.pBoxImageStatus.Name = "pBoxImageStatus";
            this.pBoxImageStatus.Size = new System.Drawing.Size(20, 20);
            this.pBoxImageStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxImageStatus.TabIndex = 1;
            this.pBoxImageStatus.TabStop = false;
            // 
            // ViewSoundRightMusicPlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewSoundRightMusicPlate";
            this.Size = new System.Drawing.Size(564, 50);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewSoundRightMusicPlate_MouseDoubleClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxActionDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImageStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMscName;
        private System.Windows.Forms.PictureBox pBoxImageStatus;
        private System.Windows.Forms.PictureBox pBoxActionDelete;
    }
}
