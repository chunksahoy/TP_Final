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
    public partial class Edit_Player_Form : Form
    {
        public Edit_Player_Form()
        {
            InitializeComponent();
        }

        public string m_Name;
        public string m_Surname;
        public int m_Jersey;
        private string[] m_Positions_List = { "ATTAQUANT", "DEFENSE", "GARDIEN" };
        public string m_Position;
        public DateTime m_Birth;
        public string m_file_Name;
        
        private void Edit_Player_Form_Load(object sender, EventArgs e)
        {
            Initialize_Controls();
        }

        private void Initialize_Picture()
        {
            object O = Properties.Resources.ResourceManager.GetObject(m_Name);
            PB_Player_Picture.BackgroundImage = (Image)O;
            PB_Player_Picture.Refresh();
        }

        private void Initialize_Positions_List()
        {
            foreach (string position in m_Positions_List)
            {
                CBX_Position.Items.Add(position);
            }
        }

        private void Initialize_Controls()
        {
            Initialize_Picture();
            Initialize_Positions_List();
            CBX_Position.SelectedItem = m_Position;
            TB_Surname.Text = m_Surname;
            TB_Name.Text = m_Name;
            DTP_Birth.Value = DateTime.Parse(m_Birth.ToLongDateString());
            NUD_Jersey.Value = m_Jersey;
        }

        private void Save_Settings()
        {
            m_Surname = TB_Surname.Text;
            m_Name = TB_Name.Text;
            m_Birth = DTP_Birth.Value;
            m_Position = CBX_Position.SelectedItem.ToString();
            m_Jersey = int.Parse(NUD_Jersey.Value.ToString());
        }

        private void TB_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TB_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BTN_Browse_Pitcures_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Sélectionner une image";
            dlg.CheckFileExists = true;
            dlg.InitialDirectory = @":C\";

            dlg.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_file_Name = dlg.FileName;
                Bitmap bitmap1 = new Bitmap(m_file_Name);
                PB_Player_Picture.Image = bitmap1;
                PB_Player_Picture.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                m_file_Name = null;
            }
        }
    }
}
