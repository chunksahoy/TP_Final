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
    public partial class Add_Team_Form : Form
    {
        public Add_Team_Form()
        {
            InitializeComponent();
        }
        public string m_Team_Name;
        public DateTime m_Team_Joined;
        public Image m_Team_Logo;
        public string m_Team_Town;
        public string m_Team_Division;
        public string m_file_Name;
        public BindingSource source;

        public List<string> m_Divisions_List = new List<string>();


        private void TB_Team_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TB_Team_Town_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            Save_Settings();
        }

        private void Save_Settings()
        {
            m_Team_Name = TB_Team_Name.Text.ToString();
            m_Team_Joined = DTP_Team_Join.Value;
            m_Team_Logo = PN_Team_Logo.BackgroundImage;
            m_Team_Town = TB_Team_Town.Text.ToString();
        }

        private void BTN_Browse_Logos_Click(object sender, EventArgs e)
        {
            Search_Image();
        }
        private void Search_Image()
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Sélectionner une image";
            dlg.CheckFileExists = true;
            dlg.InitialDirectory = @":C\";

            dlg.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF; *.PNG)|*.BMP;*.JPG;*.GIF; *.PNG|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_file_Name = dlg.FileName;
                Bitmap bitmap1 = new Bitmap(m_file_Name);
                PN_Team_Logo.BackgroundImage = bitmap1;
                PN_Team_Logo.BackgroundImageLayout = ImageLayout.Stretch;

            }
            else
            {
                m_file_Name = null;
            }
        }
        private void Add_Team_Form_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.AddTeam_Location;
        }

        private void Add_Team_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.AddTeam_Location = this.Location;
        }
    }
}
