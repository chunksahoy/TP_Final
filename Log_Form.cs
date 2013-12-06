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
    public partial class Log_Form : Form
    {
        public Log_Form()
        {
            InitializeComponent();
        }
        public string m_Username;
        public string m_Pass;

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            m_Username = TB_User.Text;
            m_Pass = TB_Pass.Text;
        }

        private void TB_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void Log_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
