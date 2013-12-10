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
                pVscore.Value = mform.m_Visitor_Score;
                pHscore.Value = mform.m_Home_Score;

                try
                {
                    string sqlInsert = "insert into match (receveur, visiteur, daterencontre, " +
                        "lieurencontre, scorevisiteur, scorereceveur) values (:phome, :pvisitor, to_date(:pdate, 'DD-MM-YYYY'), :pstadium, :pVscore, :pHscore)";

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
                InitializeDGV();
            }
        }

        private void FB_Remove_Match_Click(object sender, EventArgs e)
        {
            Remove_Match();
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
            Match_Form form = new Match_Form();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

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

        }
    }
}
