namespace TP_Final
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
            this.LBL_Team = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SL_TeamTips = new System.Windows.Forms.ToolStripStatusLabel();
            this.FB_Display_Calendar = new FlashButton.FlashButton();
            this.FB_Cancel = new FlashButton.FlashButton();
            this.FB_Ok = new FlashButton.FlashButton();
            this.FB_Remove_Player = new FlashButton.FlashButton();
            this.FB_Edit_Player = new FlashButton.FlashButton();
            this.FB_Add_Player = new FlashButton.FlashButton();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.LBL_String = new System.Windows.Forms.Label();
            this.LBL_Town = new System.Windows.Forms.Label();
            this.TB_Town = new System.Windows.Forms.TextBox();
            this.LBL_Division = new System.Windows.Forms.Label();
            this.CBX_Division = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Players)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
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
            this.DGV_Players.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Players.Size = new System.Drawing.Size(999, 439);
            this.DGV_Players.TabIndex = 0;
            this.DGV_Players.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Players_CellContentClick);
            this.DGV_Players.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Players_ColumnHeaderMouseClick);
            this.DGV_Players.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Players_RowHeaderMouseClick);
            this.DGV_Players.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Players_RowHeaderMouseDoubleClick);
            this.DGV_Players.MouseEnter += new System.EventHandler(this.DGV_Players_MouseEnter);
            this.DGV_Players.MouseLeave += new System.EventHandler(this.DGV_Players_MouseLeave);
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
            // LBL_Team
            // 
            this.LBL_Team.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Team.AutoSize = true;
            this.LBL_Team.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Team.Location = new System.Drawing.Point(488, 64);
            this.LBL_Team.Name = "LBL_Team";
            this.LBL_Team.Size = new System.Drawing.Size(0, 27);
            this.LBL_Team.TabIndex = 6;
            this.LBL_Team.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Team.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBL_Team_MouseClick);
            this.LBL_Team.MouseEnter += new System.EventHandler(this.LBL_Team_MouseEnter);
            this.LBL_Team.MouseLeave += new System.EventHandler(this.LBL_Team_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SL_TeamTips});
            this.statusStrip1.Location = new System.Drawing.Point(0, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1113, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SL_TeamTips
            // 
            this.SL_TeamTips.Name = "SL_TeamTips";
            this.SL_TeamTips.Size = new System.Drawing.Size(127, 17);
            this.SL_TeamTips.Text = "derpdadepiederpederp";
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
            this.FB_Display_Calendar.Click += new System.EventHandler(this.FB_Display_Calendar_Click);
            this.FB_Display_Calendar.MouseEnter += new System.EventHandler(this.FB_Display_Calendar_MouseEnter);
            this.FB_Display_Calendar.MouseLeave += new System.EventHandler(this.FB_Display_Calendar_MouseLeave);
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
            this.FB_Cancel.MouseEnter += new System.EventHandler(this.FB_Cancel_MouseEnter);
            this.FB_Cancel.MouseLeave += new System.EventHandler(this.FB_Cancel_MouseLeave);
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
            this.FB_Ok.MouseEnter += new System.EventHandler(this.FB_Ok_MouseEnter);
            this.FB_Ok.MouseLeave += new System.EventHandler(this.FB_Ok_MouseLeave);
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
            this.FB_Remove_Player.Click += new System.EventHandler(this.FB_Remove_Player_Click);
            this.FB_Remove_Player.MouseEnter += new System.EventHandler(this.FB_Remove_Player_MouseEnter);
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
            this.FB_Edit_Player.MouseEnter += new System.EventHandler(this.FB_Edit_Player_MouseEnter);
            this.FB_Edit_Player.MouseLeave += new System.EventHandler(this.FB_Edit_Player_MouseLeave);
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
            this.FB_Add_Player.MouseEnter += new System.EventHandler(this.FB_Add_Player_MouseEnter);
            this.FB_Add_Player.MouseLeave += new System.EventHandler(this.FB_Add_Player_MouseLeave);
            // 
            // PB_Logo
            // 
            this.PB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Logo.Location = new System.Drawing.Point(1016, 64);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(40, 40);
            this.PB_Logo.TabIndex = 8;
            this.PB_Logo.TabStop = false;
            this.PB_Logo.Click += new System.EventHandler(this.PB_Logo_Click);
            this.PB_Logo.MouseEnter += new System.EventHandler(this.PB_Logo_MouseEnter);
            this.PB_Logo.MouseLeave += new System.EventHandler(this.PB_Logo_MouseLeave);
            // 
            // LBL_String
            // 
            this.LBL_String.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_String.AutoSize = true;
            this.LBL_String.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_String.Location = new System.Drawing.Point(494, 64);
            this.LBL_String.Name = "LBL_String";
            this.LBL_String.Size = new System.Drawing.Size(35, 27);
            this.LBL_String.TabIndex = 6;
            this.LBL_String.Text = "de";
            this.LBL_String.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_String.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBL_Team_MouseClick);
            // 
            // LBL_Town
            // 
            this.LBL_Town.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Town.AutoSize = true;
            this.LBL_Town.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_Town.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Town.Location = new System.Drawing.Point(525, 64);
            this.LBL_Town.Name = "LBL_Town";
            this.LBL_Town.Size = new System.Drawing.Size(56, 27);
            this.LBL_Town.TabIndex = 6;
            this.LBL_Town.Text = "Ville";
            this.LBL_Town.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Town.Click += new System.EventHandler(this.LBL_Town_Click);
            this.LBL_Town.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBL_Team_MouseClick);
            this.LBL_Town.MouseEnter += new System.EventHandler(this.LBL_Team_MouseEnter);
            this.LBL_Town.MouseLeave += new System.EventHandler(this.LBL_Team_MouseLeave);
            // 
            // TB_Town
            // 
            this.TB_Town.BackColor = System.Drawing.SystemColors.Window;
            this.TB_Town.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Town.Location = new System.Drawing.Point(597, 64);
            this.TB_Town.Name = "TB_Town";
            this.TB_Town.Size = new System.Drawing.Size(100, 20);
            this.TB_Town.TabIndex = 9;
            this.TB_Town.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Town_KeyDown);
            this.TB_Town.Leave += new System.EventHandler(this.TB_Town_Leave);
            this.TB_Town.MouseEnter += new System.EventHandler(this.TB_Team_MouseEnter);
            this.TB_Town.MouseLeave += new System.EventHandler(this.TB_Town_MouseLeave);
            // 
            // LBL_Division
            // 
            this.LBL_Division.AutoSize = true;
            this.LBL_Division.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Division.Location = new System.Drawing.Point(12, 64);
            this.LBL_Division.Name = "LBL_Division";
            this.LBL_Division.Size = new System.Drawing.Size(92, 27);
            this.LBL_Division.TabIndex = 6;
            this.LBL_Division.Text = "Division";
            this.LBL_Division.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Division.Click += new System.EventHandler(this.LBL_Division_Click);
            this.LBL_Division.MouseEnter += new System.EventHandler(this.LBL_Division_MouseEnter);
            this.LBL_Division.MouseLeave += new System.EventHandler(this.LBL_Division_MouseLeave);
            // 
            // CBX_Division
            // 
            this.CBX_Division.FormattingEnabled = true;
            this.CBX_Division.Location = new System.Drawing.Point(110, 64);
            this.CBX_Division.Name = "CBX_Division";
            this.CBX_Division.Size = new System.Drawing.Size(121, 21);
            this.CBX_Division.TabIndex = 10;
            this.CBX_Division.SelectedIndexChanged += new System.EventHandler(this.CBX_Division_SelectedIndexChanged);
            this.CBX_Division.MouseEnter += new System.EventHandler(this.CBX_Division_MouseEnter);
            this.CBX_Division.MouseLeave += new System.EventHandler(this.CBX_Division_MouseLeave);
            // 
            // Team_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 671);
            this.Controls.Add(this.CBX_Division);
            this.Controls.Add(this.TB_Town);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LBL_Town);
            this.Controls.Add(this.LBL_String);
            this.Controls.Add(this.LBL_Division);
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
            this.SizeChanged += new System.EventHandler(this.Team_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Players)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SL_TeamTips;
        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label LBL_String;
        private System.Windows.Forms.Label LBL_Town;
        private System.Windows.Forms.TextBox TB_Town;
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> 4ca4a0bf9cf69c97b661b8d1bb902cdb63344a1b
=======
>>>>>>> 4ca4a0bf9cf69c97b661b8d1bb902cdb63344a1b
        private System.Windows.Forms.Label LBL_Division;
        private System.Windows.Forms.ComboBox CBX_Division;

    }
}