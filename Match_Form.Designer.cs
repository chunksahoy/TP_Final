namespace TP_Final
{
    partial class Match_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Home = new System.Windows.Forms.DataGridView();
            this.DGV_Visitor = new System.Windows.Forms.DataGridView();
            this.PN_Visitor = new System.Windows.Forms.Panel();
            this.LBL_Visitor = new System.Windows.Forms.Label();
            this.PN_RVis_Win = new System.Windows.Forms.Panel();
            this.PN_LVis_Win = new System.Windows.Forms.Panel();
            this.PN_Home = new System.Windows.Forms.Panel();
            this.LBL_Home = new System.Windows.Forms.Label();
            this.PN_RHome_Win = new System.Windows.Forms.Panel();
            this.PN_LHome_Win = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LBL_Receveur = new System.Windows.Forms.Label();
            this.LBL_Visiteur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_Stadium = new System.Windows.Forms.Label();
            this.LBL_Score_Home = new System.Windows.Forms.Label();
            this.LBL_Score_Visitor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FB_Stats = new FlashButton.FlashButton();
            this.PN_Versus = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Visitor)).BeginInit();
            this.PN_Visitor.SuspendLayout();
            this.PN_Home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
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
            // DGV_Home
            // 
            this.DGV_Home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV_Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Home.Location = new System.Drawing.Point(51, 202);
            this.DGV_Home.Name = "DGV_Home";
            this.DGV_Home.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Home.Size = new System.Drawing.Size(330, 301);
            this.DGV_Home.TabIndex = 1;
            // 
            // DGV_Visitor
            // 
            this.DGV_Visitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Visitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Visitor.Location = new System.Drawing.Point(678, 202);
            this.DGV_Visitor.Name = "DGV_Visitor";
            this.DGV_Visitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Visitor.Size = new System.Drawing.Size(330, 301);
            this.DGV_Visitor.TabIndex = 1;
            // 
            // PN_Visitor
            // 
            this.PN_Visitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Visitor.BackColor = System.Drawing.Color.White;
            this.PN_Visitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Visitor.Controls.Add(this.LBL_Visitor);
            this.PN_Visitor.Controls.Add(this.PN_RVis_Win);
            this.PN_Visitor.Controls.Add(this.PN_LVis_Win);
            this.PN_Visitor.Location = new System.Drawing.Point(678, 104);
            this.PN_Visitor.Name = "PN_Visitor";
            this.PN_Visitor.Size = new System.Drawing.Size(330, 65);
            this.PN_Visitor.TabIndex = 2;
            // 
            // LBL_Visitor
            // 
            this.LBL_Visitor.AutoSize = true;
            this.LBL_Visitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Visitor.Location = new System.Drawing.Point(128, 20);
            this.LBL_Visitor.Name = "LBL_Visitor";
            this.LBL_Visitor.Size = new System.Drawing.Size(84, 25);
            this.LBL_Visitor.TabIndex = 4;
            this.LBL_Visitor.Text = "Visiteur";
            // 
            // PN_RVis_Win
            // 
            this.PN_RVis_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_RVis_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_RVis_Win.Location = new System.Drawing.Point(278, 8);
            this.PN_RVis_Win.Name = "PN_RVis_Win";
            this.PN_RVis_Win.Size = new System.Drawing.Size(49, 48);
            this.PN_RVis_Win.TabIndex = 3;
            // 
            // PN_LVis_Win
            // 
            this.PN_LVis_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_LVis_Win.Location = new System.Drawing.Point(3, 8);
            this.PN_LVis_Win.Name = "PN_LVis_Win";
            this.PN_LVis_Win.Size = new System.Drawing.Size(49, 48);
            this.PN_LVis_Win.TabIndex = 3;
            // 
            // PN_Home
            // 
            this.PN_Home.BackColor = System.Drawing.Color.White;
            this.PN_Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Home.Controls.Add(this.LBL_Home);
            this.PN_Home.Controls.Add(this.PN_RHome_Win);
            this.PN_Home.Controls.Add(this.PN_LHome_Win);
            this.PN_Home.Location = new System.Drawing.Point(51, 104);
            this.PN_Home.Name = "PN_Home";
            this.PN_Home.Size = new System.Drawing.Size(330, 65);
            this.PN_Home.TabIndex = 3;
            // 
            // LBL_Home
            // 
            this.LBL_Home.AutoSize = true;
            this.LBL_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Home.Location = new System.Drawing.Point(118, 20);
            this.LBL_Home.Name = "LBL_Home";
            this.LBL_Home.Size = new System.Drawing.Size(104, 25);
            this.LBL_Home.TabIndex = 4;
            this.LBL_Home.Text = "Receveur";
            // 
            // PN_RHome_Win
            // 
            this.PN_RHome_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_RHome_Win.Location = new System.Drawing.Point(278, 8);
            this.PN_RHome_Win.Name = "PN_RHome_Win";
            this.PN_RHome_Win.Size = new System.Drawing.Size(49, 48);
            this.PN_RHome_Win.TabIndex = 3;
            // 
            // PN_LHome_Win
            // 
            this.PN_LHome_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_LHome_Win.Location = new System.Drawing.Point(3, 8);
            this.PN_LHome_Win.Name = "PN_LHome_Win";
            this.PN_LHome_Win.Size = new System.Drawing.Size(49, 48);
            this.PN_LHome_Win.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Location = new System.Drawing.Point(0, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LBL_Receveur
            // 
            this.LBL_Receveur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Receveur.AutoSize = true;
            this.LBL_Receveur.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Receveur.Location = new System.Drawing.Point(184, 179);
            this.LBL_Receveur.Name = "LBL_Receveur";
            this.LBL_Receveur.Size = new System.Drawing.Size(60, 20);
            this.LBL_Receveur.TabIndex = 6;
            this.LBL_Receveur.Text = "Top 3";
            // 
            // LBL_Visiteur
            // 
            this.LBL_Visiteur.AutoSize = true;
            this.LBL_Visiteur.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Visiteur.Location = new System.Drawing.Point(819, 179);
            this.LBL_Visiteur.Name = "LBL_Visiteur";
            this.LBL_Visiteur.Size = new System.Drawing.Size(60, 20);
            this.LBL_Visiteur.TabIndex = 6;
            this.LBL_Visiteur.Text = "Top 3";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LBL_Stadium);
            this.panel1.Controls.Add(this.LBL_Score_Home);
            this.panel1.Controls.Add(this.LBL_Score_Visitor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(431, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 94);
            this.panel1.TabIndex = 8;
            // 
            // LBL_Stadium
            // 
            this.LBL_Stadium.AutoSize = true;
            this.LBL_Stadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Stadium.Location = new System.Drawing.Point(66, 46);
            this.LBL_Stadium.Name = "LBL_Stadium";
            this.LBL_Stadium.Size = new System.Drawing.Size(71, 20);
            this.LBL_Stadium.TabIndex = 2;
            this.LBL_Stadium.Text = "Montréal";
            this.LBL_Stadium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Score_Home
            // 
            this.LBL_Score_Home.AutoSize = true;
            this.LBL_Score_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Score_Home.Location = new System.Drawing.Point(32, 12);
            this.LBL_Score_Home.Name = "LBL_Score_Home";
            this.LBL_Score_Home.Size = new System.Drawing.Size(24, 25);
            this.LBL_Score_Home.TabIndex = 1;
            this.LBL_Score_Home.Text = "0";
            this.LBL_Score_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Score_Visitor
            // 
            this.LBL_Score_Visitor.AutoSize = true;
            this.LBL_Score_Visitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Score_Visitor.Location = new System.Drawing.Point(150, 12);
            this.LBL_Score_Visitor.Name = "LBL_Score_Visitor";
            this.LBL_Score_Visitor.Size = new System.Drawing.Size(24, 25);
            this.LBL_Score_Visitor.TabIndex = 1;
            this.LBL_Score_Visitor.Text = "0";
            this.LBL_Score_Visitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "-";
            // 
            // FB_Stats
            // 
            this.FB_Stats.BackgroundImage = global::TP_Final.Properties.Resources.StraightLines_Neutral;
            this.FB_Stats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Stats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FB_Stats.ImageClick = global::TP_Final.Properties.Resources.StraightLines_Click;
            this.FB_Stats.ImageDisable = null;
            this.FB_Stats.ImageNeutral = global::TP_Final.Properties.Resources.StraightLines_Neutral;
            this.FB_Stats.ImageOver = global::TP_Final.Properties.Resources.StraightLines_Over;
            this.FB_Stats.Location = new System.Drawing.Point(479, 389);
            this.FB_Stats.Name = "FB_Stats";
            this.FB_Stats.Size = new System.Drawing.Size(111, 95);
            this.FB_Stats.TabIndex = 7;
            this.FB_Stats.Click += new System.EventHandler(this.FB_Stats_Click);
            // 
            // PN_Versus
            // 
            this.PN_Versus.BackgroundImage = global::TP_Final.Properties.Resources.Versus_Symbol;
            this.PN_Versus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_Versus.Location = new System.Drawing.Point(431, 202);
            this.PN_Versus.Name = "PN_Versus";
            this.PN_Versus.Size = new System.Drawing.Size(200, 181);
            this.PN_Versus.TabIndex = 4;
            // 
            // Match_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FB_Stats);
            this.Controls.Add(this.LBL_Visiteur);
            this.Controls.Add(this.LBL_Receveur);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PN_Versus);
            this.Controls.Add(this.PN_Home);
            this.Controls.Add(this.PN_Visitor);
            this.Controls.Add(this.DGV_Visitor);
            this.Controls.Add(this.DGV_Home);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1083, 567);
            this.Name = "Match_Form";
            this.Load += new System.EventHandler(this.Match_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Visitor)).EndInit();
            this.PN_Visitor.ResumeLayout(false);
            this.PN_Visitor.PerformLayout();
            this.PN_Home.ResumeLayout(false);
            this.PN_Home.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV_Home;
        private System.Windows.Forms.DataGridView DGV_Visitor;
        private System.Windows.Forms.Panel PN_Visitor;
        private System.Windows.Forms.Panel PN_RVis_Win;
        private System.Windows.Forms.Panel PN_LVis_Win;
        private System.Windows.Forms.Panel PN_Home;
        private System.Windows.Forms.Panel PN_RHome_Win;
        private System.Windows.Forms.Panel PN_LHome_Win;
        private System.Windows.Forms.Panel PN_Versus;
        private System.Windows.Forms.Label LBL_Visitor;
        private System.Windows.Forms.Label LBL_Home;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label LBL_Receveur;
        private System.Windows.Forms.Label LBL_Visiteur;
        private FlashButton.FlashButton FB_Stats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Score_Home;
        private System.Windows.Forms.Label LBL_Score_Visitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_Stadium;
    }
}