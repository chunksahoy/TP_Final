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
    public partial class Add_Player_Form : Form
    {
        public Add_Player_Form()
        {
            InitializeComponent();
        }

        public DataSet myData = new DataSet();
        public BindingSource source;
        private Panel_Image_Setting playerImage;


        public string m_PlayerName;
        public DateTime m_Player_Birth;
        public string m_PlayerSurname;
        public int m_PlayerJersey;
        public Image m_PlayerPhoto;
        public string m_PlayerPosition;
        private string[] m_Positions_List = { "ATTAQUANT", "DEFENSE", "GARDIEN"};
        string m_file_Name;



        private void Add_Player_Form_Load(object sender, EventArgs e)
        {
            Initialize_Positions_List();
            UpdateTextBoxes();
            playerImage = new Panel_Image_Setting();
            
            //this.DataBindings.Add(new Binding("BackgroundImage", playerImage, "BackgroundImage"));
        }

        private void Initialize_Positions_List()
        {
            foreach (string position in m_Positions_List)
            {
                CBX_Player_Role.Items.Add(position);
            }
        }

        private void UpdatePlayer()
        {
            m_PlayerName = TB_Player_Name.Text;
            m_PlayerSurname = TB_Player_Surname.Text;
            m_Player_Birth = DTP_Player_Birth.Value;
            m_PlayerJersey = (int)NUD_Jersey_Number.Value;
            m_PlayerPosition = CBX_Player_Role.SelectedItem.ToString();
            m_PlayerPhoto = PN_Player_Picture.BackgroundImage;
        }

        private void UpdateTextBoxes()
        {
            //TB_Player_Name.DataBindings.Add("Text", myData, "joueur.nom");
            //TB_Player_Surname.DataBindings.Add("Text", myData, "joueur.prenom");
            //CBX_Player_Role.DataBindings.Add("Text", myData, "joueur.role");
        }

        private void TB_Player_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
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

            dlg.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_file_Name = dlg.FileName;
                Bitmap bitmap1 = new Bitmap(m_file_Name);
                PN_Player_Picture.BackgroundImage = bitmap1;
                PN_Player_Picture.BackgroundImageLayout = ImageLayout.Stretch;

                playerImage.BackgroundImage = bitmap1;

            }
            else
            {
                m_file_Name = null;
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            UpdatePlayer();
        }

        private void PN_Player_Picture_Paint(object sender, PaintEventArgs e)
        {
            //object O = Properties.Resources.ResourceManager.GetObject(m_file_Name);
            //PN_Player_Picture.BackgroundImage = (Image)O;
            //this.Refresh();
        }

    }
}
