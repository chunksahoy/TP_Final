namespace TP_Final
{
    partial class Edit_Player_Form
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
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.DTP_Birth = new System.Windows.Forms.DateTimePicker();
            this.CBX_Position = new System.Windows.Forms.ComboBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PB_Player_Picture = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Browse_Pitcures = new System.Windows.Forms.Button();
            this.NUD_Jersey = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Jersey)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Surname
            // 
            this.TB_Surname.Location = new System.Drawing.Point(111, 126);
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(121, 20);
            this.TB_Surname.TabIndex = 3;
            this.TB_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Surname_KeyPress);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(111, 167);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(121, 20);
            this.TB_Name.TabIndex = 4;
            this.TB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Name_KeyPress);
            // 
            // DTP_Birth
            // 
            this.DTP_Birth.Location = new System.Drawing.Point(111, 205);
            this.DTP_Birth.Name = "DTP_Birth";
            this.DTP_Birth.Size = new System.Drawing.Size(123, 20);
            this.DTP_Birth.TabIndex = 5;
            // 
            // CBX_Position
            // 
            this.CBX_Position.FormattingEnabled = true;
            this.CBX_Position.Location = new System.Drawing.Point(111, 243);
            this.CBX_Position.Name = "CBX_Position";
            this.CBX_Position.Size = new System.Drawing.Size(121, 21);
            this.CBX_Position.TabIndex = 6;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(171, 327);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 1;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(90, 327);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 8;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prénom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naissance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position:";
            // 
            // PB_Player_Picture
            // 
            this.PB_Player_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Player_Picture.Location = new System.Drawing.Point(111, 22);
            this.PB_Player_Picture.Name = "PB_Player_Picture";
            this.PB_Player_Picture.Size = new System.Drawing.Size(92, 82);
            this.PB_Player_Picture.TabIndex = 7;
            this.PB_Player_Picture.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Photo:";
            // 
            // BTN_Browse_Pitcures
            // 
            this.BTN_Browse_Pitcures.Location = new System.Drawing.Point(209, 81);
            this.BTN_Browse_Pitcures.Name = "BTN_Browse_Pitcures";
            this.BTN_Browse_Pitcures.Size = new System.Drawing.Size(45, 23);
            this.BTN_Browse_Pitcures.TabIndex = 2;
            this.BTN_Browse_Pitcures.Text = "...";
            this.BTN_Browse_Pitcures.UseVisualStyleBackColor = true;
            this.BTN_Browse_Pitcures.Click += new System.EventHandler(this.BTN_Browse_Pitcures_Click);
            // 
            // NUD_Jersey
            // 
            this.NUD_Jersey.Location = new System.Drawing.Point(112, 281);
            this.NUD_Jersey.Name = "NUD_Jersey";
            this.NUD_Jersey.Size = new System.Drawing.Size(120, 20);
            this.NUD_Jersey.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "NoMaillot:";
            // 
            // Edit_Player_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 362);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NUD_Jersey);
            this.Controls.Add(this.BTN_Browse_Pitcures);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PB_Player_Picture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.CBX_Position);
            this.Controls.Add(this.DTP_Birth);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_Surname);
            this.Name = "Edit_Player_Form";
            this.Text = "Modifier Joueur";
            this.Load += new System.EventHandler(this.Edit_Player_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Jersey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Surname;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.DateTimePicker DTP_Birth;
        private System.Windows.Forms.ComboBox CBX_Position;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PB_Player_Picture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Browse_Pitcures;
        private System.Windows.Forms.NumericUpDown NUD_Jersey;
        private System.Windows.Forms.Label label6;
    }
}