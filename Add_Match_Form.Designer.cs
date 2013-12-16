namespace TP_Final
{
    partial class Add_Match_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Home = new System.Windows.Forms.TextBox();
            this.TB_Visitor = new System.Windows.Forms.TextBox();
            this.TB_Stadium = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(212, 187);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 8;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(131, 187);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 7;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receveur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visiteur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date de rencontre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lieu:";
            // 
            // TB_Home
            // 
            this.TB_Home.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TB_Home.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TB_Home.Location = new System.Drawing.Point(131, 25);
            this.TB_Home.Name = "TB_Home";
            this.TB_Home.Size = new System.Drawing.Size(150, 20);
            this.TB_Home.TabIndex = 1;
            this.TB_Home.TextChanged += new System.EventHandler(this.TB_Home_TextChanged);
            this.TB_Home.Enter += new System.EventHandler(this.TB_Home_Enter);
            this.TB_Home.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Home_KeyPress);
            // 
            // TB_Visitor
            // 
            this.TB_Visitor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TB_Visitor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TB_Visitor.Location = new System.Drawing.Point(131, 64);
            this.TB_Visitor.Name = "TB_Visitor";
            this.TB_Visitor.Size = new System.Drawing.Size(150, 20);
            this.TB_Visitor.TabIndex = 2;
            this.TB_Visitor.TextChanged += new System.EventHandler(this.TB_Visitor_TextChanged);
            this.TB_Visitor.Enter += new System.EventHandler(this.TB_Visitor_Enter);
            this.TB_Visitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Home_KeyPress);
            // 
            // TB_Stadium
            // 
            this.TB_Stadium.Location = new System.Drawing.Point(131, 142);
            this.TB_Stadium.Name = "TB_Stadium";
            this.TB_Stadium.Size = new System.Drawing.Size(150, 20);
            this.TB_Stadium.TabIndex = 4;
            this.TB_Stadium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Home_KeyPress);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(131, 102);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(150, 20);
            this.DTP_Date.TabIndex = 3;
            // 
            // Add_Match_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 222);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.TB_Stadium);
            this.Controls.Add(this.TB_Visitor);
            this.Controls.Add(this.TB_Home);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Add_Match_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Match_Form_FormClosing);
            this.Load += new System.EventHandler(this.Add_Match_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Home;
        private System.Windows.Forms.TextBox TB_Visitor;
        private System.Windows.Forms.TextBox TB_Stadium;
        private System.Windows.Forms.DateTimePicker DTP_Date;
    }
}