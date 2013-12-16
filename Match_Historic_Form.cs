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
    public partial class Match_Historic_Form : Form
    {
        public Match_Historic_Form()
        {
            InitializeComponent();
        }

        public OracleConnection conn = new OracleConnection();
        public DataSet myData = new DataSet();
        public BindingSource source;
        List<int> playerNumbers;
        public string m_Team;

        private void Match_Historic_Form_Load(object sender, EventArgs e)
        {
            InitializeDGV();
        }

        private void InitializeDGV()
        {
            myData.Clear();
            string sql = " select * from match where receveur = '" + m_Team +
                "' UNION select * from match where visiteur = '" + m_Team + "'";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.Fill(myData, "divisions");

            source = new BindingSource(myData, "divisions");
            DGV_Historic.DataSource = source;

            Resize_DGV_Historic();
        }

        private void Initialize_Players_Stats(string team)
        {
            OracleParameter pplayer = new OracleParameter(":numjoueur", OracleDbType.Int32);
            OracleParameter pmatch = new OracleParameter(":numeromatch", OracleDbType.Int32);

            string sqlInit = "insert into fichepersonnelle values(0,0,0,:pplayer,:pmatch)";
            List<int> playersNumber = new List<int>();
            OracleCommand oraCMD = new OracleCommand(sqlInit, conn);

            oraCMD.CommandType = CommandType.Text;
 
            playersNumber = Get_Players_Number(team);

            oraCMD.Parameters.Add(pplayer);
            oraCMD.Parameters.Add(pmatch);

            foreach (int number in playersNumber)
            {
                pplayer.Value = number;
                pmatch.Value = Get_Match_Number();

                oraCMD.ExecuteNonQuery();
            }
        }

        private int Get_Match_Number()
        {
            int matchNumber = 0;
            string numMatch = "select seqMatchs.currval from dual";

            OracleCommand cmd = new OracleCommand(numMatch, conn);
            cmd.CommandType = CommandType.Text;

            OracleDataReader matchRead = cmd.ExecuteReader();

            while (matchRead.Read())
            {
                matchNumber = matchRead.GetInt32(0);
            }

            return matchNumber;
        }

        private List<int> Get_Players_Number(string team)
        {
            OracleParameter pteam = new OracleParameter(":equipe", OracleDbType.Varchar2, 30);
            playerNumbers = new List<int>();
            string sqlNumPlayer = "select numjoueur from joueur where equipe=:pteam";

            OracleCommand cmd = new OracleCommand(sqlNumPlayer, conn);
            cmd.CommandType = CommandType.Text;

            pteam.Value = team;

            cmd.Parameters.Add(pteam);

            OracleDataReader oraRead = cmd.ExecuteReader();

            oraRead = cmd.ExecuteReader();
            //atteindre les numéros de joueurs, cela nous donne en même temps le nombre de joueurs dans l'équipe
            while (oraRead.Read())
            {
                playerNumbers.Add(oraRead.GetInt32(0));
            }
            return playerNumbers;
        }
        private void Resize_DGV_Historic()
        {
            foreach (DataGridViewColumn Col in DGV_Historic.Columns)
            {
                Col.Width = DGV_Historic.Size.Width / DGV_Historic.ColumnCount;
            }
        }

        private void FB_Add_Match_Click(object sender, EventArgs e)
        {
            Add_Match();
        }

        private void Add_Match()
        {
            Add_Match_Form mform = new Add_Match_Form();
            mform.m_TeamName = m_Team;
            mform.conn = conn;


            if (mform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OracleParameter phome = new OracleParameter(":receveur", OracleDbType.Varchar2, 20);
                OracleParameter pvisitor = new OracleParameter(":visiteur", OracleDbType.Varchar2, 20);
                OracleParameter pdate = new OracleParameter(":date", OracleDbType.Date);
                OracleParameter pstadium = new OracleParameter(":lieu", OracleDbType.Varchar2, 30);
                OracleParameter pVscore = new OracleParameter(":vscore", OracleDbType.Int32);
                OracleParameter pHscore = new OracleParameter(":hscore", OracleDbType.Int32);

                phome.Value = mform.m_Home;
                pvisitor.Value = mform.m_Visitor;
                pdate.Value = mform.m_Date;
                pstadium.Value = mform.m_Stadium;
                pVscore.Value = 0;
                pHscore.Value = 0;

                try
                {
                    string sqlInsert = "insert into match (receveur, visiteur, daterencontre, " +
                        "lieurencontre, scorevisiteur, scorereceveur) values (:phome, :pvisitor, to_date(:pdate, 'DD-MM-YYYY')," +
                        " :pstadium, :pVscore, :pHscore)";

                    OracleCommand oraInsert = new OracleCommand(sqlInsert, conn);

                    oraInsert.Parameters.Add(phome);
                    oraInsert.Parameters.Add(pvisitor);
                    oraInsert.Parameters.Add(pdate);
                    oraInsert.Parameters.Add(pstadium);
                    oraInsert.Parameters.Add(pVscore);
                    oraInsert.Parameters.Add(pHscore);

                    oraInsert.CommandType = CommandType.Text;
                    oraInsert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                Initialize_Players_Stats(mform.m_Home);
                Initialize_Players_Stats(mform.m_Visitor);
                InitializeDGV();
            }
        }

        private void FB_Remove_Match_Click(object sender, EventArgs e)
        {
            DeleteForm dlg = new DeleteForm();
            dlg.ElementSupprime = "le match numéro " + DGV_Historic.SelectedRows[0].Cells[0].Value.ToString();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Remove_Match();
            }
        }

        private void Remove_Match()
        {
            string sqlDel = "delete from match where numeromatch = " + DGV_Historic.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                OracleCommand oraDel = new OracleCommand(sqlDel, conn);

                oraDel.CommandType = CommandType.Text;
                oraDel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            InitializeDGV();
        }

        private void FB_Edit_Match_Click(object sender, EventArgs e)
        {
            Edit_Match();
        }

        private void Edit_Match()
        {
            if (DGV_Historic.RowCount > 0)
            {
                Match_Form form = new Match_Form();

                form.conn = conn;

                form.m_numMatch = int.Parse(DGV_Historic.SelectedRows[0].Cells[0].Value.ToString());
                form.m_Home = DGV_Historic.SelectedRows[0].Cells[1].Value.ToString();
                form.m_Visitor = DGV_Historic.SelectedRows[0].Cells[2].Value.ToString();
                form.m_Date = DateTime.Parse(DGV_Historic.SelectedRows[0].Cells[3].Value.ToString()).ToShortDateString();
                form.m_Stadium = DGV_Historic.SelectedRows[0].Cells[4].Value.ToString();
                form.m_Visitor_Score = int.Parse(DGV_Historic.SelectedRows[0].Cells[5].Value.ToString());
                form.m_Home_Score = int.Parse(DGV_Historic.SelectedRows[0].Cells[6].Value.ToString());
                form.home_Players_Number = Get_Players_Number(DGV_Historic.SelectedRows[0].Cells[1].Value.ToString());
                form.visit_Players_Number = Get_Players_Number(DGV_Historic.SelectedRows[0].Cells[2].Value.ToString());
                form.ShowDialog();

                InitializeDGV();
            }
        }

        private void FB_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void DGV_Historic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Historic_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DGV_Historic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DGV_Historic_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            foreach (DataGridViewRow row in DGV_Historic.SelectedRows)
            {
                row.Height = e.Row.Height;
            }
        }

        private void FB_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
