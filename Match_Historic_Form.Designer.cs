namespace TP_Final
{
    partial class Match_Historic_Form
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
            this.DGV_Historic = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FB_Ok = new FlashButton.FlashButton();
            this.FB_Edit_Match = new FlashButton.FlashButton();
            this.FB_Remove_Match = new FlashButton.FlashButton();
            this.FB_Add_Match = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Historic
            // 
            this.DGV_Historic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Historic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Historic.Location = new System.Drawing.Point(12, 49);
            this.DGV_Historic.Name = "DGV_Historic";
            this.DGV_Historic.Size = new System.Drawing.Size(765, 285);
            this.DGV_Historic.TabIndex = 0;
            this.DGV_Historic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Historic_CellContentClick);
            this.DGV_Historic.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Historic_RowHeaderMouseClick);
            this.DGV_Historic.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Historic_RowHeaderMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.FB_Ok);
            this.panel1.Controls.Add(this.FB_Edit_Match);
            this.panel1.Controls.Add(this.FB_Remove_Match);
            this.panel1.Controls.Add(this.FB_Add_Match);
            this.panel1.Location = new System.Drawing.Point(12, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 66);
            this.panel1.TabIndex = 2;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
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
            this.FB_Ok.Location = new System.Drawing.Point(724, 16);
            this.FB_Ok.Name = "FB_Ok";
            this.FB_Ok.Size = new System.Drawing.Size(38, 36);
            this.FB_Ok.TabIndex = 10;
            this.FB_Ok.Click += new System.EventHandler(this.FB_Ok_Click);
            // 
            // FB_Edit_Match
            // 
            this.FB_Edit_Match.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Edit_Match.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Match.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Edit_Match.ImageClick = global::TP_Final.Properties.Resources.ICON_Editer_Click;
            this.FB_Edit_Match.ImageDisable = global::TP_Final.Properties.Resources.ICON_Editer_Disable;
            this.FB_Edit_Match.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Match.ImageOver = global::TP_Final.Properties.Resources.ICON_Editer_Survol;
            this.FB_Edit_Match.Location = new System.Drawing.Point(102, 23);
            this.FB_Edit_Match.Name = "FB_Edit_Match";
            this.FB_Edit_Match.Size = new System.Drawing.Size(28, 26);
            this.FB_Edit_Match.TabIndex = 9;
            this.FB_Edit_Match.Click += new System.EventHandler(this.FB_Edit_Match_Click);
            // 
            // FB_Remove_Match
            // 
            this.FB_Remove_Match.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Remove_Match.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Remove_Match.ImageClick = global::TP_Final.Properties.Resources.Delete_Click;
            this.FB_Remove_Match.ImageDisable = global::TP_Final.Properties.Resources.Delete_Disable;
            this.FB_Remove_Match.ImageNeutral = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Remove_Match.ImageOver = global::TP_Final.Properties.Resources.Delete_Over;
            this.FB_Remove_Match.Location = new System.Drawing.Point(37, 16);
            this.FB_Remove_Match.Name = "FB_Remove_Match";
            this.FB_Remove_Match.Size = new System.Drawing.Size(28, 33);
            this.FB_Remove_Match.TabIndex = 7;
            this.FB_Remove_Match.Click += new System.EventHandler(this.FB_Remove_Match_Click);
            // 
            // FB_Add_Match
            // 
            this.FB_Add_Match.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Match.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Add_Match.ImageClick = global::TP_Final.Properties.Resources.ICON_Ajouter_Click;
            this.FB_Add_Match.ImageDisable = global::TP_Final.Properties.Resources.ICON_Ajouter_Disable;
            this.FB_Add_Match.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Match.ImageOver = global::TP_Final.Properties.Resources.ICON_Ajouter_Over;
            this.FB_Add_Match.Location = new System.Drawing.Point(3, 16);
            this.FB_Add_Match.Name = "FB_Add_Match";
            this.FB_Add_Match.Size = new System.Drawing.Size(28, 33);
            this.FB_Add_Match.TabIndex = 8;
            this.FB_Add_Match.Click += new System.EventHandler(this.FB_Add_Match_Click);
            // 
            // Match_Historic_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Historic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(805, 456);
            this.Name = "Match_Historic_Form";
            this.Text = "Historique des matchs";
            this.Load += new System.EventHandler(this.Match_Historic_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Historic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private FlashButton.FlashButton FB_Remove_Match;
        private FlashButton.FlashButton FB_Add_Match;
        private FlashButton.FlashButton FB_Edit_Match;
        private FlashButton.FlashButton FB_Ok;
    }
}