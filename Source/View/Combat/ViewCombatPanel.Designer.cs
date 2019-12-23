namespace RPGMasterTools.Source.View.Combat
{
    partial class ViewCombatPanel
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
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.fLayoutList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDetailContent = new System.Windows.Forms.Panel();
            this.tblLayout.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tblLayout.ColumnCount = 2;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1000F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.tblLeft, 0, 0);
            this.tblLayout.Controls.Add(this.panel1, 1, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Size = new System.Drawing.Size(1924, 1046);
            this.tblLayout.TabIndex = 0;
            // 
            // tblLeft
            // 
            this.tblLeft.ColumnCount = 1;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Controls.Add(this.fLayoutList, 0, 1);
            this.tblLeft.Controls.Add(this.lblTitleList, 0, 0);
            this.tblLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeft.Location = new System.Drawing.Point(0, 0);
            this.tblLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 2;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLeft.Size = new System.Drawing.Size(1000, 1046);
            this.tblLeft.TabIndex = 0;
            // 
            // fLayoutList
            // 
            this.fLayoutList.AutoScroll = true;
            this.fLayoutList.BackColor = System.Drawing.Color.White;
            this.fLayoutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayoutList.Location = new System.Drawing.Point(0, 100);
            this.fLayoutList.Margin = new System.Windows.Forms.Padding(0);
            this.fLayoutList.Name = "fLayoutList";
            this.fLayoutList.Size = new System.Drawing.Size(1000, 946);
            this.fLayoutList.TabIndex = 1;
            this.fLayoutList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.fLayoutList_ControlAdded);
            // 
            // lblTitleList
            // 
            this.lblTitleList.AutoSize = true;
            this.lblTitleList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTitleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleList.Location = new System.Drawing.Point(0, 0);
            this.lblTitleList.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleList.Name = "lblTitleList";
            this.lblTitleList.Size = new System.Drawing.Size(1000, 100);
            this.lblTitleList.TabIndex = 0;
            this.lblTitleList.Text = "COMBAT.PANEL.TITLE_LIST";
            this.lblTitleList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1010, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 1046);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlDetailContent, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 1046);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMBAT.PANEL.TITLE_DETAIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(914, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "STATUS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDetailContent
            // 
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(3, 163);
            this.pnlDetailContent.Name = "pnlDetailContent";
            this.pnlDetailContent.Size = new System.Drawing.Size(908, 880);
            this.pnlDetailContent.TabIndex = 3;
            // 
            // ViewCombatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayout);
            this.Name = "ViewCombatPanel";
            this.Size = new System.Drawing.Size(1924, 1046);
            this.Load += new System.EventHandler(this.ViewCombatPanel_Load);
            this.tblLayout.ResumeLayout(false);
            this.tblLeft.ResumeLayout(false);
            this.tblLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.TableLayoutPanel tblLeft;
        private System.Windows.Forms.FlowLayoutPanel fLayoutList;
        private System.Windows.Forms.Label lblTitleList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDetailContent;
    }
}
