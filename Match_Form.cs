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
        public List<int> home_Players_Number;
        public List<int> visit_Players_Number;
        public OracleConnection conn;
        public BindingSource source;
        public Byte[] image;

        private void Match_Form_Load(object sender, EventArgs e)
        {
            Fill_Data_set(DGV_Home, home_Players_Number);
            Fill_Data_set(DGV_Visitor, visit_Players_Number);

            m_Home_Score = Calculate_Score(home_Players_Number);
            m_Visitor_Score = Calculate_Score(visit_Players_Number);

            Initialize_Labels();            
            Initialize_Winner();
            ShowStats = false;
        }

        private void Initialize_Labels()
        {
            LBL_Home.Text = m_Home;
            LBL_Visitor.Text = m_Visitor;
            LBL_Date.Text = m_Date;
            LBL_Stadium.Text = m_Stadium;
            LBL_Score_Home.Text = m_Home_Score.ToString();
            LBL_Score_Visitor.Text = m_Visitor_Score.ToString();
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

        private int Calculate_Score(List<int> playersNumber)
        {
            OracleParameter pmatch = new OracleParameter(":numeromatch", OracleDbType.Int32);
            OracleParameter pplayer = new OracleParameter(":numjoueur", OracleDbType.Int32);
            string sql = "select nbbuts from fichepersonnelle fp inner join joueur j on fp.numjoueur = j.numjoueur" +
                    " inner join match ma on fp.numeromatch = ma.numeromatch" +
                    " where fp.numeromatch =:pmatch and fp.numjoueur =:pplayer ";
            int score = 0;

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            oraCMD.CommandType = CommandType.Text;
            oraCMD.Parameters.Add(pmatch);
            oraCMD.Parameters.Add(pplayer);

            pmatch.Value = m_numMatch;
            try
            {
                foreach (int number in playersNumber)
                {
                    pplayer.Value = number;
                    OracleDataReader oraRead = oraCMD.ExecuteReader();

                    while(oraRead.Read())
                    {
                        score += oraRead.GetInt32(0);                        
                    }
                    oraRead.Close();
                }
            }
            catch(OracleException ex)
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
            phomescore.Value = Calculate_Score(home_Players_Number);
            pvisitscore.Value = Calculate_Score(visit_Players_Number);
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


        private void SearchLogo(string team, Player_Form form)
        {
            try
            {
                OracleCommand oraCMD = conn.CreateCommand();
                oraCMD.CommandText = "select logo from equipe where nom =:nom";

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
                                form.m_Team = Image.FromStream(ms);
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

            form.m_Player_Position = dgv.SelectedRows[0].Cells[3].Value.ToString();

            if (home)
            {
                form.m_Team_Name = m_Home;
                SearchLogo(m_Home, form);
            }
            else
            {
                form.m_Team_Name = m_Visitor;
                SearchLogo(m_Visitor, form);
            }

            form.conn = conn;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Update_Player(form, dgv);
                Fill_Data_set(DGV_Home, home_Players_Number);
                Fill_Data_set(DGV_Visitor, visit_Players_Number);
                Update_Match(m_Stadium, DateTime.Parse(m_Date));
                m_Home_Score = Calculate_Score(home_Players_Number);
                m_Visitor_Score = Calculate_Score(visit_Players_Number);
                Initialize_Labels();
                Initialize_Winner();                
            }
        }

        private void Update_Player(Player_Form form, DataGridView dgv)
        {
            OracleParameter pgoals = new OracleParameter(":buts", OracleDbType.Int32);
            OracleParameter ppasses = new OracleParameter(":passes", OracleDbType.Int32);
            OracleParameter ppunition = new OracleParameter(":punition", OracleDbType.Int32);
            OracleParameter pplayer = new OracleParameter(":numjoueur", OracleDbType.Int32);
            OracleParameter pmatch = new OracleParameter(":numeromatch", OracleDbType.Int32);

            string sqlUpdate = "update fichepersonnelle set nbbuts=:pgoals, nbpasses =:ppasses, tempspunition =:ppunition " +
                                "where numjoueur =:pplayer and numeromatch =:pmatch";

            OracleCommand oraUpdate = new OracleCommand(sqlUpdate, conn);
            oraUpdate.CommandType = CommandType.Text;

            pgoals.Value = form.m_Player_Goals;
            ppasses.Value = form.m_Player_Pass;
            ppunition.Value = form.m_Player_Punitions;
            pplayer.Value = int.Parse(dgv.SelectedRows[0].Cells[2].Value.ToString());
            pmatch.Value = m_numMatch;

            try
            {
                oraUpdate.Parameters.Add(pgoals);
                oraUpdate.Parameters.Add(ppasses);
                oraUpdate.Parameters.Add(ppunition);
                oraUpdate.Parameters.Add(pplayer);
                oraUpdate.Parameters.Add(pmatch);

                oraUpdate.ExecuteNonQuery();
            }
            catch (OracleException Exception)
            {
                MessageBox.Show(Exception.Message.ToString());
            }
        }

        private void Fill_Data_set(DataGridView dgv, List<int> playersNumber)
        {
            DataSet myData = new DataSet();

            myData.Clear();

            string sql = "select * from fichepersonnelle";
            foreach (int number in playersNumber)
            {
                sql = "select nom, prenom, fp.numjoueur, role, nbbuts, nbpasses, tempspunition " +
                    " from fichepersonnelle fp inner join joueur j on fp.numjoueur = j.numjoueur" +
                    " inner join match ma on fp.numeromatch = ma.numeromatch" +
                    " where fp.numeromatch = " + m_numMatch + " and fp.numjoueur = " + number;

                OracleCommand oraCMD = new OracleCommand(sql, conn);

                oraCMD.CommandType = CommandType.Text;

                OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

                adapt.SelectCommand = oraCMD;

                adapt.Fill(myData, "vueJoueur");

                source = new BindingSource(myData, "vueJoueur");
                dgv.DataSource = source;
            }
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

                Update_Match(form.m_Stadium, form.m_Date);

                Initialize_Labels();
                Initialize_Winner();
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
            Edit_Player(DGV_Visitor, false);
        }

        private void FB_Edit_Home_Click(object sender, EventArgs e)
        {
            Edit_Player(DGV_Home);
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

    }
}
