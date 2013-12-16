namespace TP_Final
{
    partial class Match_Option_Form
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_Font_Visitor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBX_Visitor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PN_EvenRow_Color_Visitor = new System.Windows.Forms.Panel();
            this.PN_OddRow_Color_Visitor = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTN_Font_Home = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CBX_Home = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_EvenRow_Color_Home = new System.Windows.Forms.Panel();
            this.PN_OddRow_Color_Home = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(69, 212);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 21);
            this.BTN_Ok.TabIndex = 7;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(150, 212);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 21);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTN_Font_Visitor);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.CBX_Visitor);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.PN_EvenRow_Color_Visitor);
            this.tabPage2.Controls.Add(this.PN_OddRow_Color_Visitor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(205, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visiteur";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_Font_Visitor
            // 
            this.BTN_Font_Visitor.Location = new System.Drawing.Point(153, 121);
            this.BTN_Font_Visitor.Name = "BTN_Font_Visitor";
            this.BTN_Font_Visitor.Size = new System.Drawing.Size(36, 23);
            this.BTN_Font_Visitor.TabIndex = 12;
            this.BTN_Font_Visitor.Text = "...";
            this.BTN_Font_Visitor.UseVisualStyleBackColor = true;
            this.BTN_Font_Visitor.Click += new System.EventHandler(this.BTN_Font_Visitor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Police :";
            // 
            // CBX_Visitor
            // 
            this.CBX_Visitor.FormattingEnabled = true;
            this.CBX_Visitor.Location = new System.Drawing.Point(72, 121);
            this.CBX_Visitor.Name = "CBX_Visitor";
            this.CBX_Visitor.Size = new System.Drawing.Size(75, 21);
            this.CBX_Visitor.TabIndex = 10;
            this.CBX_Visitor.SelectedIndexChanged += new System.EventHandler(this.CBX_Visitor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rangées paires :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rangées impaires :";
            // 
            // PN_EvenRow_Color_Visitor
            // 
            this.PN_EvenRow_Color_Visitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_EvenRow_Color_Visitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PN_EvenRow_Color_Visitor.Location = new System.Drawing.Point(110, 66);
            this.PN_EvenRow_Color_Visitor.Name = "PN_EvenRow_Color_Visitor";
            this.PN_EvenRow_Color_Visitor.Size = new System.Drawing.Size(37, 33);
            this.PN_EvenRow_Color_Visitor.TabIndex = 6;
            this.PN_EvenRow_Color_Visitor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_EvenRow_Color_Visitor_MouseClick);
            // 
            // PN_OddRow_Color_Visitor
            // 
            this.PN_OddRow_Color_Visitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_OddRow_Color_Visitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PN_OddRow_Color_Visitor.Location = new System.Drawing.Point(110, 9);
            this.PN_OddRow_Color_Visitor.Name = "PN_OddRow_Color_Visitor";
            this.PN_OddRow_Color_Visitor.Size = new System.Drawing.Size(37, 33);
            this.PN_OddRow_Color_Visitor.TabIndex = 7;
            this.PN_OddRow_Color_Visitor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_OddRow_Color_Visitor_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTN_Font_Home);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CBX_Home);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PN_EvenRow_Color_Home);
            this.tabPage1.Controls.Add(this.PN_OddRow_Color_Home);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(205, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Receveur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTN_Font_Home
            // 
            this.BTN_Font_Home.Location = new System.Drawing.Point(153, 121);
            this.BTN_Font_Home.Name = "BTN_Font_Home";
            this.BTN_Font_Home.Size = new System.Drawing.Size(36, 23);
            this.BTN_Font_Home.TabIndex = 5;
            this.BTN_Font_Home.Text = "...";
            this.BTN_Font_Home.UseVisualStyleBackColor = true;
            this.BTN_Font_Home.Click += new System.EventHandler(this.BTN_Font_Home_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Police :";
            // 
            // CBX_Home
            // 
            this.CBX_Home.FormattingEnabled = true;
            this.CBX_Home.Location = new System.Drawing.Point(72, 121);
            this.CBX_Home.Name = "CBX_Home";
            this.CBX_Home.Size = new System.Drawing.Size(75, 21);
            this.CBX_Home.TabIndex = 3;
            this.CBX_Home.SelectedIndexChanged += new System.EventHandler(this.CBX_Home_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rangées paires :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rangées impaires :";
            // 
            // PN_EvenRow_Color_Home
            // 
            this.PN_EvenRow_Color_Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_EvenRow_Color_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PN_EvenRow_Color_Home.Location = new System.Drawing.Point(110, 66);
            this.PN_EvenRow_Color_Home.Name = "PN_EvenRow_Color_Home";
            this.PN_EvenRow_Color_Home.Size = new System.Drawing.Size(37, 33);
            this.PN_EvenRow_Color_Home.TabIndex = 0;
            this.PN_EvenRow_Color_Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_EvenRow_Color_Home_MouseClick);
            // 
            // PN_OddRow_Color_Home
            // 
            this.PN_OddRow_Color_Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_OddRow_Color_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PN_OddRow_Color_Home.Location = new System.Drawing.Point(110, 9);
            this.PN_OddRow_Color_Home.Name = "PN_OddRow_Color_Home";
            this.PN_OddRow_Color_Home.Size = new System.Drawing.Size(37, 33);
            this.PN_OddRow_Color_Home.TabIndex = 0;
            this.PN_OddRow_Color_Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_OddRow_Color_Home_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(213, 202);
            this.tabControl1.TabIndex = 5;
            // 
            // Match_Option_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 245);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Match_Option_Form";
            this.Text = "Personaliser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Match_Option_Form_FormClosing);
            this.Load += new System.EventHandler(this.Match_Option_Form_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BTN_Font_Home;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBX_Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PN_EvenRow_Color_Home;
        private System.Windows.Forms.Panel PN_OddRow_Color_Home;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button BTN_Font_Visitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBX_Visitor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PN_EvenRow_Color_Visitor;
        private System.Windows.Forms.Panel PN_OddRow_Color_Visitor;
    }
}