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
            this.SL_Game = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBL_Receveur = new System.Windows.Forms.Label();
            this.LBL_Visiteur = new System.Windows.Forms.Label();
            this.PN_Display = new System.Windows.Forms.Panel();
            this.PN_Score = new System.Windows.Forms.Panel();
            this.LBL_Date = new System.Windows.Forms.Label();
            this.LBL_Stadium = new System.Windows.Forms.Label();
            this.LBL_Score_Home = new System.Windows.Forms.Label();
            this.LBL_Score_Visitor = new System.Windows.Forms.Label();
            this.LBL_Space = new System.Windows.Forms.Label();
            this.FB_Stats = new FlashButton.FlashButton();
            this.PN_Versus = new System.Windows.Forms.Panel();
            this.FB_Edit_Home = new FlashButton.FlashButton();
            this.FB_Edit_Visitor = new FlashButton.FlashButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Visitor)).BeginInit();
            this.PN_Visitor.SuspendLayout();
            this.PN_Home.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.PN_Display.SuspendLayout();
            this.PN_Score.SuspendLayout();
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
            this.DGV_Home.AllowUserToAddRows = false;
            this.DGV_Home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV_Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Home.Location = new System.Drawing.Point(12, 202);
            this.DGV_Home.Name = "DGV_Home";
            this.DGV_Home.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Home.Size = new System.Drawing.Size(413, 301);
            this.DGV_Home.TabIndex = 1;
            this.DGV_Home.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Home_RowHeaderMouseDoubleClick);
            this.DGV_Home.MouseEnter += new System.EventHandler(this.DGV_Home_MouseEnter);
            this.DGV_Home.MouseLeave += new System.EventHandler(this.DGV_Home_MouseLeave);
            // 
            // DGV_Visitor
            // 
            this.DGV_Visitor.AllowUserToAddRows = false;
            this.DGV_Visitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Visitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Visitor.Location = new System.Drawing.Point(637, 202);
            this.DGV_Visitor.Name = "DGV_Visitor";
            this.DGV_Visitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Visitor.Size = new System.Drawing.Size(418, 301);
            this.DGV_Visitor.TabIndex = 1;
            this.DGV_Visitor.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Visitor_RowHeaderMouseDoubleClick);
            this.DGV_Visitor.MouseEnter += new System.EventHandler(this.DGV_Visitor_MouseEnter);
            this.DGV_Visitor.MouseLeave += new System.EventHandler(this.DGV_Visitor_MouseLeave);
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
            this.PN_Visitor.Location = new System.Drawing.Point(637, 104);
            this.PN_Visitor.Name = "PN_Visitor";
            this.PN_Visitor.Size = new System.Drawing.Size(418, 65);
            this.PN_Visitor.TabIndex = 2;
            this.PN_Visitor.MouseEnter += new System.EventHandler(this.PN_Visitor_MouseEnter);
            this.PN_Visitor.MouseLeave += new System.EventHandler(this.PN_Visitor_MouseLeave);
            // 
            // LBL_Visitor
            // 
            this.LBL_Visitor.AutoSize = true;
            this.LBL_Visitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Visitor.Location = new System.Drawing.Point(171, 20);
            this.LBL_Visitor.Name = "LBL_Visitor";
            this.LBL_Visitor.Size = new System.Drawing.Size(84, 25);
            this.LBL_Visitor.TabIndex = 4;
            this.LBL_Visitor.Text = "Visiteur";
            this.LBL_Visitor.MouseEnter += new System.EventHandler(this.PN_Visitor_MouseEnter);
            this.LBL_Visitor.MouseLeave += new System.EventHandler(this.PN_Visitor_MouseLeave);
            // 
            // PN_RVis_Win
            // 
            this.PN_RVis_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_RVis_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_RVis_Win.Location = new System.Drawing.Point(366, 8);
            this.PN_RVis_Win.Name = "PN_RVis_Win";
            this.PN_RVis_Win.Size = new System.Drawing.Size(49, 48);
            this.PN_RVis_Win.TabIndex = 3;
            this.PN_RVis_Win.MouseEnter += new System.EventHandler(this.PN_Visitor_MouseEnter);
            this.PN_RVis_Win.MouseLeave += new System.EventHandler(this.PN_Visitor_MouseLeave);
            // 
            // PN_LVis_Win
            // 
            this.PN_LVis_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_LVis_Win.Location = new System.Drawing.Point(3, 8);
            this.PN_LVis_Win.Name = "PN_LVis_Win";
            this.PN_LVis_Win.Size = new System.Drawing.Size(49, 48);
            this.PN_LVis_Win.TabIndex = 3;
            this.PN_LVis_Win.MouseEnter += new System.EventHandler(this.PN_Visitor_MouseEnter);
            this.PN_LVis_Win.MouseLeave += new System.EventHandler(this.PN_Visitor_MouseLeave);
            // 
            // PN_Home
            // 
            this.PN_Home.BackColor = System.Drawing.Color.White;
            this.PN_Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Home.Controls.Add(this.LBL_Home);
            this.PN_Home.Controls.Add(this.PN_RHome_Win);
            this.PN_Home.Controls.Add(this.PN_LHome_Win);
            this.PN_Home.Location = new System.Drawing.Point(12, 104);
            this.PN_Home.Name = "PN_Home";
            this.PN_Home.Size = new System.Drawing.Size(413, 65);
            this.PN_Home.TabIndex = 3;
            this.PN_Home.MouseEnter += new System.EventHandler(this.PN_Home_MouseEnter);
            this.PN_Home.MouseLeave += new System.EventHandler(this.PN_Home_MouseLeave);
            // 
            // LBL_Home
            // 
            this.LBL_Home.AutoSize = true;
            this.LBL_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.LBL_Home.Location = new System.Drawing.Point(154, 20);
