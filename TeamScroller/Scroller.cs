using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TeamScroller
{
    public partial class Scroller: UserControl
    {
        public Scroller()
        {
            InitializeComponent();
        }
        public OracleConnection conn;
        public DataSet myData = new DataSet();
        public BindingSource source;

        private void BTN_Begin_Click(object sender, EventArgs e)
        {
            this.BindingContext[myData, "fichepersonnelle"].Position = 0;
        }

        private void BTN_Previous_Click(object sender, EventArgs e)
        {
            this.BindingContext[myData, "fichepersonnelle"].Position -= 1;
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            this.BindingContext[myData, "fichepersonnelle"].Position += 1;
        }

        private void BTN_End_Click(object sender, EventArgs e)
        {
            this.BindingContext[myData, "fichepersonnelle"].Position = myData.Tables[0].Rows.Count - 1;
        }

    }
}
