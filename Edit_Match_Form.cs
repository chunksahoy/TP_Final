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
    public partial class Edit_Match_Form : Form
    {
        public Edit_Match_Form()
        {
            InitializeComponent();
        }

        public string m_Stadium;
        public DateTime m_Date;

        private void Initialize_Stats()
        {
            TB_Stadium.Text = m_Stadium;
            DTP_Date.Value = DateTime.Parse(m_Date.ToLongDateString());
        }

        private void Edit_Match_Form_Load(object sender, EventArgs e)
        {
            Initialize_Stats();
        }

        private void TB_Stadium_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            m_Stadium = TB_Stadium.Text;
            m_Date = DTP_Date.Value;
        }
    }
}
