﻿namespace TP_Final
{
    partial class Player_Form
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
            this.LBL_Position = new System.Windows.Forms.Label();
            this.LBL_Goals = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Player_Position = new System.Windows.Forms.TextBox();
            this.TB_Player_Goals = new System.Windows.Forms.TextBox();
            this.TB_Player_Points = new System.Windows.Forms.TextBox();
            this.TB_Player_Pass = new System.Windows.Forms.TextBox();
            this.TB_Player_Penalty = new System.Windows.Forms.TextBox();
            this.PN_Player_Picture = new System.Windows.Forms.Panel();
            this.PN_Player_Team_Logo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_Player_Stats = new System.Windows.Forms.GroupBox();
            this.FB_Cancel = new FlashButton.FlashButton();
            this.FB_Ok = new FlashButton.FlashButton();
            this.menuStrip1.SuspendLayout();
            this.GB_Player_Stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Position
            // 
            this.LBL_Position.AutoSize = true;
            this.LBL_Position.Location = new System.Drawing.Point(10, 19);
            this.LBL_Position.Name = "LBL_Position";
            this.LBL_Position.Size = new System.Drawing.Size(47, 13);
            this.LBL_Position.TabIndex = 0;
            this.LBL_Position.Text = "Position:";
            // 
            // LBL_Goals
            // 
            this.LBL_Goals.AutoSize = true;
            this.LBL_Goals.Location = new System.Drawing.Point(10, 67);
            this.LBL_Goals.Name = "LBL_Goals";
            this.LBL_Goals.Size = new System.Drawing.Size(37, 13);
            this.LBL_Goals.TabIndex = 0;
            this.LBL_Goals.Text = "But(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Passe(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Point(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Punition(s):";
            // 
            // TB_Player_Position
            // 
            this.TB_Player_Position.Location = new System.Drawing.Point(75, 19);
            this.TB_Player_Position.Name = "TB_Player_Position";
            this.TB_Player_Position.Size = new System.Drawing.Size(100, 20);
            this.TB_Player_Position.TabIndex = 1;
            // 
            // TB_Player_Goals
            // 
            this.TB_Player_Goals.Location = new System.Drawing.Point(75, 67);
            this.TB_Player_Goals.Name = "TB_Player_Goals";
            this.TB_Player_Goals.Size = new System.Drawing.Size(100, 20);
            this.TB_Player_Goals.TabIndex = 1;
            // 
            // TB_Player_Points
            // 
            this.TB_Player_Points.Location = new System.Drawing.Point(75, 160);
            this.TB_Player_Points.Name = "TB_Player_Points";
            this.TB_Player_Points.Size = new System.Drawing.Size(100, 20);
            this.TB_Player_Points.TabIndex = 1;
            // 
            // TB_Player_Pass
            // 
            this.TB_Player_Pass.Location = new System.Drawing.Point(75, 113);
            this.TB_Player_Pass.Name = "TB_Player_Pass";
            this.TB_Player_Pass.Size = new System.Drawing.Size(100, 20);
            this.TB_Player_Pass.TabIndex = 1;
            // 
            // TB_Player_Penalty
            // 
            this.TB_Player_Penalty.Location = new System.Drawing.Point(75, 202);
            this.TB_Player_Penalty.Name = "TB_Player_Penalty";
            this.TB_Player_Penalty.Size = new System.Drawing.Size(100, 20);
            this.TB_Player_Penalty.TabIndex = 1;
            // 
            // PN_Player_Picture
            // 
            this.PN_Player_Picture.Location = new System.Drawing.Point(67, 48);
            this.PN_Player_Picture.Name = "PN_Player_Picture";
            this.PN_Player_Picture.Size = new System.Drawing.Size(180, 100);
            this.PN_Player_Picture.TabIndex = 2;
            this.PN_Player_Picture.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Player_Picture_Paint);
            // 
            // PN_Player_Team_Logo
            // 
            this.PN_Player_Team_Logo.Location = new System.Drawing.Point(12, 48);
            this.PN_Player_Team_Logo.Name = "PN_Player_Team_Logo";
            this.PN_Player_Team_Logo.Size = new System.Drawing.Size(44, 38);
            this.PN_Player_Team_Logo.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // GB_Player_Stats
            // 
            this.GB_Player_Stats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Player_Stats.Controls.Add(this.TB_Player_Position);
            this.GB_Player_Stats.Controls.Add(this.LBL_Position);
            this.GB_Player_Stats.Controls.Add(this.LBL_Goals);
            this.GB_Player_Stats.Controls.Add(this.label3);
            this.GB_Player_Stats.Controls.Add(this.label4);
            this.GB_Player_Stats.Controls.Add(this.TB_Player_Penalty);
            this.GB_Player_Stats.Controls.Add(this.label5);
            this.GB_Player_Stats.Controls.Add(this.TB_Player_Pass);
            this.GB_Player_Stats.Controls.Add(this.TB_Player_Goals);
            this.GB_Player_Stats.Controls.Add(this.TB_Player_Points);
            this.GB_Player_Stats.Location = new System.Drawing.Point(67, 154);
            this.GB_Player_Stats.Name = "GB_Player_Stats";
            this.GB_Player_Stats.Size = new System.Drawing.Size(180, 232);
            this.GB_Player_Stats.TabIndex = 7;
            this.GB_Player_Stats.TabStop = false;
            // 
            // FB_Cancel
            // 
            this.FB_Cancel.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Annuler_Neutral;
            this.FB_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Cancel.ImageClick = global::TP_Final.Properties.Resources.ICON_Annuler_Click;
            this.FB_Cancel.ImageDisable = global::TP_Final.Properties.Resources.ICON_Annuler_Disable;
            this.FB_Cancel.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Annuler_Neutral;
            this.FB_Cancel.ImageOver = global::TP_Final.Properties.Resources.ICON_Annuler_Over;
            this.FB_Cancel.Location = new System.Drawing.Point(257, 420);
            this.FB_Cancel.Name = "FB_Cancel";
            this.FB_Cancel.Size = new System.Drawing.Size(25, 26);
            this.FB_Cancel.TabIndex = 5;
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
            this.FB_Ok.Location = new System.Drawing.Point(225, 420);
            this.FB_Ok.Name = "FB_Ok";
            this.FB_Ok.Size = new System.Drawing.Size(26, 26);
            this.FB_Ok.TabIndex = 6;
            this.FB_Ok.Click += new System.EventHandler(this.FB_Ok_Click);
            // 
            // Player_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 458);
            this.Controls.Add(this.GB_Player_Stats);
            this.Controls.Add(this.FB_Cancel);
            this.Controls.Add(this.FB_Ok);
            this.Controls.Add(this.PN_Player_Team_Logo);
            this.Controls.Add(this.PN_Player_Picture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Player_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GB_Player_Stats.ResumeLayout(false);
            this.GB_Player_Stats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Position;
        private System.Windows.Forms.Label LBL_Goals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Player_Position;
        private System.Windows.Forms.TextBox TB_Player_Goals;
        private System.Windows.Forms.TextBox TB_Player_Points;
        private System.Windows.Forms.TextBox TB_Player_Pass;
        private System.Windows.Forms.TextBox TB_Player_Penalty;
        private System.Windows.Forms.Panel PN_Player_Picture;
        private System.Windows.Forms.Panel PN_Player_Team_Logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FlashButton.FlashButton FB_Cancel;
        private FlashButton.FlashButton FB_Ok;
        private System.Windows.Forms.GroupBox GB_Player_Stats;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    }
}