=======
            this.LBL_Home.Location = new System.Drawing.Point(121, 20);
>>>>>>> 74baf69945f820089f7e3d369cd6a28acdcaa5b9
            this.LBL_Home.Name = "LBL_Home";
            this.LBL_Home.Size = new System.Drawing.Size(104, 25);
            this.LBL_Home.TabIndex = 4;
            this.LBL_Home.Text = "Receveur";
            this.LBL_Home.MouseEnter += new System.EventHandler(this.PN_Home_MouseEnter);
            this.LBL_Home.MouseLeave += new System.EventHandler(this.PN_Home_MouseLeave);
            // 
            // PN_RHome_Win
            // 
            this.PN_RHome_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_RHome_Win.Location = new System.Drawing.Point(359, 8);
            this.PN_RHome_Win.Name = "PN_RHome_Win";
            this.PN_RHome_Win.Size = new System.Drawing.Size(49, 48);
            this.PN_RHome_Win.TabIndex = 3;
            this.PN_RHome_Win.MouseEnter += new System.EventHandler(this.PN_Home_MouseEnter);
            this.PN_RHome_Win.MouseLeave += new System.EventHandler(this.PN_Home_MouseLeave);
            // 
            // PN_LHome_Win
            // 
            this.PN_LHome_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_LHome_Win.Location = new System.Drawing.Point(3, 8);
            this.PN_LHome_Win.Name = "PN_LHome_Win";
            this.PN_LHome_Win.Size = new System.Drawing.Size(49, 48);
            this.PN_LHome_Win.TabIndex = 3;
            this.PN_LHome_Win.MouseEnter += new System.EventHandler(this.PN_Home_MouseEnter);
            this.PN_LHome_Win.MouseLeave += new System.EventHandler(this.PN_Home_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SL_Game});
            this.statusStrip1.Location = new System.Drawing.Point(0, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SL_Game
            // 
            this.SL_Game.Name = "SL_Game";
            this.SL_Game.Size = new System.Drawing.Size(0, 17);
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
            // PN_Display
            // 
            this.PN_Display.BackColor = System.Drawing.SystemColors.Window;
            this.PN_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Display.Controls.Add(this.PN_Score);
            this.PN_Display.Controls.Add(this.LBL_Date);
            this.PN_Display.Controls.Add(this.LBL_Stadium);
<<<<<<< HEAD
            this.PN_Display.Cursor = System.Windows.Forms.Cursors.Hand;
=======
            this.PN_Display.Controls.Add(this.LBL_Score_Home);
            this.PN_Display.Controls.Add(this.LBL_Score_Visitor);
            this.PN_Display.Controls.Add(this.LBL_Space);
            this.PN_Display.Cursor = System.Windows.Forms.Cursors.Hand;

>>>>>>> 74baf69945f820089f7e3d369cd6a28acdcaa5b9
            this.PN_Display.Location = new System.Drawing.Point(431, 67);
            this.PN_Display.Name = "PN_Display";
            this.PN_Display.Size = new System.Drawing.Size(200, 102);
            this.PN_Display.TabIndex = 8;
            this.PN_Display.Click += new System.EventHandler(this.PN_Display_Click);
            this.PN_Display.MouseEnter += new System.EventHandler(this.PN_Display_MouseEnter);
            this.PN_Display.MouseLeave += new System.EventHandler(this.PN_Display_MouseLeave);
            // 
            // PN_Score
            // 
            this.PN_Score.Controls.Add(this.LBL_Score_Home);
            this.PN_Score.Controls.Add(this.LBL_Score_Visitor);
            this.PN_Score.Controls.Add(this.LBL_Space);
            this.PN_Score.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Score.Location = new System.Drawing.Point(0, 0);
            this.PN_Score.Name = "PN_Score";
            this.PN_Score.Size = new System.Drawing.Size(198, 42);
            this.PN_Score.TabIndex = 9;
            this.PN_Score.Click += new System.EventHandler(this.PN_Score_Click);
            this.PN_Score.MouseEnter += new System.EventHandler(this.PN_Score_MouseEnter);
            this.PN_Score.MouseLeave += new System.EventHandler(this.PN_Score_MouseLeave);
<<<<<<< HEAD
            // 
            // LBL_Date
            // 
            this.LBL_Date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_Date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LBL_Date.Location = new System.Drawing.Point(0, 87);
=======
            this.LBL_Date.AutoSize = true;
            this.LBL_Date.Location = new System.Drawing.Point(67, 80);
>>>>>>> 74baf69945f820089f7e3d369cd6a28acdcaa5b9
            this.LBL_Date.Name = "LBL_Date";
            this.LBL_Date.Size = new System.Drawing.Size(198, 13);
            this.LBL_Date.TabIndex = 3;
            this.LBL_Date.Text = "Date";
            this.LBL_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Date.Click += new System.EventHandler(this.LBL_Date_Click);
            this.LBL_Date.MouseEnter += new System.EventHandler(this.LBL_Date_MouseEnter);
            this.LBL_Date.MouseLeave += new System.EventHandler(this.LBL_Date_MouseLeave);
            // 
            // LBL_Stadium
            // 
<<<<<<< HEAD
            this.LBL_Stadium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Stadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Stadium.Location = new System.Drawing.Point(0, 0);
            this.LBL_Stadium.Name = "LBL_Stadium";
            this.LBL_Stadium.Size = new System.Drawing.Size(198, 100);
            this.LBL_Stadium.TabIndex = 14;
            this.LBL_Stadium.Text = "Stade";
            this.LBL_Stadium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Stadium.Click += new System.EventHandler(this.LBL_Stadium_Click);
            this.LBL_Stadium.MouseEnter += new System.EventHandler(this.LBL_Stadium_MouseEnter);
            this.LBL_Stadium.MouseLeave += new System.EventHandler(this.LBL_Stadium_MouseLeave);
=======
            //this.LBL_Stadium.AutoSize = true;
            //this.LBL_Stadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.LBL_Stadium.Location = new System.Drawing.Point(66, 46);
            //this.LBL_Stadium.Name = "LBL_Stadium";
            //this.LBL_Stadium.Size = new System.Drawing.Size(71, 20);
            //this.LBL_Stadium.TabIndex = 2;
            //this.LBL_Stadium.Text = "Montréal";
            //this.LBL_Stadium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.LBL_Stadium.MouseEnter += new System.EventHandler(this.PN_Display_MouseEnter);
            //this.LBL_Stadium.MouseLeave += new System.EventHandler(this.PN_Display_MouseLeave);
>>>>>>> 74baf69945f820089f7e3d369cd6a28acdcaa5b9
            // 
            // LBL_Score_Home
            // 
            this.LBL_Score_Home.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBL_Score_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Score_Home.Location = new System.Drawing.Point(0, 0);
            this.LBL_Score_Home.Name = "LBL_Score_Home";
            this.LBL_Score_Home.Size = new System.Drawing.Size(45, 42);
            this.LBL_Score_Home.TabIndex = 15;
            this.LBL_Score_Home.Text = "0";
            this.LBL_Score_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Score_Visitor
            // 
            this.LBL_Score_Visitor.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBL_Score_Visitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Score_Visitor.Location = new System.Drawing.Point(156, 0);
            this.LBL_Score_Visitor.Name = "LBL_Score_Visitor";
            this.LBL_Score_Visitor.Size = new System.Drawing.Size(42, 42);
            this.LBL_Score_Visitor.TabIndex = 16;
            this.LBL_Score_Visitor.Text = "0";
            this.LBL_Score_Visitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Space
            // 
<<<<<<< HEAD
            this.LBL_Space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Space.Location = new System.Drawing.Point(0, 0);
=======
            this.LBL_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Space.Location = new System.Drawing.Point(93, 9);
>>>>>>> 74baf69945f820089f7e3d369cd6a28acdcaa5b9
            this.LBL_Space.Name = "LBL_Space";
            this.LBL_Space.Size = new System.Drawing.Size(198, 42);
            this.LBL_Space.TabIndex = 17;
            this.LBL_Space.Text = "-";
            this.LBL_Space.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
<<<<<<< HEAD
=======
            // LBL_Date
            // 
            this.LBL_Date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_Date.Location = new System.Drawing.Point(0, 87);
            this.LBL_Date.Name = "LBL_Date";
            this.LBL_Date.Size = new System.Drawing.Size(198, 13);
            this.LBL_Date.TabIndex = 3;
            this.LBL_Date.Text = "Date";
            this.LBL_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Date.Click += new System.EventHandler(this.LBL_Date_Click);
            this.LBL_Date.MouseEnter += new System.EventHandler(this.LBL_Date_MouseEnter);
            this.LBL_Date.MouseLeave += new System.EventHandler(this.LBL_Date_MouseLeave);
            // 
            // LBL_Stadium
            // 
            this.LBL_Stadium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Stadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Stadium.Location = new System.Drawing.Point(0, 0);
            this.LBL_Stadium.Name = "LBL_Stadium";
            this.LBL_Stadium.Size = new System.Drawing.Size(198, 100);
            this.LBL_Stadium.TabIndex = 2;
            this.LBL_Stadium.Text = "Stade";
            this.LBL_Stadium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Stadium.Click += new System.EventHandler(this.LBL_Stadium_Click);
            this.LBL_Stadium.MouseEnter += new System.EventHandler(this.LBL_Stadium_MouseEnter);
            this.LBL_Stadium.MouseLeave += new System.EventHandler(this.LBL_Stadium_MouseLeave);

            this.LBL_Space.AutoSize = true;
            this.LBL_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Space.Location = new System.Drawing.Point(97, 12);
            this.LBL_Space.Name = "label3";
            this.LBL_Space.Size = new System.Drawing.Size(19, 25);
            this.LBL_Space.TabIndex = 0;
            this.LBL_Space.Text = "-";
            this.LBL_Space.MouseEnter += new System.EventHandler(this.PN_Display_MouseEnter);
            this.LBL_Space.MouseLeave += new System.EventHandler(this.PN_Display_MouseLeave);
            // 
>>>>>>> 74baf69945f820089f7e3d369cd6a28acdcaa5b9
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
            this.FB_Stats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FB_Stats_MouseClick);
            this.FB_Stats.MouseEnter += new System.EventHandler(this.FB_Stats_MouseEnter);
            this.FB_Stats.MouseLeave += new System.EventHandler(this.FB_Stats_MouseLeave);
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
            // FB_Edit_Home
            // 
            this.FB_Edit_Home.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Edit_Home.ImageClick = global::TP_Final.Properties.Resources.ICON_Editer_Click;
            this.FB_Edit_Home.ImageDisable = global::TP_Final.Properties.Resources.ICON_Editer_Disable;
            this.FB_Edit_Home.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Home.ImageOver = global::TP_Final.Properties.Resources.ICON_Editer_Survol;
            this.FB_Edit_Home.Location = new System.Drawing.Point(12, 509);
            this.FB_Edit_Home.Name = "FB_Edit_Home";
            this.FB_Edit_Home.Size = new System.Drawing.Size(39, 36);
            this.FB_Edit_Home.TabIndex = 9;
            this.FB_Edit_Home.Click += new System.EventHandler(this.FB_Edit_Home_Click);
            // 
            // FB_Edit_Visitor
            // 
            this.FB_Edit_Visitor.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Visitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Edit_Visitor.ImageClick = global::TP_Final.Properties.Resources.ICON_Editer_Click;
            this.FB_Edit_Visitor.ImageDisable = global::TP_Final.Properties.Resources.ICON_Editer_Disable;
            this.FB_Edit_Visitor.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Visitor.ImageOver = global::TP_Final.Properties.Resources.ICON_Editer_Survol;
            this.FB_Edit_Visitor.Location = new System.Drawing.Point(1016, 509);
            this.FB_Edit_Visitor.Name = "FB_Edit_Visitor";
            this.FB_Edit_Visitor.Size = new System.Drawing.Size(39, 36);
            this.FB_Edit_Visitor.TabIndex = 9;
            this.FB_Edit_Visitor.Click += new System.EventHandler(this.FB_Edit_Visitor_Click);
            // 
            // Match_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 548);
            this.Controls.Add(this.FB_Edit_Visitor);
            this.Controls.Add(this.FB_Edit_Home);
            this.Controls.Add(this.PN_Display);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1083, 586);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1083, 586);
            this.Name = "Match_Form";
            this.Load += new System.EventHandler(this.Match_Form_Load);
            this.SizeChanged += new System.EventHandler(this.Match_Form_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Visitor)).EndInit();
            this.PN_Visitor.ResumeLayout(false);
            this.PN_Visitor.PerformLayout();
            this.PN_Home.ResumeLayout(false);
            this.PN_Home.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PN_Display.ResumeLayout(false);
            this.PN_Score.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PN_Display;
        private System.Windows.Forms.Label LBL_Score_Home;
        private System.Windows.Forms.Label LBL_Score_Visitor;
        private System.Windows.Forms.Label LBL_Space;
        private System.Windows.Forms.Label LBL_Stadium;
        private System.Windows.Forms.Label LBL_Date;
<<<<<<< HEAD

        private System.Windows.Forms.Panel PN_Score;
        private FlashButton.FlashButton FB_Edit_Home;
        private FlashButton.FlashButton FB_Edit_Visitor;

        private System.Windows.Forms.ToolStripStatusLabel SL_Game;

=======
        private System.Windows.Forms.Panel PN_Score;
        private FlashButton.FlashButton FB_Edit_Home;
        private FlashButton.FlashButton FB_Edit_Visitor;
        private System.Windows.Forms.ToolStripStatusLabel SL_Game;
>>>>>>> 74baf69945f820089f7e3d369cd6a28acdcaa5b9
    }
}