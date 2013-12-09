namespace TP_Final
{
    partial class Add_Team_Form
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
            this.PN_Team_Logo = new System.Windows.Forms.Panel();
            this.BTN_Browse_Logos = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.DTP_Team_Join = new System.Windows.Forms.DateTimePicker();
            this.TB_Team_Town = new System.Windows.Forms.TextBox();
            this.TB_Team_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Add_Player = new System.Windows.Forms.GroupBox();
            this.GB_Add_Player.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Team_Logo
            // 
            this.PN_Team_Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_Team_Logo.Location = new System.Drawing.Point(182, 166);
            this.PN_Team_Logo.Name = "PN_Team_Logo";
            this.PN_Team_Logo.Size = new System.Drawing.Size(57, 54);
            this.PN_Team_Logo.TabIndex = 29;
            // 
            // BTN_Browse_Logos
            // 
            this.BTN_Browse_Logos.Location = new System.Drawing.Point(178, 226);
            this.BTN_Browse_Logos.Name = "BTN_Browse_Logos";
            this.BTN_Browse_Logos.Size = new System.Drawing.Size(68, 25);
            this.BTN_Browse_Logos.TabIndex = 28;
            this.BTN_Browse_Logos.Text = "Parcourir...";
            this.BTN_Browse_Logos.UseVisualStyleBackColor = true;
            this.BTN_Browse_Logos.Click += new System.EventHandler(this.BTN_Browse_Logos_Click);
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(145, 326);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 26;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(226, 326);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 27;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // DTP_Team_Join
            // 
            this.DTP_Team_Join.Location = new System.Drawing.Point(133, 70);
            this.DTP_Team_Join.Name = "DTP_Team_Join";
            this.DTP_Team_Join.Size = new System.Drawing.Size(134, 20);
            this.DTP_Team_Join.TabIndex = 25;
            // 
            // TB_Team_Town
            // 
            this.TB_Team_Town.Location = new System.Drawing.Point(133, 118);
            this.TB_Team_Town.Name = "TB_Team_Town";
            this.TB_Team_Town.Size = new System.Drawing.Size(134, 20);
            this.TB_Team_Town.TabIndex = 22;
            this.TB_Team_Town.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Team_Town_KeyPress);
            // 
            // TB_Team_Name
            // 
            this.TB_Team_Name.Location = new System.Drawing.Point(133, 17);
            this.TB_Team_Name.Name = "TB_Team_Name";
            this.TB_Team_Name.Size = new System.Drawing.Size(134, 20);
            this.TB_Team_Name.TabIndex = 24;
            this.TB_Team_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Team_Name_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Logo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date d\'introduction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ville";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nom";
            // 
            // GB_Add_Player
            // 
            this.GB_Add_Player.Controls.Add(this.PN_Team_Logo);
            this.GB_Add_Player.Controls.Add(this.label1);
            this.GB_Add_Player.Controls.Add(this.BTN_Browse_Logos);
            this.GB_Add_Player.Controls.Add(this.label3);
            this.GB_Add_Player.Controls.Add(this.label4);
            this.GB_Add_Player.Controls.Add(this.DTP_Team_Join);
            this.GB_Add_Player.Controls.Add(this.label5);
            this.GB_Add_Player.Controls.Add(this.TB_Team_Town);
            this.GB_Add_Player.Controls.Add(this.TB_Team_Name);
            this.GB_Add_Player.Location = new System.Drawing.Point(12, 33);
            this.GB_Add_Player.Name = "GB_Add_Player";
            this.GB_Add_Player.Size = new System.Drawing.Size(285, 266);
            this.GB_Add_Player.TabIndex = 30;
            this.GB_Add_Player.TabStop = false;
            // 
            // Add_Team_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 361);
            this.Controls.Add(this.GB_Add_Player);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Name = "Add_Team_Form";
            this.Load += new System.EventHandler(this.Add_Team_Form_Load);
            this.GB_Add_Player.ResumeLayout(false);
            this.GB_Add_Player.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PN_Team_Logo;
        private System.Windows.Forms.Button BTN_Browse_Logos;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.DateTimePicker DTP_Team_Join;
        private System.Windows.Forms.TextBox TB_Team_Town;
        private System.Windows.Forms.TextBox TB_Team_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Add_Player;
    }
}