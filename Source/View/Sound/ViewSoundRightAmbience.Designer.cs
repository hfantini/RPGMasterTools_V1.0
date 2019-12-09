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
            this.fLayoutAmbience = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnMasterPlay = new System.Windows.Forms.Button();
            this.tBarMasterVolume = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblAmbience.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarMasterVolume)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAmbience
            // 
            this.tblAmbience.ColumnCount = 1;
            this.tblAmbience.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAmbience.Controls.Add(this.fLayoutAmbience, 0, 0);
            this.tblAmbience.Controls.Add(this.pnlBottom, 0, 1);
            this.tblAmbience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAmbience.Location = new System.Drawing.Point(0, 0);
            this.tblAmbience.Name = "tblAmbience";
            this.tblAmbience.RowCount = 2;
            this.tblAmbience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAmbience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblAmbience.Size = new System.Drawing.Size(453, 677);
            this.tblAmbience.TabIndex = 0;
            // 
            // fLayoutAmbience
            // 
            this.fLayoutAmbience.AutoScroll = true;
            this.fLayoutAmbience.BackColor = System.Drawing.Color.White;
            this.fLayoutAmbience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayoutAmbience.Location = new System.Drawing.Point(0, 5);
            this.fLayoutAmbience.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.fLayoutAmbience.Name = "fLayoutAmbience";
            this.fLayoutAmbience.Size = new System.Drawing.Size(453, 622);
            this.fLayoutAmbience.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.tableLayoutPanel1);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Location = new System.Drawing.Point(0, 627);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(453, 50);
            this.pnlBottom.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
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
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 50);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
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
            this.btnMasterPlay.Click += new System.EventHandler(this.btnMasterPlay_Click);
            // 
            // tBarMasterVolume
            // 
            this.tBarMasterVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBarMasterVolume.Location = new System.Drawing.Point(273, 3);
            this.tBarMasterVolume.Name = "tBarMasterVolume";
            this.tBarMasterVolume.Size = new System.Drawing.Size(177, 44);
            this.tBarMasterVolume.TabIndex = 4;
            this.tBarMasterVolume.Value = 10;
            this.tBarMasterVolume.Scroll += new System.EventHandler(this.tBarMasterVolume_Scroll);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(153, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 44);
            this.panel1.TabIndex = 5;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(110, 40);
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
            this.lblVolume.Size = new System.Drawing.Size(74, 40);
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
            this.pictureBox1.Size = new System.Drawing.Size(24, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.pnlBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarMasterVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAmbience;
        private System.Windows.Forms.FlowLayoutPanel fLayoutAmbience;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMasterPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar tBarMasterVolume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
