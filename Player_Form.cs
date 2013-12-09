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

        private void Save_Stats()
        {
            m_Player_Position = TB_Player_Position.Text;
            m_Player_Goals = int.Parse(TB_Player_Goals.Text);
            m_Player_Pass = int.Parse(TB_Player_Pass.Text);

            m_Player_Punitions = int.Parse(TB_Player_Penalty.Text);
        }

        private void Load_Stats()
        {
            TB_Player_Position.Text = m_Player_Position;
            TB_Player_Goals.Text = m_Player_Goals.ToString();
            TB_Player_Pass.Text = m_Player_Pass.ToString();
            TB_Player_Points.Text = m_Player_Points.ToString();
            TB_Player_Penalty.Text = m_Player_Punitions.ToString();
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

        private void PN_Player_Picture_Paint(object sender, PaintEventArgs e)
        {
            //object O = Properties.Resources.ResourceManager.GetObject(textBox.Text);
            //channelPic.Image = (Image)O;
           // this.Refresh();
        }

        private void Player_Form_Load(object sender, EventArgs e)
        {
            TB_Player_Position.Text = m_Player_Position;
            TB_Player_Goals.Text = m_Player_Goals.ToString();
            TB_Player_Pass.Text = m_Player_Pass.ToString();
            TB_Player_Points.Text = m_Player_Points.ToString();
            TB_Player_Penalty.Text = m_Player_Punitions.ToString();

        }
    }
}
