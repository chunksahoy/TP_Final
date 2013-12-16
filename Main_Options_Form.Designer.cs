namespace TP_Final
{
    partial class Main_Options_Form
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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_OddRow_Color = new System.Windows.Forms.Panel();
            this.PN_EvenRow_Color = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_DGV_Font = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBX_DGV_Font = new System.Windows.Forms.ComboBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(35, 183);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 21);
            this.BTN_Ok.TabIndex = 4;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(116, 183);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 21);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PN_OddRow_Color);
            this.tabPage1.Controls.Add(this.PN_EvenRow_Color);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(165, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Couleur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rangées paires";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rangées impaires";
            // 
            // PN_OddRow_Color
            // 
            this.PN_OddRow_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_OddRow_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PN_OddRow_Color.Location = new System.Drawing.Point(100, 63);
            this.PN_OddRow_Color.Name = "PN_OddRow_Color";
            this.PN_OddRow_Color.Size = new System.Drawing.Size(37, 33);
            this.PN_OddRow_Color.TabIndex = 0;
            this.PN_OddRow_Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_OddRow_Color_MouseClick);
            // 
            // PN_EvenRow_Color
            // 
            this.PN_EvenRow_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_EvenRow_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PN_EvenRow_Color.Location = new System.Drawing.Point(100, 6);
            this.PN_EvenRow_Color.Name = "PN_EvenRow_Color";
            this.PN_EvenRow_Color.Size = new System.Drawing.Size(37, 33);
            this.PN_EvenRow_Color.TabIndex = 0;
            this.PN_EvenRow_Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_EvenRow_Color_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(173, 148);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTN_DGV_Font);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.CBX_DGV_Font);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(165, 122);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Police";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_DGV_Font
            // 
            this.BTN_DGV_Font.Location = new System.Drawing.Point(123, 54);
            this.BTN_DGV_Font.Name = "BTN_DGV_Font";
            this.BTN_DGV_Font.Size = new System.Drawing.Size(36, 23);
            this.BTN_DGV_Font.TabIndex = 2;
            this.BTN_DGV_Font.Text = "...";
            this.BTN_DGV_Font.UseVisualStyleBackColor = true;
            this.BTN_DGV_Font.Click += new System.EventHandler(this.BTN_DGV_Font_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Police";
            // 
            // CBX_DGV_Font
            // 
            this.CBX_DGV_Font.FormattingEnabled = true;
            this.CBX_DGV_Font.Location = new System.Drawing.Point(42, 54);
            this.CBX_DGV_Font.Name = "CBX_DGV_Font";
            this.CBX_DGV_Font.Size = new System.Drawing.Size(75, 21);
            this.CBX_DGV_Font.TabIndex = 0;
            this.CBX_DGV_Font.SelectedIndexChanged += new System.EventHandler(this.CBX_DGV_Font_SelectedIndexChanged);
            // 
            // Main_Options_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 216);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_Options_Form";
            this.Text = "Personnaliser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Options_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Options_Form_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PN_OddRow_Color;
        private System.Windows.Forms.Panel PN_EvenRow_Color;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTN_DGV_Font;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBX_DGV_Font;
    }
}