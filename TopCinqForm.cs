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
    public partial class TopCinqForm : Form
    {
        public TopCinqForm()
        {
            InitializeComponent();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Form dlg = new Help_Form();
            dlg.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Options_Form dlg = new Main_Options_Form();

            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
