namespace TP_Final
{
    partial class Edit_Match_Form
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
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.NUD_Visitor_Score = new System.Windows.Forms.NumericUpDown();
            this.NUD_Home_Score = new System.Windows.Forms.NumericUpDown();
            this.LBL_Visitor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Stadium = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Visitor_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Home_Score)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(162, 195);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 0;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(81, 195);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 0;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // NUD_Visitor_Score
            // 
            this.NUD_Visitor_Score.Location = new System.Drawing.Point(121, 147);
            this.NUD_Visitor_Score.Name = "NUD_Visitor_Score";
            this.NUD_Visitor_Score.Size = new System.Drawing.Size(60, 20);
            this.NUD_Visitor_Score.TabIndex = 1;
            // 
            // NUD_Home_Score
            // 
            this.NUD_Home_Score.Location = new System.Drawing.Point(121, 109);
            this.NUD_Home_Score.Name = "NUD_Home_Score";
            this.NUD_Home_Score.Size = new System.Drawing.Size(60, 20);
            this.NUD_Home_Score.TabIndex = 1;
            // 
            // LBL_Visitor
            // 
            this.LBL_Visitor.AutoSize = true;
            this.LBL_Visitor.Location = new System.Drawing.Point(12, 147);
            this.LBL_Visitor.Name = "LBL_Visitor";
            this.LBL_Visitor.Size = new System.Drawing.Size(75, 13);
            this.LBL_Visitor.TabIndex = 2;
            this.LBL_Visitor.Text = "Score Visiteur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score Receveur:";
            // 
            // TB_Stadium
            // 
            this.TB_Stadium.Location = new System.Drawing.Point(121, 34);
            this.TB_Stadium.Name = "TB_Stadium";
            this.TB_Stadium.Size = new System.Drawing.Size(116, 20);
            this.TB_Stadium.TabIndex = 4;
            this.TB_Stadium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Stadium_KeyPress);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(121, 70);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(116, 20);
            this.DTP_Date.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lieu de rencontre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date de rencontre:";
            // 
            // Edit_Match_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 225);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.TB_Stadium);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_Visitor);
            this.Controls.Add(this.NUD_Home_Score);
            this.Controls.Add(this.NUD_Visitor_Score);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(260, 263);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 263);
            this.Name = "Edit_Match_Form";
            this.Load += new System.EventHandler(this.Edit_Match_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Visitor_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Home_Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.NumericUpDown NUD_Visitor_Score;
        private System.Windows.Forms.NumericUpDown NUD_Home_Score;
        private System.Windows.Forms.Label LBL_Visitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Stadium;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}