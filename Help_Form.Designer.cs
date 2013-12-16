namespace TP_Final
{
    partial class Help_Form
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
            this.TB_Aide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Aide
            // 
            this.TB_Aide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Aide.Cursor = System.Windows.Forms.Cursors.Default;
            this.TB_Aide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Aide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TB_Aide.Location = new System.Drawing.Point(32, 27);
            this.TB_Aide.Multiline = true;
            this.TB_Aide.Name = "TB_Aide";
            this.TB_Aide.ReadOnly = true;
            this.TB_Aide.ShortcutsEnabled = false;
            this.TB_Aide.Size = new System.Drawing.Size(489, 135);
            this.TB_Aide.TabIndex = 10;
            this.TB_Aide.TabStop = false;
            this.TB_Aide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Aide.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cette application a été développé par Mathieu Dumoulin et Charles Hunter Roy";
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Aide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Help_Form";
            this.Text = "Aide";
            this.Load += new System.EventHandler(this.Help_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Aide;
        private System.Windows.Forms.Label label1;
    }
}