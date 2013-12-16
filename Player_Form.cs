using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
    public partial class Player_Form : Form
    {
        public Player_Form()
        {
            InitializeComponent();
            Load_Stats();
        }

        public string m_Player_Position;
        public int m_Player_Goals;
        public int m_Player_Pass;
        public int m_Player_Points;
        public int m_Player_Punitions;
        public string m_Picture_Path;
        public string m_Team_Name;
        public string m_Player_Surname;
        public string m_Player_Name;
        public Image m_Team;
        public DataSet myData = new DataSet();
        public BindingSource source;
        public OracleConnection conn;

        private void Save_Stats()
        {
            m_Player_Position = TB_Player_Position.Text;
            m_Player_Goals = int.Parse(TB_Player_Goals.Text);
            m_Player_Pass = int.Parse(TB_Player_Pass.Text);
            m_Player_Points = int.Parse(TB_Player_Points.Text);
            m_Player_Punitions = int.Parse(TB_Player_Penalty.Text);
        }

        private void Load_Stats()
        {
            TB_Player_Goals.Text = m_Player_Goals.ToString();
            TB_Player_Pass.Text = m_Player_Pass.ToString();
            TB_Player_Points.Text = m_Player_Points.ToString();
            TB_Player_Penalty.Text = m_Player_Punitions.ToString();
            PB_Team_Logo.Image = m_Team;
        }

        private void FB_Ok_Click(object sender, EventArgs e)
        {
            Save_Stats();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FB_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Player_Form_Load(object sender, EventArgs e)
        {
            Load_Stats();
            Fill_Data_set();
            Update_Picture();
        }

        private void Fill_Data_set()
        {
            myData.Clear();
            string sql = "select nom, prenom, buts, passes, points, punition" +
                " from vueJoueur where equipe = '" + m_Team_Name + "'";
            OracleCommand oraCMD = new OracleCommand(sql, conn);
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.Fill(myData, "vueJoueur");

            source = new BindingSource(myData, "vueJoueur");

            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            try
            {
                TB_Name.DataBindings.Add("Text", myData, "vueJoueur.nom");
                TB_Surname.DataBindings.Add("Text", myData, "vueJoueur.prenom");
                TB_Player_Goals.DataBindings.Add("Text", myData, "vueJoueur.buts");
                TB_Player_Pass.DataBindings.Add("Text", myData, "vueJoueur.passes");
                TB_Player_Points.DataBindings.Add("Text", myData, "vueJoueur.points");
                TB_Player_Penalty.DataBindings.Add("Text", myData, "vueJoueur.punition");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Clear_TB_Bindings()
        {
            TB_Player_Position.DataBindings.Clear();
            TB_Player_Goals.DataBindings.Clear();
            TB_Player_Pass.DataBindings.Clear();
            TB_Player_Points.DataBindings.Clear();
            TB_Player_Penalty.DataBindings.Clear();
        }

        #region "Navigation_Joueurs"
        private void BTN_Begin_Click(object sender, EventArgs e)
        {
            this.BindingContext[myData, "vueJoueur"].Position = 0;
            Update_Picture();
        }

        private void BTN_Previous_Click(object sender, EventArgs e)
        {
            this.BindingContext[myData, "vueJoueur"].Position -= 1;
            Update_Picture();
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            this.BindingContext[myData, "vueJoueur"].Position += 1;
            Update_Picture();
        }

        private void BTN_End_Click(object sender, EventArgs e)
        {
            this.BindingContext[myData, "vueJoueur"].Position = myData.Tables[0].Rows.Count - 1;
            Update_Picture();
        }
        #endregion

        private void PN_Player_Picture_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Update_Picture()
        {
            object O = Properties.Resources.ResourceManager.GetObject(TB_Name.Text);
            PN_Player_Picture.BackgroundImage = (Image)O;
            PN_Player_Picture.Refresh();
        }
    }
}
