namespace RPGMasterTools.Source.View.Sound
{
    partial class ViewSoundLeftDetailEmpty
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
            this.lblEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmpty
            // 
            this.lblEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpty.Location = new System.Drawing.Point(0, 104);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(491, 27);
            this.lblEmpty.TabIndex = 0;
            this.lblEmpty.Text = "SOUND.LEFT.DETAIL.EMPTY";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewSoundLeftDetailEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmpty);
            this.Name = "ViewSoundLeftDetailEmpty";
            this.Size = new System.Drawing.Size(491, 241);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmpty;
    }
}
