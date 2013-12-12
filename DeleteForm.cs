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
    public partial class DeleteForm : Form
    {
        public string ElementSupprime;
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void FB_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void FB_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            ElementSupprime += "?";
            LBL_ElementSupprime.Text = ElementSupprime;
        }
    }
}
