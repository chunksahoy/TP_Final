namespace TP_Final
{
    partial class Add_Division_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Division_Name = new System.Windows.Forms.TextBox();
            this.DTP_Division_Join = new System.Windows.Forms.DateTimePicker();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.GB_Division_Stats = new System.Windows.Forms.GroupBox();
            this.GB_Division_Stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Introduction:";
            // 
            // TB_Division_Name
            // 
            this.TB_Division_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Division_Name.Location = new System.Drawing.Point(105, 19);
            this.TB_Division_Name.Name = "TB_Division_Name";
            this.TB_Division_Name.Size = new System.Drawing.Size(156, 20);
            this.TB_Division_Name.TabIndex = 1;
            this.TB_Division_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Division_Name_KeyPress);
            // 
            // DTP_Division_Join
            // 
            this.DTP_Division_Join.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Division_Join.Location = new System.Drawing.Point(105, 53);
            this.DTP_Division_Join.Name = "DTP_Division_Join";
            this.DTP_Division_Join.Size = new System.Drawing.Size(156, 20);
            this.DTP_Division_Join.TabIndex = 2;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(218, 119);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(137, 119);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 3;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // GB_Division_Stats
            // 
            this.GB_Division_Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Division_Stats.Controls.Add(this.TB_Division_Name);
            this.GB_Division_Stats.Controls.Add(this.label1);
            this.GB_Division_Stats.Controls.Add(this.label2);
            this.GB_Division_Stats.Controls.Add(this.DTP_Division_Join);
            this.GB_Division_Stats.Location = new System.Drawing.Point(12, 2);
            this.GB_Division_Stats.Name = "GB_Division_Stats";
            this.GB_Division_Stats.Size = new System.Drawing.Size(281, 100);
            this.GB_Division_Stats.TabIndex = 4;
            this.GB_Division_Stats.TabStop = false;
            // 
            // Add_Division_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 154);
            this.Controls.Add(this.GB_Division_Stats);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Add_Division_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Division_Form_FormClosing);
            this.Load += new System.EventHandler(this.Add_Division_Form_Load);
            this.GB_Division_Stats.ResumeLayout(false);
            this.GB_Division_Stats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Division_Name;
        private System.Windows.Forms.DateTimePicker DTP_Division_Join;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.GroupBox GB_Division_Stats;
    }
}