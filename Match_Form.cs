﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public OracleConnection conn;
        public DataSet myData;
        public BindingSource source;

        private void Match_Form_Load(object sender, EventArgs e)
        {
            Initialize_Labels();
            Initialize_Winner();
            Initialize_DGV(m_Home, DGV_Home);
            Initialize_DGV(m_Visitor, DGV_Visitor);
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

        private void Initialize_DGV(string teamName, DataGridView dgv)
        {
            myData = new DataSet();
            myData.Clear();
            string sql = "select nom, prenom, numeromaillot from player where equipe = '" + teamName + "'";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.Fill(myData, "equipe");

            source = new BindingSource(myData, "equipe");
            dgv.DataSource = source;
            //LoadSettings();
            //ApplyRowsStyles();
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

        private void Update_Match(string stadium, DateTime date, int homeScore, int visitScore)
        {
            OracleParameter pdate = new OracleParameter(":date",OracleDbType.Date);
            OracleParameter pstadium = new OracleParameter(":stade", OracleDbType.Varchar2, 30);
            OracleParameter phomescore = new OracleParameter(":scoreReceveur", OracleDbType.Int32);
            OracleParameter pvisitscore = new OracleParameter(":scorevisiteur", OracleDbType.Int32);
            OracleParameter pmatch = new OracleParameter(":numeromatch", OracleDbType.Int32);

            string sqlUpdate = "update match set daterencontre =:pdate, lieurencontre=:pstadium, scorereceveur=:phomescore, scorevisiteur=:pvisitscore where numeromatch =:pmatch";
            OracleCommand oraUpdate = new OracleCommand(sqlUpdate, conn);
            oraUpdate.CommandType = CommandType.Text;

            pdate.Value = date;
            pstadium.Value = stadium;
            phomescore.Value = homeScore;
            pvisitscore.Value = visitScore;
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
        private void Edit_Display()
        {
            Edit_Match_Form form = new Edit_Match_Form();

            form.m_Stadium = LBL_Stadium.Text;
            form.m_Date = DateTime.Parse(LBL_Date.Text);
            form.m_Home_Score = int.Parse(LBL_Score_Home.Text);
            form.m_Visitor_Score = int.Parse(LBL_Score_Visitor.Text);

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_Stadium = form.m_Stadium;
                m_Date = form.m_Date.ToShortDateString();
                m_Home_Score = form.m_Home_Score;
                m_Visitor_Score = form.m_Visitor_Score;

                Initialize_Labels();
                Initialize_Winner();

                Update_Match(form.m_Stadium,form.m_Date, form.m_Home_Score, form.m_Visitor_Score);
            }
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
