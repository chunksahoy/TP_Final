using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_Final
{
    public partial class Match_Form : Form
    {
        #region "Texte pour le StatusStrip"
        private string Txt_PN_Visiteur = "Tips: Ce tableau représente les statistiques des joueurs de l'équipe qui a jouer le match à l'étranger.";
        private string Txt_PN_Receveur = "Tips: Ce tableau représente les statistiques des joueurs de l'équipe qui reçoit le match.";
        private string Txt_ScoreBoard = "Cliqué avec le bouton de gauche de la souris pour modifier le contenu.";
        private string Txt_ShowStats = "Tips: Clique gauche sur ce bouton pour afficher les statistiques complètes du match.";
        private string Txt_ShowTop3 = "Tips: Clique gauche sur ce bouton pour afficher les trois étoiles du match de chaque équipe.";
        #endregion

        private bool ShowStats;
        private Color Home_oddRowColor;
        private Color Home_evenRowColor;
        private Color Visitor_oddRowColor;
        private Color Visitor_evenRowColor;
        private Color Home_FontColor;
        private Color Visitor_FontColor;
        private Font Font_DGV_Home;
        private Font Font_DGV_Visitor;

        public Match_Form()
        {
            InitializeComponent();
        }
        public string m_Home;
        public string m_Visitor;
        public string m_Date;
        public string m_Stadium;
        public int m_Home_Score;
        public int m_Visitor_Score;
        public int m_numMatch;
        
        public OracleConnection conn;

        public BindingSource source;
        public Byte[] image;

        private void Match_Form_Load(object sender, EventArgs e)
        {
            Initialize_Labels();
            Initialize_Winner();
            Initialize_DGV(m_Home, DGV_Home);
            Initialize_DGV(m_Visitor, DGV_Visitor);

            LoadSettings();
            Fill_Data_set(DGV_Home, m_Home);
            Fill_Data_set(DGV_Visitor, m_Visitor);       
            Fill_Data_set(DGV_Home, m_Home);
            Fill_Data_set(DGV_Visitor, m_Visitor);
            ShowStats = false;
            ApplyRowsStyles();
            
        }

        private void LoadSettings()
        {
            // Form parameters
            this.Location = Properties.Settings.Default.Match_Form_Location;
            // DataGridViews' color
            Home_oddRowColor = Properties.Settings.Default.MatchHome_OddRowColor;
            Home_evenRowColor = Properties.Settings.Default.MatchHome_EvenRowColor;
            Visitor_oddRowColor = Properties.Settings.Default.MatchVisitor_OddRowColor;
            Visitor_evenRowColor = Properties.Settings.Default.MatchVisitor_EvenRowColor;
            // DataGridViews' font
            Font_DGV_Home = Properties.Settings.Default.MatchHome_Font;
            Home_FontColor = Properties.Settings.Default.Match_Home_ForeColor;
            Font_DGV_Visitor = Properties.Settings.Default.MatchVisitor_Font;
            Visitor_FontColor = Properties.Settings.Default.Match_Visitor_ForeColor;
        }
        private void ApplyRowsStyles()
        {
            // Ajout des couleurs sur les rangées des DGV
            // Home
            for (int index = 0; index < DGV_Home.Rows.Count; index++)
            {
                DGV_Home.Rows[index].DefaultCellStyle.BackColor = (index % 2 == 0 ? Home_evenRowColor : Home_oddRowColor);
            }
            // Visitor
            for (int index = 0; index < DGV_Visitor.Rows.Count; index++)
            {
                DGV_Visitor.Rows[index].DefaultCellStyle.BackColor = (index % 2 == 0 ? Visitor_evenRowColor : Visitor_oddRowColor);
            }
            // Changement de font des DGV
            DGV_Home.Font = Font_DGV_Home;
            DGV_Home.ForeColor = Home_FontColor;
            DGV_Visitor.Font = Font_DGV_Visitor;
            DGV_Visitor.ForeColor = Visitor_FontColor;
        }

        private void Initialize_Labels()
        {
            LBL_Home.Text = m_Home;
            LBL_Visitor.Text = m_Visitor;
            LBL_Date.Text = m_Date;
            LBL_Stadium.Text = m_Stadium;
            LBL_Score_Home.Text = m_Home_Score.ToString();
            LBL_Score_Visitor.Text = m_Visitor_Score.ToString();
            LBL_Home.Location = new Point((PN_Home.Size.Width - LBL_Home.Size.Width) / 2, LBL_Home.Location.Y);
            LBL_Visiteur.Location = new Point((PN_Visitor.Size.Width - LBL_Visiteur.Width) / 2, LBL_Visiteur.Location.Y);
        }

        private void Initialize_Winner()
        {
            PN_LVis_Win.BackgroundImage = null;
            PN_RHome_Win.BackgroundImage = null;

            PN_LHome_Win.BackgroundImage = null;
            PN_RHome_Win.BackgroundImage = null;

            //il y a deux if ici en cas de scores égaux
            if (m_Home_Score > m_Visitor_Score)
            {
                PN_LHome_Win.BackgroundImage = Properties.Resources.Champion;
                PN_RHome_Win.BackgroundImage = Properties.Resources.Champion;
            }
            if (m_Visitor_Score > m_Home_Score)
            {
                PN_LVis_Win.BackgroundImage = Properties.Resources.Champion;
                PN_RVis_Win.BackgroundImage = Properties.Resources.Champion;
            }
        }

        private void Initialize_DGV(string teamName, DataGridView dgv)
        {
            DataSet myData = new DataSet();
            myData.Clear();
            string sql = "select nom, prenom, numeromaillot, role from player where equipe = '" + teamName + "'";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.Fill(myData, "equipe");

            source = new BindingSource(myData, "equipe");
            dgv.DataSource = source;
        }

        private void FB_Stats_Click(object sender, EventArgs e)
        {
            LBL_Receveur.Text = LBL_Visiteur.Text = "Statistiques du match";
            // FB_Stats.ImageNeutral
        }

        private void PN_Display_MouseEnter(object sender, EventArgs e)
        {
            SL_Game.Text = Txt_ScoreBoard;
        }

        private void PN_Display_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }

        private void PN_Display_Click(object sender, EventArgs e)
        {
            Edit_Display();
        }

        private int Calculate_Score(string team)
        {
            OracleParameter pteam = new OracleParameter(":equipe", OracleDbType.Varchar2, 30);

            string sql = "select sum(nbbuts) from vueJoueur where equipe=:pteam";
            int score = 0;

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            oraCMD.CommandType = CommandType.Text;

            pteam.Value = team;

            try
            {
                oraCMD.Parameters.Add(pteam);

                OracleDataReader oraRead = oraCMD.ExecuteReader();

                while (oraRead.Read())
                {
                    score = oraRead.GetInt32(0);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return score;
        }

        private void Update_Match(string stadium, DateTime date)
        {
            OracleParameter pdate = new OracleParameter(":date", OracleDbType.Date);
            OracleParameter pstadium = new OracleParameter(":stade", OracleDbType.Varchar2, 30);
            OracleParameter phomescore = new OracleParameter(":scoreReceveur", OracleDbType.Int32);
            OracleParameter pvisitscore = new OracleParameter(":scorevisiteur", OracleDbType.Int32);
            OracleParameter pmatch = new OracleParameter(":numeromatch", OracleDbType.Int32);

            string sqlUpdate = "update match set daterencontre =:pdate, lieurencontre=:pstadium, scorereceveur=:phomescore," +
                " scorevisiteur=:pvisitscore where numeromatch =:pmatch";
            OracleCommand oraUpdate = new OracleCommand(sqlUpdate, conn);
            oraUpdate.CommandType = CommandType.Text;

            pdate.Value = date;
            pstadium.Value = stadium;
            phomescore.Value = Calculate_Score(m_Home);
            pvisitscore.Value = Calculate_Score(m_Visitor);
            pmatch.Value = m_numMatch;

            try
            {
                oraUpdate.Parameters.Add(pdate);
                oraUpdate.Parameters.Add(pstadium);
                oraUpdate.Parameters.Add(phomescore);
                oraUpdate.Parameters.Add(pvisitscore);
                oraUpdate.Parameters.Add(pmatch);

                oraUpdate.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SearchLogo(string team)
        {
            try
            {
                OracleCommand oraCMD = conn.CreateCommand();
                oraCMD.CommandText = "select logo from equipe where nom = :nom";

                oraCMD.Parameters.Add(new OracleParameter(":nom", team));

                using (OracleDataReader oraReader = oraCMD.ExecuteReader())
                {
                    if (oraReader.Read())
                    {
                        Byte[] image;
                        OracleBlob blob = oraReader.GetOracleBlob(0);

                        if (!blob.IsNull)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                byte[] buffer = new byte[8 * 1024];

                                int read = 0;

                                while ((read = blob.Read(buffer, 0, 8 * 1024)) > 0)
                                {
                                    ms.Write(buffer, 0, read);
                                }
                                image = ms.ToArray();
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Edit_Player(DataGridView dgv, bool home = true)
        {
            Player_Form form = new Player_Form();

            //form.m_Team = PB_Logo.Image;
            form.m_Player_Position = dgv.SelectedRows[0].Cells[3].Value.ToString();

            if (home)
                form.m_Team_Name = m_Home;
            else
                form.m_Team_Name = m_Visitor;

            form.conn = conn;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void Fill_Data_set(DataGridView dgv, string team)
        {
            DataSet myData = new DataSet();

            myData.Clear();

            OracleParameter pteam = new OracleParameter(":equipe", OracleDbType.Varchar2, 30);

            string sql = "select * from hunterro.vueJoueur where equipe=:pteam";

            pteam.Value = team;

            OracleCommand oraCMD = new OracleCommand(sql, conn);

            oraCMD.Parameters.Add(pteam);

            oraCMD.CommandType = CommandType.Text;

            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.SelectCommand = oraCMD;

            adapt.Fill(myData, "vueJoueur");

            source = new BindingSource(myData, "vueJoueur");
            dgv.DataSource = source;
        }

        private void Edit_Display()
        {
            Edit_Match_Form form = new Edit_Match_Form();

            form.m_Stadium = LBL_Stadium.Text;
            form.m_Date = DateTime.Parse(LBL_Date.Text);

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_Stadium = form.m_Stadium;
                m_Date = form.m_Date.ToShortDateString();

                Initialize_Labels();
                Initialize_Winner();

                Update_Match(form.m_Stadium, form.m_Date);
            }
        }

        private void Match_Form_SizeChanged(object sender, EventArgs e)
        {

        }

        #region  "Gestion_Panel_Stats"
        private void LBL_Stadium_Click(object sender, EventArgs e)
        {
            Edit_Display();
        }

        private void LBL_Date_Click(object sender, EventArgs e)
        {
            Edit_Display();
        }

        private void PN_Score_Click(object sender, EventArgs e)
        {
            Edit_Display();
        }

        private void PN_Score_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void LBL_Stadium_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void LBL_Date_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void PN_Score_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void LBL_Stadium_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void LBL_Date_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        #endregion

        private void DGV_Visitor_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Edit_Player(DGV_Visitor, false);
        }

        private void DGV_Home_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Edit_Player(DGV_Home);
        }

        private void FB_Edit_Visitor_Click(object sender, EventArgs e)
        {

        }

        private void FB_Edit_Home_Click(object sender, EventArgs e)
        {

        }
        #region "Actions Liés au MouseEnter"
        private void PN_Visitor_MouseEnter(object sender, EventArgs e)
        {
            SL_Game.Text = Txt_PN_Visiteur;
        }

        private void PN_Home_MouseEnter(object sender, EventArgs e)
        {
            SL_Game.Text = Txt_PN_Receveur;
        }
        private void DGV_Visitor_MouseEnter(object sender, EventArgs e)
        {
            SL_Game.Text = Txt_PN_Visiteur;
        }
        private void DGV_Home_MouseEnter(object sender, EventArgs e)
        {
            SL_Game.Text = Txt_PN_Receveur;
        }
        private void FB_Stats_MouseEnter(object sender, EventArgs e)
        {
            if (ShowStats)
                SL_Game.Text = Txt_ShowStats;
            if (!ShowStats)
                SL_Game.Text = Txt_ShowTop3;
        }

        #endregion
        #region ""Actions liés au MouseLeave"
        private void Empty_StatusStrip()
        {
            SL_Game.Text = "";
        }
        private void PN_Home_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }
        private void PN_Visitor_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }


        private void DGV_Home_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }

        private void DGV_Visitor_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }

        private void FB_Stats_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }
        #endregion

        private void FB_Stats_MouseClick(object sender, MouseEventArgs e)
        {
            if (ShowStats)
            {
                ShowStats = false;
                FB_Stats.ImageNeutral = TP_Final.Properties.Resources.StraightLines_Neutral;
                FB_Stats.ImageClick = TP_Final.Properties.Resources.StraightLines_Click;
                FB_Stats.ImageOver = TP_Final.Properties.Resources.StraightLines_Over;
                FB_Stats.BorderStyle = BorderStyle.Fixed3D;
                LBL_Receveur.Text = LBL_Visiteur.Text = "Top 3";
                LBL_Receveur.Location = new Point(LBL_Receveur.Location.X + 75, LBL_Receveur.Location.Y);
                LBL_Visiteur.Location = new Point(LBL_Visiteur.Location.X + 75, LBL_Visiteur.Location.Y);
                SL_Game.Text = Txt_ShowTop3;
            }
            else
            {
                ShowStats = true;
                FB_Stats.ImageNeutral = TP_Final.Properties.Resources.Etoile;
                FB_Stats.ImageClick = TP_Final.Properties.Resources.EtoileClick;
                FB_Stats.ImageOver = TP_Final.Properties.Resources.EtoileOver;
                FB_Stats.BorderStyle = BorderStyle.None;
                LBL_Receveur.Text = LBL_Visiteur.Text = "Statistiques du match";
                LBL_Receveur.Location = new Point(LBL_Receveur.Location.X - 75, LBL_Receveur.Location.Y);
                LBL_Visiteur.Location = new Point(LBL_Visiteur.Location.X - 75, LBL_Visiteur.Location.Y);
                SL_Game.Text = Txt_ShowStats;
            }

        }

        private void SaveSettings()
        {
            Properties.Settings.Default.MatchHome_Font = Font_DGV_Home;
            Properties.Settings.Default.Match_Home_ForeColor = Home_FontColor;
            Properties.Settings.Default.MatchVisitor_Font = Font_DGV_Visitor;
            Properties.Settings.Default.Match_Visitor_ForeColor = Visitor_FontColor;
            // DataGridViews' color 
            Properties.Settings.Default.MatchHome_EvenRowColor = Home_evenRowColor;
            Properties.Settings.Default.MatchHome_OddRowColor = Home_oddRowColor;
            Properties.Settings.Default.MatchVisitor_EvenRowColor = Visitor_evenRowColor;
            Properties.Settings.Default.MatchVisitor_OddRowColor = Visitor_oddRowColor;
            // Form parameters
            Properties.Settings.Default.Match_Form_Location = this.Location;
        }

        private void Match_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        #region "ToolStripMenuItem_Option"
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Match_Option_Form dlg = new Match_Option_Form();

            // Ajout des couleurs dans le dlg
            dlg.Home_evenRowColor = Home_evenRowColor;
            dlg.Home_oddRowColor = Home_oddRowColor;
            dlg.Visitor_evenRowColor = Visitor_evenRowColor;
            dlg.Visitor_oddRowColor = Visitor_oddRowColor;
            // Ajout des fonts dans le dlg
            dlg.Font_DGV_Home = Font_DGV_Home;
            dlg.Home_FontColor = Home_FontColor;
            dlg.Visitor_FontColor = Visitor_FontColor;
            dlg.Font_DGV_Visitor = Font_DGV_Visitor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Home
                Home_oddRowColor = dlg.Home_oddRowColor;
                Home_evenRowColor = dlg.Home_evenRowColor;
                Font_DGV_Home = dlg.Font_DGV_Home;
                Home_FontColor = dlg.Home_FontColor;
                // Visitor
                Visitor_oddRowColor = dlg.Visitor_oddRowColor;
                Visitor_evenRowColor = dlg.Visitor_evenRowColor;
                Font_DGV_Visitor = dlg.Font_DGV_Visitor;
                Visitor_FontColor = dlg.Visitor_FontColor;

                ApplyRowsStyles();
            }
        }
        #endregion

        #region "DGV_Home ToolStripMenuItem"
        private void DGV_Home_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGV_Home.ClearSelection();
            DGV_Home.Rows[e.RowIndex].Selected = true;

            if (e.Button == MouseButtons.Right)
            {
                if (DGV_Home.SelectedRows.Count > 0)
                {
                    ContextMenuStrip cms = new ContextMenuStrip();
                    ToolStripMenuItem tsmi;
                    if (DGV_Home.RowCount > 1 && DGV_Home.SelectedRows[0].Index != DGV_Home.RowCount - 1)
                    {
                        tsmi = new ToolStripMenuItem("Modifier l'enregistrement");
                        tsmi.Click += tsmiHome_Edit_Click;
                        cms.Items.Add(tsmi);

                        tsmi = new ToolStripMenuItem("Effacer l'enregistrement");
                        tsmi.Click += tsmiHome_Delete_Click;
                        cms.Items.Add(tsmi);
                    }
                    tsmi = new ToolStripMenuItem("Police...");
                    tsmi.Click += tsmiHome_Font_Click;
                    cms.Items.Add(tsmi);

                    tsmi = new ToolStripMenuItem("Couleur...");
                    tsmi.Click += tsmiHome_Color_Click;
                    cms.Items.Add(tsmi);

                    cms.Show(DGV_Home, DGV_Home.PointToClient(Cursor.Position));
                }
            }
        }
        private void tsmiHome_Color_Click(Object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = (DGV_Home.SelectedRows[0].Index % 2 == 0 ? Home_evenRowColor : Home_oddRowColor);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (DGV_Home.SelectedRows[0].Index % 2 == 0)
                    Home_evenRowColor = dlg.Color;
                else
                    Home_oddRowColor = dlg.Color;
                ApplyRowsStyles();
            }
        }
        private void tsmiHome_Font_Click(Object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.ShowColor = true;
            dlg.Font = Font_DGV_Home;
            dlg.Color = Home_FontColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Font_DGV_Home = dlg.Font;
                Home_FontColor = dlg.Color;
                ApplyRowsStyles();
            }
        }
        private void tsmiHome_Delete_Click(Object sender, EventArgs e)
        {
            tsmiHome_Remove_FichePersonnelle();
        }
        private void tsmiHome_Edit_Click(Object sender, EventArgs e)
        {
           // Edit_Match();
        }
        private void tsmiHome_Remove_FichePersonnelle()
        {
            DeleteForm dlg = new DeleteForm();

            dlg.ElementSupprime = "la fiche personnelle du joueur numéro  " + DGV_Home.SelectedRows[0].Cells[0].Value.ToString();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "delete from fichepersonnelle where numjoueur =" + DGV_Home.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    OracleCommand oraCMD = new OracleCommand(sql, conn);
                    oraCMD.CommandType = CommandType.Text;
                    oraCMD.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        #endregion

        #region "DGV_Visitor ToolStripMenuItem"
        private void DGV_Visitor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGV_Visitor.ClearSelection();
            DGV_Visitor.Rows[e.RowIndex].Selected = true;

            if (e.Button == MouseButtons.Right)
            {
                if (DGV_Visitor.SelectedRows.Count > 0)
                {
                    ContextMenuStrip cms = new ContextMenuStrip();
                    ToolStripMenuItem tsmi;

                    tsmi = new ToolStripMenuItem("Modifier l'enregistrement");
                    tsmi.Click += tsmiVisitor_Edit_Click;
                    cms.Items.Add(tsmi);

                    tsmi = new ToolStripMenuItem("Effacer l'enregistrement");
                    tsmi.Click += tsmiVisitor_Delete_Click;
                    cms.Items.Add(tsmi);
                    
                    tsmi = new ToolStripMenuItem("Police...");
                    tsmi.Click += tsmiVisitor_Font_Click;
                    cms.Items.Add(tsmi);

                    tsmi = new ToolStripMenuItem("Couleur...");
                    tsmi.Click += tsmiVisitor_Color_Click;
                    cms.Items.Add(tsmi);

                    cms.Show(DGV_Visitor, DGV_Visitor.PointToClient(Cursor.Position));
                }
            }
        }

        private void tsmiVisitor_Edit_Click(Object sender, EventArgs e)
        {
            // Edit_Match();
        }

        private void tsmiVisitor_Delete_Click(Object sender, EventArgs e)
        {
            DeleteForm dlg = new DeleteForm();

            dlg.ElementSupprime = "la fiche personnelle du joueur numéro " + DGV_Home.SelectedRows[0].Cells[0].Value.ToString();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "delete from fichepersonnelle where numjoueur =" + DGV_Visitor.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    OracleCommand oraCMD = new OracleCommand(sql, conn);
                    oraCMD.CommandType = CommandType.Text;
                    oraCMD.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void tsmiVisitor_Font_Click(Object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.ShowColor = true;
            dlg.Font = Font_DGV_Visitor;
            dlg.Color = Visitor_FontColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Font_DGV_Visitor = dlg.Font;
                Visitor_FontColor = dlg.Color;
                ApplyRowsStyles();
            }
        }
        private void tsmiVisitor_Color_Click(Object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = (DGV_Visitor.SelectedRows[0].Index % 2 == 0 ? Visitor_evenRowColor : Visitor_oddRowColor);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (DGV_Visitor.SelectedRows[0].Index % 2 == 0)
                    Visitor_evenRowColor = dlg.Color;
                else
                    Visitor_oddRowColor = dlg.Color;
                ApplyRowsStyles();
            }
        }
        #endregion

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Form dlg = new Help_Form();
            dlg.ShowDialog();
        }
    }
}
