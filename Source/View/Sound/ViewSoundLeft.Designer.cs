namespace RPGMasterTools.Source.View.Sound
{
    partial class ViewSoundLeft
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
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tViewData = new System.Windows.Forms.TreeView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchAsset = new System.Windows.Forms.Button();
            this.txtFindAsset = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.verticalSeparator1 = new RPGMasterTools.Source.View.Component.VerticalSeparator();
            this.tblLayout.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.pnlMiddle, 0, 2);
            this.tblLayout.Controls.Add(this.pnlBottom, 0, 3);
            this.tblLayout.Controls.Add(this.pnlTop, 0, 1);
            this.tblLayout.Controls.Add(this.panel1, 0, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 4;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayout.Size = new System.Drawing.Size(369, 571);
            this.tblLayout.TabIndex = 0;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.grpDetail);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(3, 279);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(363, 244);
            this.pnlMiddle.TabIndex = 0;
            // 
            // grpDetail
            // 
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Location = new System.Drawing.Point(0, 0);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(363, 244);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "SOUND.LEFT.DETAIL.TITLE";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlBottom.Controls.Add(this.lblStatus);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.pnlBottom.Location = new System.Drawing.Point(3, 529);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(363, 39);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(363, 39);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "STATUS";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tViewData);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 48);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(363, 225);
            this.pnlTop.TabIndex = 2;
            // 
            // tViewData
            // 
            this.tViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tViewData.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tViewData.Location = new System.Drawing.Point(0, 0);
            this.tViewData.Margin = new System.Windows.Forms.Padding(0);
            this.tViewData.Name = "tViewData";
            this.tViewData.Size = new System.Drawing.Size(363, 225);
            this.tViewData.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(363, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 40);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearchAsset, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFindAsset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExpand, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCollapse, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.verticalSeparator1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 40);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSearchAsset
            // 
            this.btnSearchAsset.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_magnifier;
            this.btnSearchAsset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchAsset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchAsset.Location = new System.Drawing.Point(183, 0);
            this.btnSearchAsset.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchAsset.Name = "btnSearchAsset";
            this.btnSearchAsset.Size = new System.Drawing.Size(40, 40);
            this.btnSearchAsset.TabIndex = 4;
            this.btnSearchAsset.UseVisualStyleBackColor = true;
            // 
            // txtFindAsset
            // 
            this.txtFindAsset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAsset.Location = new System.Drawing.Point(0, 2);
            this.txtFindAsset.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtFindAsset.Name = "txtFindAsset";
            this.txtFindAsset.Size = new System.Drawing.Size(173, 32);
            this.txtFindAsset.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(233, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_expand;
            this.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpand.Location = new System.Drawing.Point(278, 0);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(0);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(40, 40);
            this.btnExpand.TabIndex = 6;
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackgroundImage = global::RPGMasterTools.Properties.Resources.ico_collapse;
            this.btnCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCollapse.Location = new System.Drawing.Point(323, 0);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(40, 40);
            this.btnCollapse.TabIndex = 7;
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // verticalSeparator1
            // 
            this.verticalSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSeparator1.Location = new System.Drawing.Point(227, 1);
            this.verticalSeparator1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.verticalSeparator1.MaximumSize = new System.Drawing.Size(2, 2000);
            this.verticalSeparator1.MinimumSize = new System.Drawing.Size(2, 0);
            this.verticalSeparator1.Name = "verticalSeparator1";
            this.verticalSeparator1.Size = new System.Drawing.Size(2, 38);
            this.verticalSeparator1.TabIndex = 8;
            // 
            // ViewSoundLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayout);
            this.Name = "ViewSoundLeft";
            this.Size = new System.Drawing.Size(369, 571);
            this.Load += new System.EventHandler(this.ViewSoundLeft_Load);
            this.tblLayout.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TreeView tViewData;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtFindAsset;
        private System.Windows.Forms.Button btnSearchAsset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnCollapse;
        private Component.VerticalSeparator verticalSeparator1;
    }
}
