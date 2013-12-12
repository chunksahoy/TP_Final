namespace TP_Final
{
    partial class DeleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FB_Cancel = new FlashButton.FlashButton();
            this.FB_Ok = new FlashButton.FlashButton();
            this.Lbl_TextIntro = new System.Windows.Forms.Label();
            this.LBL_ElementSupprime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FB_Cancel
            // 
            this.FB_Cancel.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Annuler_Neutral;
            this.FB_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Cancel.ImageClick = global::TP_Final.Properties.Resources.ICON_Annuler_Click;
            this.FB_Cancel.ImageDisable = global::TP_Final.Properties.Resources.ICON_Annuler_Disable;
            this.FB_Cancel.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Annuler_Neutral;
            this.FB_Cancel.ImageOver = global::TP_Final.Properties.Resources.ICON_Annuler_Over;
            this.FB_Cancel.Location = new System.Drawing.Point(342, 70);
            this.FB_Cancel.Name = "FB_Cancel";
            this.FB_Cancel.Size = new System.Drawing.Size(25, 26);
            this.FB_Cancel.TabIndex = 9;
            this.FB_Cancel.Click += new System.EventHandler(this.FB_Cancel_Click);
            // 
            // FB_Ok
            // 
            this.FB_Ok.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Accepter_Neutral;
            this.FB_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ok.ImageClick = global::TP_Final.Properties.Resources.ICON_Accepter_Click;
            this.FB_Ok.ImageDisable = global::TP_Final.Properties.Resources.ICON_Accepter_Disable;
            this.FB_Ok.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Accepter_Neutral;
            this.FB_Ok.ImageOver = global::TP_Final.Properties.Resources.ICON_Accepter_Over;
            this.FB_Ok.Location = new System.Drawing.Point(310, 70);
            this.FB_Ok.Name = "FB_Ok";
            this.FB_Ok.Size = new System.Drawing.Size(26, 26);
            this.FB_Ok.TabIndex = 8;
            this.FB_Ok.Click += new System.EventHandler(this.FB_Ok_Click);
            // 
            // Lbl_TextIntro
            // 
            this.Lbl_TextIntro.AutoSize = true;
            this.Lbl_TextIntro.Location = new System.Drawing.Point(47, 36);
            this.Lbl_TextIntro.Name = "Lbl_TextIntro";
            this.Lbl_TextIntro.Size = new System.Drawing.Size(153, 13);
            this.Lbl_TextIntro.TabIndex = 10;
            this.Lbl_TextIntro.Text = "Voulez-vous vraiment suprimer ";
            // 
            // LBL_ElementSupprime
            // 
            this.LBL_ElementSupprime.AutoSize = true;
            this.LBL_ElementSupprime.Location = new System.Drawing.Point(193, 36);
            this.LBL_ElementSupprime.Name = "LBL_ElementSupprime";
            this.LBL_ElementSupprime.Size = new System.Drawing.Size(96, 13);
            this.LBL_ElementSupprime.TabIndex = 11;
            this.LBL_ElementSupprime.Text = "Element a suprimer";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 108);
            this.Controls.Add(this.LBL_ElementSupprime);
            this.Controls.Add(this.Lbl_TextIntro);
            this.Controls.Add(this.FB_Cancel);
            this.Controls.Add(this.FB_Ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteForm";
            this.Text = "Confirmer la supression";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlashButton.FlashButton FB_Cancel;
        private FlashButton.FlashButton FB_Ok;
        private System.Windows.Forms.Label Lbl_TextIntro;
        private System.Windows.Forms.Label LBL_ElementSupprime;
    }
}