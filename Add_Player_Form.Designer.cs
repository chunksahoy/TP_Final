namespace TP_Final
{
    partial class Add_Player_Form
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
            this.DTP_Player_Birth = new System.Windows.Forms.DateTimePicker();
            this.TB_Player_Name = new System.Windows.Forms.TextBox();
            this.TB_Player_Surname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_Player_Picture = new System.Windows.Forms.Panel();
            this.BTN_Browse_Logos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NUD_Jersey_Number = new System.Windows.Forms.NumericUpDown();
            this.CBX_Player_Role = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Jersey_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(88, 378);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 13;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(169, 378);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 14;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // DTP_Player_Birth
            // 
            this.DTP_Player_Birth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Player_Birth.Location = new System.Drawing.Point(78, 110);
            this.DTP_Player_Birth.Name = "DTP_Player_Birth";
            this.DTP_Player_Birth.Size = new System.Drawing.Size(166, 20);
            this.DTP_Player_Birth.TabIndex = 12;
            // 
            // TB_Player_Name
            // 
            this.TB_Player_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Player_Name.Location = new System.Drawing.Point(78, 69);
            this.TB_Player_Name.Name = "TB_Player_Name";
            this.TB_Player_Name.Size = new System.Drawing.Size(166, 20);
            this.TB_Player_Name.TabIndex = 10;
            this.TB_Player_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Player_Surname_KeyPress);
            // 
            // TB_Player_Surname
            // 
            this.TB_Player_Surname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Player_Surname.Location = new System.Drawing.Point(78, 30);
            this.TB_Player_Surname.Name = "TB_Player_Surname";
            this.TB_Player_Surname.Size = new System.Drawing.Size(166, 20);
            this.TB_Player_Surname.TabIndex = 11;
            this.TB_Player_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Player_Surname_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Photo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NoMaillot";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naissance";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // PN_Player_Picture
            // 
            this.PN_Player_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Player_Picture.Location = new System.Drawing.Point(78, 239);
            this.PN_Player_Picture.Name = "PN_Player_Picture";
            this.PN_Player_Picture.Size = new System.Drawing.Size(92, 85);
            this.PN_Player_Picture.TabIndex = 15;
            this.PN_Player_Picture.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Player_Picture_Paint);
            // 
            // BTN_Browse_Logos
            // 
            this.BTN_Browse_Logos.Location = new System.Drawing.Point(176, 239);
            this.BTN_Browse_Logos.Name = "BTN_Browse_Logos";
            this.BTN_Browse_Logos.Size = new System.Drawing.Size(68, 25);
            this.BTN_Browse_Logos.TabIndex = 29;
            this.BTN_Browse_Logos.Text = "Parcourir...";
            this.BTN_Browse_Logos.UseVisualStyleBackColor = true;
            this.BTN_Browse_Logos.Click += new System.EventHandler(this.BTN_Browse_Logos_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Position";
            // 
            // NUD_Jersey_Number
            // 
            this.NUD_Jersey_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Jersey_Number.Location = new System.Drawing.Point(78, 152);
            this.NUD_Jersey_Number.Name = "NUD_Jersey_Number";
            this.NUD_Jersey_Number.Size = new System.Drawing.Size(46, 20);
            this.NUD_Jersey_Number.TabIndex = 32;
            // 
            // CBX_Player_Role
            // 
            this.CBX_Player_Role.FormattingEnabled = true;
            this.CBX_Player_Role.Location = new System.Drawing.Point(78, 190);
            this.CBX_Player_Role.Name = "CBX_Player_Role";
            this.CBX_Player_Role.Size = new System.Drawing.Size(166, 21);
            this.CBX_Player_Role.TabIndex = 33;
            // 
            // Add_Player_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 421);
            this.Controls.Add(this.CBX_Player_Role);
            this.Controls.Add(this.NUD_Jersey_Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTN_Browse_Logos);
            this.Controls.Add(this.PN_Player_Picture);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.DTP_Player_Birth);
            this.Controls.Add(this.TB_Player_Name);
            this.Controls.Add(this.TB_Player_Surname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Player_Form";
            this.Text = "Ajouter Joueur";
            this.Load += new System.EventHandler(this.Add_Player_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Jersey_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.DateTimePicker DTP_Player_Birth;
        private System.Windows.Forms.TextBox TB_Player_Name;
        private System.Windows.Forms.TextBox TB_Player_Surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PN_Player_Picture;
        private System.Windows.Forms.Button BTN_Browse_Logos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUD_Jersey_Number;
        private System.Windows.Forms.ComboBox CBX_Player_Role;
    }
}