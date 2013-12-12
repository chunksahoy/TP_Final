namespace TP_Final
{
    partial class Main_Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Teams = new System.Windows.Forms.DataGridView();
            this.MS_MainForm = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SL_Tips = new System.Windows.Forms.ToolStripStatusLabel();
            this.TB_Search_Player = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FB_Remove_Division = new FlashButton.FlashButton();
            this.FB_Add_Division = new FlashButton.FlashButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FB_Remove_Team = new FlashButton.FlashButton();
            this.FB_Edit_Team = new FlashButton.FlashButton();
            this.FB_Add_Team = new FlashButton.FlashButton();
            this.LBL_Team = new System.Windows.Forms.Label();
            this.LBL_Divisions = new System.Windows.Forms.Label();
            this.LB_Divisions = new System.Windows.Forms.ListBox();
            this.FB_Stars = new FlashButton.FlashButton();
            this.LS_Logos = new Logo_scroller.LogoScroller();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Teams)).BeginInit();
            this.MS_MainForm.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Teams
            // 
            this.DGV_Teams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Teams.Location = new System.Drawing.Point(240, 142);
            this.DGV_Teams.Name = "DGV_Teams";
            this.DGV_Teams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Teams.Size = new System.Drawing.Size(1035, 548);
            this.DGV_Teams.TabIndex = 1;
            this.DGV_Teams.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Teams_CellMouseClick);
            this.DGV_Teams.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Teams_ColumnHeaderMouseClick);
            this.DGV_Teams.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Teams_RowHeaderMouseClick);
            this.DGV_Teams.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Teams_RowHeaderMouseDoubleClick);
            this.DGV_Teams.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.DGV_Teams_RowHeightChanged);
            this.DGV_Teams.MouseEnter += new System.EventHandler(this.DGV_Teams_MouseEnter);
            this.DGV_Teams.MouseLeave += new System.EventHandler(this.DGV_Teams_MouseLeave);
            // 
            // MS_MainForm
            // 
            this.MS_MainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.MS_MainForm.Location = new System.Drawing.Point(0, 0);
            this.MS_MainForm.Name = "MS_MainForm";
            this.MS_MainForm.Size = new System.Drawing.Size(1287, 24);
            this.MS_MainForm.TabIndex = 2;
            this.MS_MainForm.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.ToolTipText = "Cherles aime les poneys";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SL_Tips});
            this.statusStrip1.Location = new System.Drawing.Point(0, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1287, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SL_Tips
            // 
            this.SL_Tips.Name = "SL_Tips";
            this.SL_Tips.Size = new System.Drawing.Size(105, 17);
            this.SL_Tips.Text = "derpiederpthaderp";
            // 
            // TB_Search_Player
            // 
            this.TB_Search_Player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Search_Player.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TB_Search_Player.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TB_Search_Player.Location = new System.Drawing.Point(1060, 24);
            this.TB_Search_Player.Name = "TB_Search_Player";
            this.TB_Search_Player.Size = new System.Drawing.Size(211, 20);
            this.TB_Search_Player.TabIndex = 4;
            this.TB_Search_Player.Text = "Rechercher Joueur";
            this.TB_Search_Player.TextChanged += new System.EventHandler(this.TB_Search_Player_TextChanged);
            this.TB_Search_Player.Enter += new System.EventHandler(this.TB_Search_Player_Enter);
            this.TB_Search_Player.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Search_Player_KeyDown);
            this.TB_Search_Player.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Search_Player_KeyPress);
            this.TB_Search_Player.Leave += new System.EventHandler(this.TB_Search_Player_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.FB_Remove_Division);
            this.panel1.Controls.Add(this.FB_Add_Division);
            this.panel1.Location = new System.Drawing.Point(12, 696);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 43);
            this.panel1.TabIndex = 5;
            // 
            // FB_Remove_Division
            // 
            this.FB_Remove_Division.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Remove_Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Remove_Division.ImageClick = global::TP_Final.Properties.Resources.Delete_Click;
            this.FB_Remove_Division.ImageDisable = global::TP_Final.Properties.Resources.Delete_Disable;
            this.FB_Remove_Division.ImageNeutral = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Remove_Division.ImageOver = global::TP_Final.Properties.Resources.Delete_Over;
            this.FB_Remove_Division.Location = new System.Drawing.Point(181, 3);
            this.FB_Remove_Division.Name = "FB_Remove_Division";
            this.FB_Remove_Division.Size = new System.Drawing.Size(28, 33);
            this.FB_Remove_Division.TabIndex = 5;
            this.FB_Remove_Division.Click += new System.EventHandler(this.FB_Remove_Division_Click);
            this.FB_Remove_Division.MouseEnter += new System.EventHandler(this.FB_Remove_Division_MouseEnter);
            this.FB_Remove_Division.MouseLeave += new System.EventHandler(this.FB_Remove_Division_MouseLeave);
            //// 
            //// FB_Add_Division
            // 
            this.FB_Add_Division.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Add_Division.ImageClick = global::TP_Final.Properties.Resources.ICON_Ajouter_Click;
            this.FB_Add_Division.ImageDisable = global::TP_Final.Properties.Resources.ICON_Ajouter_Disable;
            this.FB_Add_Division.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Division.ImageOver = global::TP_Final.Properties.Resources.ICON_Ajouter_Over;
            this.FB_Add_Division.Location = new System.Drawing.Point(147, 5);
            this.FB_Add_Division.Name = "FB_Add_Division";
            this.FB_Add_Division.Size = new System.Drawing.Size(28, 33);
            this.FB_Add_Division.TabIndex = 6;
            this.FB_Add_Division.Click += new System.EventHandler(this.FB_Add_Division_Click);
            this.FB_Add_Division.MouseEnter += new System.EventHandler(this.FB_Add_Division_MouseEnter);
            this.FB_Add_Division.MouseLeave += new System.EventHandler(this.FB_Add_Division_MouseLeave);
             
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.FB_Remove_Team);
            this.panel2.Controls.Add(this.FB_Edit_Team);
            this.panel2.Controls.Add(this.FB_Add_Team);
            this.panel2.Location = new System.Drawing.Point(1108, 696);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 43);
            this.panel2.TabIndex = 5;
            // 
            // FB_Remove_Team
            // 
            //this.FB_Remove_Team.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            //this.FB_Remove_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.FB_Remove_Team.ImageClick = global::TP_Final.Properties.Resources.Delete_Click;
            //this.FB_Remove_Team.ImageDisable = global::TP_Final.Properties.Resources.Delete_Disable;
            //this.FB_Remove_Team.ImageNeutral = global::TP_Final.Properties.Resources.Delete_Neutral;
            //this.FB_Remove_Team.ImageOver = global::TP_Final.Properties.Resources.Delete_Over;
            //this.FB_Remove_Team.Location = new System.Drawing.Point(134, 3);
            //this.FB_Remove_Team.Name = "FB_Remove_Team";
            //this.FB_Remove_Team.Size = new System.Drawing.Size(28, 33);
            //this.FB_Remove_Team.TabIndex = 7;
            //this.FB_Remove_Team.Click += new System.EventHandler(this.FB_Remove_Team_Click);
            //this.FB_Remove_Team.MouseEnter += new System.EventHandler(this.FB_Remove_Team_MouseEnter);
            //this.FB_Remove_Team.MouseLeave += new System.EventHandler(this.FB_Remove_Team_MouseLeave);
            //// 
            //// FB_Edit_Team
            //// 
            //this.FB_Edit_Team.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            //this.FB_Edit_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.FB_Edit_Team.ImageClick = global::TP_Final.Properties.Resources.ICON_Editer_Click;
            //this.FB_Edit_Team.ImageDisable = global::TP_Final.Properties.Resources.ICON_Editer_Disable;
            //this.FB_Edit_Team.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            //this.FB_Edit_Team.ImageOver = global::TP_Final.Properties.Resources.ICON_Editer_Survol;
            //this.FB_Edit_Team.Location = new System.Drawing.Point(3, 5);
            //this.FB_Edit_Team.Name = "FB_Edit_Team";
            //this.FB_Edit_Team.Size = new System.Drawing.Size(28, 33);
            //this.FB_Edit_Team.TabIndex = 8;
            //this.FB_Edit_Team.Click += new System.EventHandler(this.FB_Edit_Team_Click);
            //this.FB_Edit_Team.MouseEnter += new System.EventHandler(this.FB_Edit_Team_MouseEnter);
            //this.FB_Edit_Team.MouseLeave += new System.EventHandler(this.FB_Edit_Team_MouseLeave);
            // 
            // FB_Add_Team
            // 
            this.FB_Add_Team.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Add_Team.ImageClick = global::TP_Final.Properties.Resources.ICON_Ajouter_Click;
            this.FB_Add_Team.ImageDisable = global::TP_Final.Properties.Resources.ICON_Ajouter_Disable;
            this.FB_Add_Team.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Team.ImageOver = global::TP_Final.Properties.Resources.ICON_Ajouter_Over;
            this.FB_Add_Team.Location = new System.Drawing.Point(100, 3);
            this.FB_Add_Team.Name = "FB_Add_Team";
            this.FB_Add_Team.Size = new System.Drawing.Size(28, 33);
            this.FB_Add_Team.TabIndex = 8;
            this.FB_Add_Team.Click += new System.EventHandler(this.FB_Add_Team_Click);
            this.FB_Add_Team.MouseEnter += new System.EventHandler(this.FB_Add_Team_MouseEnter);
            this.FB_Add_Team.MouseLeave += new System.EventHandler(this.FB_Add_Team_MouseLeave);
            // 
            // LBL_Team
            // 
            this.LBL_Team.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Team.AutoSize = true;
            this.LBL_Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Team.Location = new System.Drawing.Point(699, 114);
            this.LBL_Team.Name = "LBL_Team";
            this.LBL_Team.Size = new System.Drawing.Size(90, 25);
            this.LBL_Team.TabIndex = 7;
            this.LBL_Team.Text = "Équipes";
            // 
            // LBL_Divisions
            // 
            this.LBL_Divisions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Divisions.AutoSize = true;
            this.LBL_Divisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Divisions.Location = new System.Drawing.Point(69, 114);
            this.LBL_Divisions.Name = "LBL_Divisions";
            this.LBL_Divisions.Size = new System.Drawing.Size(99, 25);
            this.LBL_Divisions.TabIndex = 7;
            this.LBL_Divisions.Text = "Divisions";
            // 
            // LB_Divisions
            // 
            this.LB_Divisions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_Divisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Divisions.FormattingEnabled = true;
            this.LB_Divisions.ItemHeight = 25;
            this.LB_Divisions.Location = new System.Drawing.Point(12, 140);
            this.LB_Divisions.Name = "LB_Divisions";
            this.LB_Divisions.Size = new System.Drawing.Size(222, 554);
            this.LB_Divisions.TabIndex = 9;
            this.LB_Divisions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LB_Divisions_MouseClick);
            this.LB_Divisions.SelectedIndexChanged += new System.EventHandler(this.LB_Divisions_SelectedIndexChanged);
            // 
            // FB_Stars
            // 
            this.FB_Stars.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FB_Stars.BackgroundImage = global::TP_Final.Properties.Resources.Star_Neutral;
            this.FB_Stars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Stars.ImageClick = global::TP_Final.Properties.Resources.Star_Click;
            this.FB_Stars.ImageDisable = null;
            this.FB_Stars.ImageNeutral = global::TP_Final.Properties.Resources.Star_Neutral;
            this.FB_Stars.ImageOver = global::TP_Final.Properties.Resources.Star_Over;
            this.FB_Stars.Location = new System.Drawing.Point(692, 695);
            this.FB_Stars.Name = "FB_Stars";
            this.FB_Stars.Size = new System.Drawing.Size(65, 62);
            this.FB_Stars.TabIndex = 10;
            // 

            // LS_Logos

            // FB_Remove_Team
            // 
            this.FB_Remove_Team.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Remove_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Remove_Team.ImageClick = global::TP_Final.Properties.Resources.Delete_Click;
            this.FB_Remove_Team.ImageDisable = global::TP_Final.Properties.Resources.Delete_Disable;
            this.FB_Remove_Team.ImageNeutral = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Remove_Team.ImageOver = global::TP_Final.Properties.Resources.Delete_Over;
            this.FB_Remove_Team.Location = new System.Drawing.Point(134, 3);
            this.FB_Remove_Team.Name = "FB_Remove_Team";
            this.FB_Remove_Team.Size = new System.Drawing.Size(28, 33);
            this.FB_Remove_Team.TabIndex = 7;
            this.FB_Remove_Team.Click += new System.EventHandler(this.FB_Remove_Team_Click);
            this.FB_Remove_Team.MouseEnter += new System.EventHandler(this.FB_Remove_Team_MouseEnter);
            this.FB_Remove_Team.MouseLeave += new System.EventHandler(this.FB_Remove_Team_MouseLeave);
            // 
            // FB_Edit_Team
            // 
            this.FB_Edit_Team.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Edit_Team.ImageClick = global::TP_Final.Properties.Resources.ICON_Editer_Click;
            this.FB_Edit_Team.ImageDisable = global::TP_Final.Properties.Resources.ICON_Editer_Disable;
            this.FB_Edit_Team.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Editer_Neutre;
            this.FB_Edit_Team.ImageOver = global::TP_Final.Properties.Resources.ICON_Editer_Survol;
            this.FB_Edit_Team.Location = new System.Drawing.Point(3, 5);
            this.FB_Edit_Team.Name = "FB_Edit_Team";
            this.FB_Edit_Team.Size = new System.Drawing.Size(28, 33);
            this.FB_Edit_Team.TabIndex = 8;
            this.FB_Edit_Team.Click += new System.EventHandler(this.FB_Edit_Team_Click);
            this.FB_Edit_Team.MouseEnter += new System.EventHandler(this.FB_Edit_Team_MouseEnter);
            this.FB_Edit_Team.MouseLeave += new System.EventHandler(this.FB_Edit_Team_MouseLeave);
            // 
            // FB_Add_Team
            // 
            this.FB_Add_Team.BackgroundImage = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Add_Team.ImageClick = global::TP_Final.Properties.Resources.ICON_Ajouter_Click;
            this.FB_Add_Team.ImageDisable = global::TP_Final.Properties.Resources.ICON_Ajouter_Disable;
            this.FB_Add_Team.ImageNeutral = global::TP_Final.Properties.Resources.ICON_Ajouter_Neutral;
            this.FB_Add_Team.ImageOver = global::TP_Final.Properties.Resources.ICON_Ajouter_Over;
            this.FB_Add_Team.Location = new System.Drawing.Point(100, 3);
            this.FB_Add_Team.Name = "FB_Add_Team";
            this.FB_Add_Team.Size = new System.Drawing.Size(28, 33);
            this.FB_Add_Team.TabIndex = 8;
            this.FB_Add_Team.Click += new System.EventHandler(this.FB_Add_Team_Click);
            this.FB_Add_Team.MouseEnter += new System.EventHandler(this.FB_Add_Team_MouseEnter);
            this.FB_Add_Team.MouseLeave += new System.EventHandler(this.FB_Add_Team_MouseLeave);
            //// 
            //// LV_Divisions
            //// 
            //this.LV_Divisions.Activation = System.Windows.Forms.ItemActivation.OneClick;
            //this.LV_Divisions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            //| System.Windows.Forms.AnchorStyles.Left)));
            //this.LV_Divisions.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.LV_Divisions.HideSelection = false;
            //this.LV_Divisions.Location = new System.Drawing.Point(12, 142);
            //this.LV_Divisions.Name = "LV_Divisions";
            //this.LV_Divisions.Size = new System.Drawing.Size(222, 548);
            //this.LV_Divisions.TabIndex = 6;
            //this.LV_Divisions.UseCompatibleStateImageBehavior = false;
            //this.LV_Divisions.SelectedIndexChanged += new System.EventHandler(this.LV_Divisions_SelectedIndexChanged);
            //this.LV_Divisions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LV_Divisions_MouseClick);
            //this.LV_Divisions.MouseEnter += new System.EventHandler(this.LV_Divisions_MouseEnter);
            //this.LV_Divisions.MouseLeave += new System.EventHandler(this.LV_Divisions_MouseLeave);
            // 
            // FB_Remove_Division
            // 
            //this.FB_Remove_Division.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            //this.FB_Remove_Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.FB_Remove_Division.ImageClick = global::TP_Final.Properties.Resources.Delete_Click;
            //this.FB_Remove_Division.ImageDisable = global::TP_Final.Properties.Resources.Delete_Disable;
            //this.FB_Remove_Division.ImageNeutral = global::TP_Final.Properties.Resources.Delete_Neutral;
            //this.FB_Remove_Division.ImageOver = global::TP_Final.Properties.Resources.Delete_Over;
            //this.FB_Remove_Division.Location = new System.Drawing.Point(181, 3);
            //this.FB_Remove_Division.Name = "FB_Remove_Division";
            //this.FB_Remove_Division.Size = new System.Drawing.Size(28, 33);
            //this.FB_Remove_Division.TabIndex = 5;
            //this.FB_Remove_Division.Click += new System.EventHandler(this.FB_Remove_Division_Click);
            //this.FB_Remove_Division.MouseEnter += new System.EventHandler(this.FB_Remove_Division_MouseEnter);
            //this.FB_Remove_Division.MouseLeave += new System.EventHandler(this.FB_Remove_Division_MouseLeave);
            // 
            // FB_Add_Division

            this.LS_Logos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LS_Logos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LS_Logos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LS_Logos.Location = new System.Drawing.Point(12, 49);
            this.LS_Logos.Name = "LS_Logos";
            this.LS_Logos.NbElements = 8;
            this.LS_Logos.Size = new System.Drawing.Size(1263, 62);
            this.LS_Logos.TabIndex = 8;
            this.LS_Logos.Load += new System.EventHandler(this.LS_Logos_Load);
            this.LS_Logos.Click += new System.EventHandler(this.LS_Logos_Click);
            this.LS_Logos.MouseEnter += new System.EventHandler(this.logoScroller1_MouseEnter);
            this.LS_Logos.MouseLeave += new System.EventHandler(this.logoScroller1_MouseLeave);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 769);
            this.Controls.Add(this.FB_Stars);
            this.Controls.Add(this.LB_Divisions);
            this.Controls.Add(this.LS_Logos);
            this.Controls.Add(this.LBL_Divisions);
            this.Controls.Add(this.LBL_Team);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TB_Search_Player);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DGV_Teams);
            this.Controls.Add(this.MS_MainForm);
            this.MainMenuStrip = this.MS_MainForm;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main_Form";
            this.Text = "Hockey Manager 2013";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.LocationChanged += new System.EventHandler(this.Main_Form_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Main_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Teams)).EndInit();
            this.MS_MainForm.ResumeLayout(false);
            this.MS_MainForm.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Teams;
        private System.Windows.Forms.MenuStrip MS_MainForm;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox TB_Search_Player;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FlashButton.FlashButton FB_Remove_Division;
        private FlashButton.FlashButton FB_Add_Division;
        private FlashButton.FlashButton FB_Remove_Team;
        private FlashButton.FlashButton FB_Add_Team;
        private FlashButton.FlashButton FB_Edit_Team;
        private System.Windows.Forms.Label LBL_Team;
        private System.Windows.Forms.Label LBL_Divisions;
        private Logo_scroller.LogoScroller LS_Logos;
        private System.Windows.Forms.ToolStripStatusLabel SL_Tips;
        private System.Windows.Forms.ListBox LB_Divisions;
        private FlashButton.FlashButton FB_Stars;
    }
}

