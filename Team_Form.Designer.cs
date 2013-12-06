﻿namespace TP_Final
{
    partial class Team_Form
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
            this.DGV_Players = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FB_Remove_Player = new FlashButton.FlashButton();
            this.FB_Ok = new FlashButton.FlashButton();
            this.FB_Edit_Player = new FlashButton.FlashButton();
            this.FB_Display_Calendar = new FlashButton.FlashButton();
            this.FB_Cancel = new FlashButton.FlashButton();
            this.FB_Add_Player = new FlashButton.FlashButton();
            this.LBL_Team = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Players)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Players
            // 
            this.DGV_Players.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Players.Location = new System.Drawing.Point(57, 111);
            this.DGV_Players.Name = "DGV_Players";
            this.DGV_Players.Size = new System.Drawing.Size(999, 439);
            this.DGV_Players.TabIndex = 0;
            this.DGV_Players.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Players_RowHeaderMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // FB_Remove_Player
            // 
            this.FB_Remove_Player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Remove_Player.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Remove_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Remove_Player.ImageClick = global::TP_Final.Properties.Resources.Delete_Click;
            this.FB_Remove_Player.ImageDisable = global::TP_Final.Properties.Resources.Delete_Disable;
            this.FB_Remove_Player.ImageNeutral = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Remove_Player.ImageOver = global::TP_Final.Properties.Resources.Delete_Over;
            this.FB_Remove_Player.Location = new System.Drawing.Point(91, 558);
            this.FB_Remove_Player.Name = "FB_Remove_Player";
            this.FB_Remove_Player.Size = new System.Drawing.Size(28, 26);
            this.FB_Remove_Player.TabIndex = 4;
            // 
            // FB_Ok
            // 
            this.FB_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Ok.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Accepter_Neutral;
            this.FB_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ok.ImageClick = global::TP_Final.Properties.Resources.ICON_Accepter_Click;
            this.FB_Ok.ImageDisable = global::TP_Final.Properties.Resources.ICON_Accepter_Disable;
            this.FB_Ok.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Accepter_Neutral;
            this.FB_Ok.ImageOver = global::TP_Final.Properties.Resources.ICON_Accepter_Over;
            this.FB_Ok.Location = new System.Drawing.Point(1018, 621);
            this.FB_Ok.Name = "FB_Ok";
            this.FB_Ok.Size = new System.Drawing.Size(38, 36);
            this.FB_Ok.TabIndex = 4;
            this.FB_Ok.Click += new System.EventHandler(this.FB_Ok_Click);
            // 
            // FB_Edit_Player
            // 
            this.FB_Edit_Player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Edit_Player.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Edit_Player.ImageClick = global::TP_Final.Properties.Resources.ICON_Editer_Click;
            this.FB_Edit_Player.ImageDisable = global::TP_Final.Properties.Resources.ICON_Editer_Disable;
            this.FB_Edit_Player.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Player.ImageOver = global::TP_Final.Properties.Resources.ICON_Editer_Survol;
            this.FB_Edit_Player.Location = new System.Drawing.Point(160, 558);
            this.FB_Edit_Player.Name = "FB_Edit_Player";
            this.FB_Edit_Player.Size = new System.Drawing.Size(28, 26);
            this.FB_Edit_Player.TabIndex = 4;
            this.FB_Edit_Player.Click += new System.EventHandler(this.FB_Edit_Player_Click);
            // 
            // FB_Display_Calendar
            // 
            this.FB_Display_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Display_Calendar.BackgroundImage = global::TP_Final.Properties.Resources.Calendar_Neutral1;
            this.FB_Display_Calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Display_Calendar.ImageClick = global::TP_Final.Properties.Resources.Calendar_Click;
            this.FB_Display_Calendar.ImageDisable = global::TP_Final.Properties.Resources.Calendar_Disable;
            this.FB_Display_Calendar.ImageNeutral = global::TP_Final.Properties.Resources.Calendar_Neutral1;
            this.FB_Display_Calendar.ImageOver = global::TP_Final.Properties.Resources.Calendar_Over;
            this.FB_Display_Calendar.Location = new System.Drawing.Point(905, 556);
            this.FB_Display_Calendar.Name = "FB_Display_Calendar";
            this.FB_Display_Calendar.Size = new System.Drawing.Size(75, 61);
            this.FB_Display_Calendar.TabIndex = 5;
            // 
            // FB_Cancel
            // 
            this.FB_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Cancel.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Annuler_Neutral;
            this.FB_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Cancel.ImageClick = global::TP_Final.Properties.Resources.ICON_Annuler_Click;
            this.FB_Cancel.ImageDisable = global::TP_Final.Properties.Resources.ICON_Annuler_Disable;
            this.FB_Cancel.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Annuler_Neutral;
            this.FB_Cancel.ImageOver = global::TP_Final.Properties.Resources.ICON_Annuler_Over;
            this.FB_Cancel.Location = new System.Drawing.Point(1062, 621);
            this.FB_Cancel.Name = "FB_Cancel";
            this.FB_Cancel.Size = new System.Drawing.Size(37, 36);
            this.FB_Cancel.TabIndex = 4;
            this.FB_Cancel.Click += new System.EventHandler(this.FB_Cancel_Click);
            // 
            // FB_Add_Player
            // 
            this.FB_Add_Player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Add_Player.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Add_Player.ImageClick = global::TP_Final.Properties.Resources.ICON_Ajouter_Click;
            this.FB_Add_Player.ImageDisable = global::TP_Final.Properties.Resources.ICON_Ajouter_Disable;
            this.FB_Add_Player.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Player.ImageOver = global::TP_Final.Properties.Resources.ICON_Ajouter_Over;
            this.FB_Add_Player.Location = new System.Drawing.Point(57, 556);
            this.FB_Add_Player.Name = "FB_Add_Player";
            this.FB_Add_Player.Size = new System.Drawing.Size(28, 28);
            this.FB_Add_Player.TabIndex = 4;
            this.FB_Add_Player.Click += new System.EventHandler(this.FB_Add_Player_Click);
            // 
            // LBL_Team
            // 
            this.LBL_Team.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Team.AutoSize = true;
            this.LBL_Team.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Team.Location = new System.Drawing.Point(491, 40);
            this.LBL_Team.Name = "LBL_Team";
            this.LBL_Team.Size = new System.Drawing.Size(80, 27);
            this.LBL_Team.TabIndex = 6;
            this.LBL_Team.Text = "Équipe";
            this.LBL_Team.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Team.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBL_Team_MouseClick);
            this.LBL_Team.MouseEnter += new System.EventHandler(this.LBL_Team_MouseEnter);
            this.LBL_Team.MouseLeave += new System.EventHandler(this.LBL_Team_MouseLeave);
            // 
            // Team_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 671);
            this.Controls.Add(this.LBL_Team);
            this.Controls.Add(this.FB_Display_Calendar);
            this.Controls.Add(this.FB_Cancel);
            this.Controls.Add(this.FB_Ok);
            this.Controls.Add(this.FB_Remove_Player);
            this.Controls.Add(this.FB_Edit_Player);
            this.Controls.Add(this.FB_Add_Player);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DGV_Players);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Team_Form";
            this.Text = "Joueurs";
            this.Load += new System.EventHandler(this.Team_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Players)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Players;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private FlashButton.FlashButton FB_Add_Player;
        private FlashButton.FlashButton FB_Remove_Player;
        private FlashButton.FlashButton FB_Ok;
        private FlashButton.FlashButton FB_Cancel;
        private FlashButton.FlashButton FB_Display_Calendar;
        private FlashButton.FlashButton FB_Edit_Player;
        private System.Windows.Forms.Label LBL_Team;
    }
}