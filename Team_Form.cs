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

// Charles aime les Poneys :D
// Better kill them poneys
namespace TP_Final
{
    public partial class Team_Form : Form
    {
        public Team_Form()
        {
            InitializeComponent();
        }

        public OracleConnection conn;
        private DataSet myData = new DataSet();
        private BindingSource source;
        public string m_TeamName;
        public string m_TeamTown;
        public Color oddRowColor;
        public Color evenRowColor;
        public int m_Selected_Index;
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Options_Form form = new Main_Options_Form();

            form.m_EvenRowColor = Properties.Settings.Default.EvenRowColor;
            form.m_OddRowColor = Properties.Settings.Default.OddRowColor;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.EvenRowColor = form.m_EvenRowColor;
                Properties.Settings.Default.OddRowColor = form.m_OddRowColor;

                Properties.Settings.Default.Save();
            }
        }

        private void Team_Form_Load(object sender, EventArgs e)
        {
            InitializeTitle();
            InitializeDataGrid();

            LoadSettings();
            ApplyRowsStyles();
        }

        private void SaveSettings()
        {
            string widthStrings = "";
            for (int colIndex = 0; colIndex < DGV_Players.ColumnCount; colIndex++)
            {
                widthStrings += DGV_Players.Columns[colIndex].Width.ToString();
                if (colIndex < DGV_Players.ColumnCount - 1)
                    widthStrings += ",";
            }

            Properties.Settings.Default.DGV_Players_Column_Width = widthStrings;
            Properties.Settings.Default.DGV_Players_Row_Headers_Width = DGV_Players.RowHeadersWidth;
            Properties.Settings.Default.OddRowColor = oddRowColor;
            Properties.Settings.Default.EvenRowColor = evenRowColor;
            Properties.Settings.Default.Team_Form_Location = this.Location;
            Properties.Settings.Default.Team_Form_Size = this.Size;
            Properties.Settings.Default.DGV_Font = DGV_Players.Font;

            Properties.Settings.Default.Save();
        }


        private void LoadSettings()
        {
            DGV_Players.RowHeadersWidth = Properties.Settings.Default.DGV_Players_Row_Headers_Width;
            oddRowColor = Properties.Settings.Default.OddRowColor;
            evenRowColor = Properties.Settings.Default.EvenRowColor;
            this.Location = Properties.Settings.Default.Team_Form_Location;
            this.Size = Properties.Settings.Default.Team_Form_Size;
            DGV_Players.Font = Properties.Settings.Default.DGV_Font;

            string[] widthStrings = Properties.Settings.Default.DGV_Players_Column_Width.Split(',');
            if (widthStrings.Count() > 0)
            {
                for (int colIndex = 0; colIndex < DGV_Players.ColumnCount; colIndex++)
                {
                    DGV_Players.Columns[colIndex].Width = int.Parse(widthStrings[colIndex]);
                }
            }
        }

        private void ApplyRowsStyles()
        {
            for (int index = 0; index < DGV_Players.Rows.Count; index++)
            {
                DGV_Players.Rows[index].DefaultCellStyle.BackColor = (index % 2 == 0 ? evenRowColor : oddRowColor);
            }
        }

        private void InitializeTitle()
        {
            LBL_Team.Text = m_TeamName + " de " + m_TeamTown;
        }

        private void InitializeDataGrid()
        {
            myData.Clear();
            string sql = "select * from player where equipe = '" + m_TeamName + "'";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.Fill(myData, "divisions");

            source = new BindingSource(myData, "divisions");
            DGV_Players.DataSource = source;
        }

        private void Show_Player()
        {
            
        }

        private void EditPlayer()
        {
            Player_Form form = new Player_Form();

            form.m_Player_Position = DGV_Players.SelectedRows[0].Cells[4].Value.ToString();
            //form.m_Player_Goals = DGV_Players.SelectedRows[0].Cells[2].Value.ToString();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void FB_Add_Player_Click(object sender, EventArgs e)
        {
            Add_Player_Form form = new Add_Player_Form();

            form.myData = myData;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Add_Player(form.m_PlayerName, form.m_PlayerSurname, form.m_Player_Birth, form.m_PlayerJersey ,form.m_PlayerPosition);
            }            
        }

        private void Add_Player(string name, string surname, DateTime birth, int jersey, string position)
        {
            string sqlADD = "insert into player (nom, prenom, datenaissance, numerotmaillot, role, numjoueur, equipe) values('" + name
                + "','" + surname + "', " + "to_date('" + birth + "', 'DD-MM-YYYY'), " + jersey
                + ",'"+ position + "', :seqJoueurs.nextvalue" + ",'" + m_TeamName + "') ";

            try
            {
                OracleCommand oraInsert = new OracleCommand(sqlADD, conn);
                oraInsert.CommandType = CommandType.Text;
                oraInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            InitializeDataGrid();
        }

        private void FB_Ok_Click(object sender, EventArgs e)
        {
            SaveSettings();
            DialogResult = DialogResult.OK;
        }

        private void FB_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DGV_Players_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditPlayer();
        }

        private void FB_Edit_Player_Click(object sender, EventArgs e)
        {
            EditPlayer();
        }

        private void LBL_Team_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LBL_Team_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void LBL_Team_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
