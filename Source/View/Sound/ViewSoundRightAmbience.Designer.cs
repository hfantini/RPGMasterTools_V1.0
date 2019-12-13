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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnMasterPlay = new System.Windows.Forms.Button();
            this.tBarMasterVolume = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.fLayoutAmbience = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFXSearch = new System.Windows.Forms.Button();
            this.verticalSeparator1 = new RPGMasterTools.Source.View.Component.VerticalSeparator();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.tblAmbience.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarMasterVolume)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblAmbience
            // 
            this.tblAmbience.ColumnCount = 1;
            this.tblAmbience.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAmbience.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblAmbience.Controls.Add(this.pnlBottom, 0, 1);
            this.tblAmbience.Controls.Add(this.pnlTopBar, 0, 0);
            this.tblAmbience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAmbience.Location = new System.Drawing.Point(0, 0);
            this.tblAmbience.Name = "tblAmbience";
            this.tblAmbience.RowCount = 3;
            this.tblAmbience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblAmbience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAmbience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblAmbience.Size = new System.Drawing.Size(453, 677);
            this.tblAmbience.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPause, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMasterPlay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBarMasterVolume, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 627);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 50);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(103, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 44);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause.Location = new System.Drawing.Point(53, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(44, 44);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnMasterPlay
            // 
            this.btnMasterPlay.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_play;
            this.btnMasterPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMasterPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMasterPlay.Location = new System.Drawing.Point(3, 3);
            this.btnMasterPlay.Name = "btnMasterPlay";
            this.btnMasterPlay.Size = new System.Drawing.Size(44, 44);
            this.btnMasterPlay.TabIndex = 0;
            this.btnMasterPlay.UseVisualStyleBackColor = true;
            // 
            // tBarMasterVolume
            // 
            this.tBarMasterVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBarMasterVolume.Location = new System.Drawing.Point(273, 3);
            this.tBarMasterVolume.Name = "tBarMasterVolume";
            this.tBarMasterVolume.Size = new System.Drawing.Size(177, 44);
            this.tBarMasterVolume.TabIndex = 4;
            this.tBarMasterVolume.Value = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(153, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 39);
            this.panel2.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblVolume, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(110, 35);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVolume.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVolume.Location = new System.Drawing.Point(33, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(74, 35);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "100%";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RPGMasterTools.Properties.Resources.ico_speaker_withsound;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.fLayoutAmbience);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Location = new System.Drawing.Point(0, 55);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(453, 572);
            this.pnlBottom.TabIndex = 2;
            // 
            // fLayoutAmbience
            // 
            this.fLayoutAmbience.AutoScroll = true;
            this.fLayoutAmbience.BackColor = System.Drawing.Color.White;
            this.fLayoutAmbience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayoutAmbience.Location = new System.Drawing.Point(0, 0);
            this.fLayoutAmbience.Margin = new System.Windows.Forms.Padding(0);
            this.fLayoutAmbience.Name = "fLayoutAmbience";
            this.fLayoutAmbience.Size = new System.Drawing.Size(453, 572);
            this.fLayoutAmbience.TabIndex = 2;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlTopBar.Controls.Add(this.tableLayoutPanel3);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTopBar.Size = new System.Drawing.Size(453, 50);
            this.pnlTopBar.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnFXSearch, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.verticalSeparator1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveAll, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(443, 40);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 2, 5, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(348, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnFXSearch
            // 
            this.btnFXSearch.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_magnifier;
            this.btnFXSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFXSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFXSearch.Location = new System.Drawing.Point(353, 0);
            this.btnFXSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnFXSearch.Name = "btnFXSearch";
            this.btnFXSearch.Size = new System.Drawing.Size(40, 40);
            this.btnFXSearch.TabIndex = 1;
            this.btnFXSearch.UseVisualStyleBackColor = true;
            this.btnFXSearch.Click += new System.EventHandler(this.btnFXSearch_Click);
            // 
            // verticalSeparator1
            // 
            this.verticalSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSeparator1.Location = new System.Drawing.Point(397, 0);
            this.verticalSeparator1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verticalSeparator1.MaximumSize = new System.Drawing.Size(2, 2000);
            this.verticalSeparator1.MinimumSize = new System.Drawing.Size(2, 0);
            this.verticalSeparator1.Name = "verticalSeparator1";
            this.verticalSeparator1.Size = new System.Drawing.Size(2, 40);
            this.verticalSeparator1.TabIndex = 2;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_trash;
            this.btnRemoveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveAll.Location = new System.Drawing.Point(403, 0);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarMasterVolume)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAmbience;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnMasterPlay;
        private System.Windows.Forms.TrackBar tBarMasterVolume;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel fLayoutAmbience;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFXSearch;
        private Component.VerticalSeparator verticalSeparator1;
        private System.Windows.Forms.Button btnRemoveAll;
    }
}
