using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.IO;

namespace TP_Final
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private OracleConnection conn = new OracleConnection();
        private DataSet myData = new DataSet();
        private BindingSource source;
        private Color oddRowColor;
        private Color evenRowColor;
        private string m_Username;
        private string m_Pass;

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Log_In();
            Connect();

            ListDivisions();

            LoadSettings();
            ApplyRowsStyles();

            Initialize_Controls();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////// Affichage de la fenêtre de connection //////////////////////////////////////////
        private void Log_In()
        {
            Log_Form form = new Log_Form();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_Username = form.m_Username;
                m_Pass = form.m_Pass;
            }
            else
            {
                Application.Exit();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////// Initialisation des contrôles à leur état initial ////////////////////////////////////////
        private void Initialize_Controls()
        {
            TB_Search_Player.ForeColor = Color.Gray;
            FB_Remove_Team.Enabled = false;
            FB_Edit_Team.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////// Chargement des réglages /////////////////////////////////////////////////////
        private void LoadSettings()
        {
            DGV_Teams.RowHeadersWidth = Properties.Settings.Default.DGV_Row_Headers_Width;
            oddRowColor = Properties.Settings.Default.OddRowColor;
            evenRowColor = Properties.Settings.Default.EvenRowColor;
            this.Location = Properties.Settings.Default.Main_Form_Location;
            this.Size = Properties.Settings.Default.Main_Form_Size;
            DGV_Teams.Font = Properties.Settings.Default.DGV_Font;

            string[] widthStrings = Properties.Settings.Default.DGV_Column_Width.Split(',');
            if (widthStrings.Count() > 0)
            {
                for (int colIndex = 0; colIndex < DGV_Teams.ColumnCount; colIndex++)
                {
                    DGV_Teams.Columns[colIndex].Width = int.Parse(widthStrings[colIndex]);
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////// Sauvegarde des réglages /////////////////////////////////////////////////////
        private void Save_Settings()
        {
            string widthStrings = "";
            for (int colIndex = 0; colIndex < DGV_Teams.ColumnCount; colIndex++)
            {
                widthStrings += DGV_Teams.Columns[colIndex].Width.ToString();
                if (colIndex < DGV_Teams.ColumnCount - 1)
                    widthStrings += ",";
            }

            Properties.Settings.Default.DGV_Column_Width = widthStrings;
            Properties.Settings.Default.DGV_Row_Headers_Width = DGV_Teams.RowHeadersWidth;
            Properties.Settings.Default.OddRowColor = oddRowColor;
            Properties.Settings.Default.EvenRowColor = evenRowColor;
            Properties.Settings.Default.Main_Form_Location = this.Location;
            Properties.Settings.Default.Main_Form_Size = this.Size;
            Properties.Settings.Default.DGV_Font = DGV_Teams.Font;

            Properties.Settings.Default.Save();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////// Connection à la BD //////////////////////////////////////////////////////////
        private void Connect()
        {
            string Dsource = "(DESCRIPTION=" + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=205.237.244.251)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

            String ChaineConnexion = "Data Source=" + Dsource
            + ";User Id=" + m_Username + ";Password =" + m_Pass;
            conn.ConnectionString = ChaineConnexion;

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            MessageBox.Show("Connecté");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////// Liste les division dans un ListView /////////////////////////////////////////////
        private void ListDivisions()
        {
            try
            {
                LV_Divisions.Items.Clear();
                string sql = "select Nom from division";

                OracleCommand oraCMD = new OracleCommand(sql, conn);
                oraCMD.CommandType = CommandType.Text;

                OracleDataReader oraRead = oraCMD.ExecuteReader();

                while (oraRead.Read())
                {
                    LV_Divisions.Items.Add(oraRead.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////// Gestion du clique du bouton flash d'ajout d'équipe /////////////////////////////////////
        private void FB_Add_Division_Click(object sender, EventArgs e)
        {
            Add_Division_Form form = new Add_Division_Form();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Add_Division(form.m_Division_Name, form.m_Division_Joined);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////// Ajout d'une division dans la BD ////////////////////////////////////////////////
        private void Add_Division(string name, DateTime joined)
        {
            string sqlADD = "insert into division (nom, datecreation) values('" + name + "', " + "to_date('" + joined + "', 'DD-MM-YYYY HH:MI:SS AM'))";

            try
            {
                OracleCommand oraInsert = new OracleCommand(sqlADD, conn);
                oraInsert.CommandType = CommandType.Text;
                oraInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            ListDivisions();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////// Gestion du clique du bouton flash du retrait d'une division ////////////////////////////////////
        private void FB_Remove_Division_Click(object sender, EventArgs e)
        {
            Remove_Division();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////// Retrait d'une division dans la BD //////////////////////////////////////////////////
        private void Remove_Division()
        {
            string sqlDelete = "delete from division where nom = '" + LV_Divisions.SelectedIndices.ToString() + "'";
            try
            {
                OracleCommand oraCMD = new OracleCommand(sqlDelete, conn);
                oraCMD.CommandType = CommandType.Text;
                oraCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            ListDivisions();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////// Gestion du clique du bouton flash d'ajout d'équipe /////////////////////////////////////
        private void FB_Add_Team_Click(object sender, EventArgs e)
        {
            Add_Team_Form form = new Add_Team_Form();

            form.m_Divisions_List = Initialize_Divisions_List();
            form.source = source;


            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Add_Team(form.m_Team_Name, form.m_Team_Joined, form.m_file_Name, form.m_Team_Town, form.m_Team_Division);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////// Gestion du clique du bouton flash d'édition d'équipe ///////////////////////////////////////
        private void FB_Edit_Team_Click(object sender, EventArgs e)
        {
            Edit_Team();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////// Initialisation de la liste des division pour les ComboBox d'ajout d'équipe ////////////////////////////////
        private List<string> Initialize_Divisions_List()
        {
            List<string> temp = new List<string>();

            string sql = "select Nom from division";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            oraCMD.CommandType = CommandType.Text;

            OracleDataReader oraRead = oraCMD.ExecuteReader();

            while (oraRead.Read())
            {
                temp.Add(oraRead.GetString(0));
            }
            return temp;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////// Ajout d'une équipe dans la BD /////////////////////////////////////////////////
        private void Add_Team(string name, DateTime joined, string logo, string town, string division)
        {
            OracleParameter pphoto = new OracleParameter(":photo", OracleDbType.Blob);

            string sqlADD = "insert into equipe (nom, dateintroduction, logo, ville, division) values('" + name + "', " + "to_date('" + joined
                + "','MM-DD-YYYY')" + "," + ":photo" + ",'" + town + "','" + division + "')";

            FileStream Streamp = new FileStream(logo, FileMode.Open, FileAccess.Read);

            byte[] buffer1 = new byte[Streamp.Length];
            Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
            Streamp.Close();

            pphoto.Value = buffer1;

            try
            {
                OracleCommand oraInsert = new OracleCommand(sqlADD, conn);
                oraInsert.CommandType = CommandType.Text;
                oraInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////// Gestion du clique du bouton flash de retrait d'une équipe //////////////////////////////////
        private void FB_Remove_Team_Click(object sender, EventArgs e)
        {
            Remove_Team();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////// Retrait d'une équipe dans la BD ///////////////////////////////////////////////////
        private void Remove_Team()
        {
            string sqlDelete = "delete from equipe where nom = '" + LV_Divisions.SelectedItems[0].SubItems[0].ToString() + "'";

            try
            {
                OracleCommand oraCMD = new OracleCommand(sqlDelete, conn);
                oraCMD.CommandType = CommandType.Text;
                oraCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Gestion de l'option couleur du menu contextuel du DGV_Teams //////////////////////////////////
        private void tsmi_Color_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = (DGV_Teams.SelectedRows[0].Index % 2 == 0 ? evenRowColor : oddRowColor);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (DGV_Teams.SelectedRows[0].Index % 2 == 0)
                    evenRowColor = dlg.Color;
                else
                    oddRowColor = dlg.Color;
                ApplyRowsStyles();

            }
            Save_Settings();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Gestion de l'option police du menu contextuel du DGV_Teams ///////////////////////////////////
        private void tsmi_Font_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.Font = DGV_Teams.Font;
            dlg.Color = DGV_Teams.ForeColor;
            dlg.ShowColor = true;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DGV_Teams.Font = dlg.Font;
                DGV_Teams.ForeColor = dlg.Color;
            }
            Save_Settings();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Gestion de l'option édition du menu contextuel du DGV_Teams //////////////////////////////////
        private void tsmi_Edit_Click(object sender, EventArgs e)
        {
            Edit_Team();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////// Gestion de l'option suppression du menu contextuel du DGV_Teams ////////////////////////////////
        private void tsmi_Delete_Click(object sender, EventArgs e)
        {
            Remove_Team();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////// Gestion de l'option suppression du menu contextuel du LV_Division ///////////////////////////////
        private void tsmi_Remove_Division_Click(object sender, EventArgs e)
        {
            Remove_Division();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////// Application du style des rangées du DGV_Teams //////////////////////////////////////////
        private void ApplyRowsStyles()
        {
            for (int index = 0; index < DGV_Teams.Rows.Count; index++)
            {
                DGV_Teams.Rows[index].DefaultCellStyle.BackColor = (index % 2 == 0 ? evenRowColor : oddRowColor);
            }
            //DGV_Teams.Font = Properties.Settings.Default.DGV_Font;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////// Création du menu contextuel du DGV_Teams///////////////////////////////////////////////////////
        private void DGV_Teams_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGV_Teams.SelectedRows[0].ReadOnly = true;
            if (e.Button == MouseButtons.Right)
            {
                if (DGV_Teams.SelectedRows.Count > 0)
                {

                    ContextMenuStrip cms = new ContextMenuStrip();
                    ToolStripMenuItem tsmi;
                    if (DGV_Teams.RowCount > 1 && DGV_Teams.SelectedRows[0].Index != DGV_Teams.RowCount - 1)
                    {
                        tsmi = new ToolStripMenuItem("Editer l'enregistrement");
                        tsmi.Click += tsmi_Edit_Click;
                        cms.Items.Add(tsmi);

                        tsmi = new ToolStripMenuItem("Effacer l'enregistrement");
                        tsmi.Click += tsmi_Delete_Click;
                        cms.Items.Add(tsmi);
                    }
                    tsmi = new ToolStripMenuItem("Police...");
                    tsmi.Click += tsmi_Font_Click;
                    cms.Items.Add(tsmi);

                    tsmi = new ToolStripMenuItem("Couleur...");
                    tsmi.Click += tsmi_Color_Click;
                    cms.Items.Add(tsmi);

                    cms.Show(DGV_Teams, DGV_Teams.PointToClient(Cursor.Position));
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////// Menu modale des Options /////////////////////////////////////////////////////
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Options_Form m_Options = new Main_Options_Form();

            m_Options.m_EvenRowColor = evenRowColor;
            m_Options.m_OddRowColor = oddRowColor;
            m_Options.m_selectedFont = DGV_Teams.Font;
            m_Options.m_selectedColor = DGV_Teams.ForeColor;
           

            if (m_Options.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                evenRowColor = m_Options.m_EvenRowColor;
                oddRowColor = m_Options.m_OddRowColor;
                DGV_Teams.Font = m_Options.m_selectedFont;
                DGV_Teams.ForeColor = m_Options.m_selectedColor;
                
                ApplyRowsStyles();

                Save_Settings();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////// Affichage de l'aide à l'usager /////////////////////////////////////////////////
        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////// Gestion de la fermeture du form /////////////////////////////////////////////////
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_Settings();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////// Initialisation de la bar de recherche active ////////////////////////////////////////////////
        private void TB_Search_Player_Enter(object sender, EventArgs e)
        {
            TB_Search_Player.Clear();
            TB_Search_Player.ForeColor = Color.Black;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////// Filtrage de la bar de recherche ///////////////////////////////////////////////
        private void TB_Search_Player_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// Gestion du changement de texte de la bar de recherche  ///////////////////////////////////
        private void TB_Search_Player_TextChanged(object sender, EventArgs e)
        {
            SearchPlayer();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////// Recherche d'un joueur ///////////////////////////////////////////////////////
        private void SearchPlayer()
        {
            string sql = "select * from player where nom like '" + TB_Search_Player.Text + "%'";
            try
            {
                OracleCommand oraCMD = new OracleCommand(sql, conn);
                OracleDataReader playerReader = oraCMD.ExecuteReader();
                AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

                while (playerReader.Read())
                {
                    namesCollection.Add(playerReader["Nom"].ToString());
                }
                playerReader.Close();

                TB_Search_Player.AutoCompleteMode = AutoCompleteMode.Suggest;
                TB_Search_Player.AutoCompleteSource = AutoCompleteSource.CustomSource;
                TB_Search_Player.AutoCompleteCustomSource = namesCollection;

                TB_Search_Player.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////// Recherche interne de l'équipe du joueur(pour la requête de recherche du joueur ////////////////////////////
        private string Find_Player_Team()
        {
            string teamName = "";
            string sql = "select equipe from player where nom like '" + TB_Search_Player.Text + "%'";
            try
            {
                OracleCommand oraCMD = new OracleCommand(sql, conn);
                OracleDataReader playerReader = oraCMD.ExecuteReader();

                while (playerReader.Read())
                {
                    teamName = playerReader["Equipe"].ToString();
                }
                playerReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return teamName;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////// Recherche interne de la ville du joueur(pour la requête de recherche du joueur ////////////////////////////
        private string Find_Player_Town(string team)
        {
            string teamTown = "";
            string sql = "select ville from equipe where nom = '" + team + "'";
            try
            {
                OracleCommand oraCMD = new OracleCommand(sql, conn);
                OracleDataReader playerReader = oraCMD.ExecuteReader();

                while (playerReader.Read())
                {
                    teamTown = playerReader["Ville"].ToString();
                }
                playerReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return teamTown;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////// Modification d'une équipe ////////////////////////////////////////////////////
        private void Edit_Team()
        {
            Team_Form form = new Team_Form();

            form.m_TeamName = DGV_Teams.SelectedRows[0].Cells[0].Value.ToString();
            form.m_TeamTown = DGV_Teams.SelectedRows[0].Cells[2].Value.ToString();
            form.oddRowColor = oddRowColor;
            form.evenRowColor = evenRowColor;
            form.conn = conn;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// Gestion du double clique pour afficher une équipe ////////////////////////////////////////
        private void DGV_Teams_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Edit_Team();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////// Validation de la recherche d'un joueur /////////////////////////////////////////////
        private void TB_Search_Player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r' && TB_Search_Player.Text != "")
            {
                Team_Form form = new Team_Form();

                form.m_TeamName = Find_Player_Team();
                form.m_TeamTown = Find_Player_Town(Find_Player_Team());
                form.conn = conn;

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// Réinitialisation de la bar de recherche /////////////////////////////////////////////
        private void TB_Search_Player_Leave(object sender, EventArgs e)
        {
            TB_Search_Player.Text = "Rechercher Joueur";
            TB_Search_Player.ForeColor = Color.Gray;
            TB_Search_Player.Enabled = false;
            TB_Search_Player.Enabled = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////// Réapplique les styles de rangées quand un tri est fait dans le DGV_Teams(sinon ça redevient blanc) ///////////////
        private void DGV_Teams_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ApplyRowsStyles();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////// Rafraîchissement des équipes affichées dans le DGV_Teams ///////////////////////////////////
        private void LV_Divisions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Divisions.SelectedItems.Count > 0)
            {
                myData.Clear();
                string sql = "select nom, dateintroduction,ville from equipe where division = '" + LV_Divisions.SelectedItems[0].SubItems[0].Text + "'";

                OracleCommand oraCMD = new OracleCommand(sql, conn);
                OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

                adapt.Fill(myData, "divisions");

                source = new BindingSource(myData, "divisions");
                DGV_Teams.DataSource = source;
                LoadSettings();
                ApplyRowsStyles();

                if (DGV_Teams.RowCount >= 5)
                    FB_Add_Team.Enabled = false;
                else
                    FB_Add_Team.Enabled = true;
                if (DGV_Teams.RowCount <= 1)
                {
                    FB_Remove_Team.Enabled = false;
                    FB_Edit_Team.Enabled = false;
                }
                else
                {
                    FB_Remove_Team.Enabled = true;
                    FB_Edit_Team.Enabled = true;
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////// Création du menu contextuel du LV_Divisions ////////////////////////////////////////////
        private void LV_Divisions_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                ToolStripMenuItem tsmi = new ToolStripMenuItem("Effacer Enregistrement");
                tsmi.Click += tsmi_Remove_Division_Click;

                cms.Items.Add(tsmi);

                cms.Show(LV_Divisions, LV_Divisions.PointToClient(Cursor.Position));
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////// Prévient l'édition des cellules du DGV_Teams(intégrité des données) /////////////////////////////////
        private void DGV_Teams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_Teams.Rows[e.RowIndex].ReadOnly = true;
            if (DGV_Teams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                DGV_Teams.Rows[e.RowIndex].ReadOnly = false;
            }
        }
    }
}

/*   //AJOUTER UNE IMAGE DANS LA BD
     try
            {
                OracleCommand oraIns = new OracleCommand("insert into employes (nom, prenom,photo)values(:nom,:prenom,:photo)", conn);
               
                OracleParameter pnom = new OracleParameter(":nom", OracleDbType.NVarchar2, 30);
                OracleParameter pprenom = new OracleParameter(":prenom", OracleDbType.NVarchar2, 30);
                OracleParameter pphoto = new OracleParameter(":photo", OracleDbType.Blob);
                
                pnom.Value = textNom.Text;
                pprenom.Value = textpRN.Text;
       
                oraIns.Parameters.Add(pnom);
                oraIns.Parameters.Add(pprenom);

                // récuper le fichier nomFichier et le convertir en Byte. 
                //le résultat est dans buffer1
                // oracle stocke les images sous forme de Bytes.
                FileStream Streamp = new FileStream(nomFichier, FileMode.Open, FileAccess.Read);
                byte[] buffer1 = new byte[Streamp.Length];
                Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
                Streamp.Close();
                // ajout de la photo dans la BD.

                pphoto.Value = buffer1;
                oraIns.Parameters.Add(pphoto);

                oraIns.ExecuteNonQuery();
                 Vider();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
*/