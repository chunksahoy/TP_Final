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
    public partial class TopCinqForm : Form
    {
        public TopCinqForm()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        public OracleConnection conn;
        private DataSet myData = new DataSet();
        public BindingSource source;
        private void TopCinqForm_Load(object sender, EventArgs e)
        {
            Initialize_DGV();
        }
        private void Initialize_DGV()
        {
            myData.Clear();
            string sql = "select * from vueJoueur where rownum <= 5";

            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            try
            {  
                adapt.Fill(myData, "top5");
                source = new BindingSource(myData, "top5");
                DGV_Top5.DataSource = source;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
=======

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

>>>>>>> 29c67e3052ffd8dd24660743cd4107fe56a24415
            }
        }
    }
}
