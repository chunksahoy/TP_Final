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
    public partial class Add_Division_Form : Form
    {
        public Add_Division_Form()
        {
            InitializeComponent();
        }

        public string m_Division_Name;
        public DateTime m_Division_Joined;

        private void SaveSettings()
        {
            m_Division_Name = TB_Division_Name.Text;
            m_Division_Joined = DTP_Division_Join.Value;
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void TB_Division_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
