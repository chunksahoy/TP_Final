using Oracle.DataAccess.Client;
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
    public partial class Add_Match_Form : Form
    {
        public Add_Match_Form()
        {
            InitializeComponent();
        }

        public string m_TeamName;
        public string m_Home;
        public string m_Visitor;
        public DateTime m_Date;
        public string m_Stadium;
        public int m_Home_Score;
        public int m_Visitor_Score;
        public OracleConnection conn = new OracleConnection();

        private void TB_Home_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_HomeScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            m_Home = TB_Home.Text;
            m_Visitor = TB_Visitor.Text;
            m_Date = DTP_Date.Value;
            m_Stadium = TB_Stadium.Text;
            m_Home_Score = int.Parse(TB_HomeScore.Text);
            m_Visitor_Score = int.Parse(TB_VisitorScore.Text);
        }

        private void TB_Home_TextChanged(object sender, EventArgs e)
        {
            if (TB_Home.Text != "")
            {
                string complete = "select * from equipe where nom like '" + TB_Home.Text + "%'";
                CompleteTeam(complete, TB_Home);
                if (TB_Home.Text != m_TeamName && TB_Home.Text.Length > 1)
                    TB_Visitor.Text = m_TeamName;
            }
            if (TB_Home.Text == TB_Visitor.Text && TB_Visitor.Text != "" && TB_Home.Text != "")
            {
                MessageBox.Show("Erreur! Vous ne pouvez pas ajouter un match officiel qui comporte la même équipe pour les visiteurs et les receveurs.");
                TB_Home.Text = "";
                TB_Visitor.Text = "";
            }
        }

        private void TB_Visitor_TextChanged(object sender, EventArgs e)
        {
            if (TB_Visitor.Text != "")
            {
                string complete = "select * from equipe where nom like '" + TB_Visitor.Text + "%'";
                CompleteTeam(complete, TB_Visitor);
                if (TB_Visitor.Text != m_TeamName && TB_Visitor.Text.Length > 1)
                    TB_Home.Text = m_TeamName;
            }
            if (TB_Home.Text == TB_Visitor.Text && TB_Visitor.Text != "" && TB_Home.Text != "")
            {
                MessageBox.Show("Erreur! Vous ne pouvez pas ajouter un match officiel qui comporte la même équipe pour les visiteurs et les receveurs.");
                TB_Home.Text = "";
                TB_Visitor.Text = "";
            }
        }
        private void CompleteTeam(string sql, TextBox tb)
        {
            try
            {
                OracleCommand oraCMD = new OracleCommand(sql, conn);
                AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
                OracleDataReader teamReader = oraCMD.ExecuteReader();                

                while (teamReader.Read())
                {
                    namesCollection.Add(teamReader["Nom"].ToString());
                }
                teamReader.Close();

                tb.AutoCompleteMode = AutoCompleteMode.Suggest;
                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tb.AutoCompleteCustomSource = namesCollection;
                tb.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void TB_Home_Enter(object sender, EventArgs e)
        {
            string sql = "select * from equipe";
            CompleteTeam(sql, TB_Home);
        }

        private void TB_Visitor_Enter(object sender, EventArgs e)
        {
            string sql = "select * from equipe";
            CompleteTeam(sql, TB_Visitor);
        }
    }
}
