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
using Oracle.DataAccess.Types;
using System.IO;
/*
 * Hockey Manager 2013
 * but: gère le contrôle des divisions, équipes et joueurs à partir d'une BD
 * 
 * par Charles Hunter-Roy et Mathieu Dumoulin, 2013
 * */
namespace TP_Final
{
    public partial class Main_Form : Form
    {

        public Main_Form()
        {
            InitializeComponent();
        }

        #region "Attributs privés"

        private OracleConnection conn = new OracleConnection();
        private DataSet myData = new DataSet();
        private BindingSource source;
        private Color oddRowColor;
        private Color evenRowColor;
        private string m_Username;
        private string m_Pass;
        private const int MAX_TEAMS = 4;
        #endregion

        #region "Texte du StatusStrip"

        private string Txt_AddTeam = "Tips: Clique gauche pour ouvrir un dialogue qui permet  d'ajouter une équipe à cette division.";
        private string Txt_RemoveTeam = "Tips: Clique gauche pour effacer l'équipe selectionnée de la division choisie.";
        private string Txt_ShowTeam = "Tips: Clique gauche pour ouvrir une fenêtre qui affiche tous les joueurs de l'équipe sélectionnée dans la grille Équipe.";
        private string Txt_RemoveDivision = "Tips: Clique gauche pour retirer une division de la base de données.";
        private string Txt_AddDivision = "Tips: Clique gauche pour ouvrir un dialogue qui vous permet d'ajouter une division dans ce conteneur.";
        private string Txt_LogoScroller = "Tips: Clique gauche sur un logo pour afficher les joueurs de l'équipe correspondante au logo dans une autre fenêtre";
        private string Txt_DGV_TeamOver = "Tips: Double clique sur l'entête d'une rangée d'une équipe pour afficher ses joueurs dans une autre fenêtre.";
        private string Txt_LB_Divisions = "Tips: Choisissez une division à l'aide d'un clique gauche pour qu'elle affiche ses équipes dans la grille d'équipe.";


        #endregion
        ////////////////////////////////////////////// Au Chargement de la page ///////////////////////////////////////////
        private void Main_Form_Load(object sender, EventArgs e)
        {
            //Log_In();
            Connect();

            ListDivisions();

            LoadSettings();

            Initialize_Controls();
            Initialize_LogoScroller();
            ApplyRowsStyles();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Initialisations"
        ////////////////////////////////////////////// Ajout des images dans le LogoScroller ///////////////////////////////////////////
        private void Initialize_LogoScroller()
        {
            string sql = "select logo, nom from equipe";
            Image unLogo;
            try
            {
                OracleCommand oraCMD = new OracleCommand(sql, conn);
                oraCMD.CommandType = CommandType.Text;

                OracleDataReader oraRead = oraCMD.ExecuteReader();

                while (oraRead.Read())
                {
                    if (oraRead.GetValue(0).ToString() != "")
                    {
                        // Création d'une variable locale blob
                        OracleBlob blob = oraRead.GetOracleBlob(0);
                        // Convertion du blob en tableau de bytes
                        byte[] myByteArray = new Byte[blob.Length];
                        
                        int i = blob.Read(myByteArray,0,System.Convert.ToInt32(blob.Length));
                        
                        // Création d'un stream pour convertir le ByteAray en Image
                        MemoryStream memStream = new MemoryStream(myByteArray);
                        unLogo = Image.FromStream(memStream);
                        LS_Logos.AddElement(unLogo, oraRead.GetValue(1).ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void MouseClick(string NomElement, string TownName, string DivName)
        {
            Team_Form dlg = new Team_Form();

            dlg.m_Division = DivName;
            dlg.m_TeamName = NomElement;
            dlg.m_TeamTown = TownName;

            dlg.oddRowColor = oddRowColor;
            dlg.evenRowColor = evenRowColor;
            dlg.conn = conn;


            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LS_Logos.EditElement(dlg.m_TeamName, dlg.Image_LogoScroller);
                Update_Team(dlg.m_TeamTown, dlg.m_TeamName, dlg.m_Division);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////// Initialisation des contrôles à leur état initial ////////////////////////////////////////
        private void Initialize_Controls()
        {
            TB_Search_Player.ForeColor = Color.Gray;
            FB_Remove_Team.Enabled = false;
            FB_Edit_Team.Enabled = false;
            FB_Add_Team.Enabled = false;

            if (LB_Divisions.Controls.Count == 0)
                FB_Remove_Division.Enabled = false;
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
        //////////////////// Initialisation du DGV d'affichage des équipes de la division présentement sélectionnée ///////////////////
        private void InitializeDGV()
        {
            myData.Clear();
            string sql = "select nom, dateintroduction, ville, division from equipe where division = '" + LB_Divisions.SelectedItem.ToString() + "'";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.Fill(myData, "divisions");

            source = new BindingSource(myData, "divisions");
            DGV_Teams.DataSource = source;
            Resize_DGV_Teams();
            //LoadSettings();
            ApplyRowsStyles();
            DGV_Teams.AllowUserToAddRows = false;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////// Liste les division dans un ListView /////////////////////////////////////////////
        private void ListDivisions()
        {
            try
            {
                LB_Divisions.Items.Clear();
                string sql = "select Nom from division";

                OracleCommand oraCMD = new OracleCommand(sql, conn);
                oraCMD.CommandType = CommandType.Text;

                OracleDataReader oraRead = oraCMD.ExecuteReader();

                while (oraRead.Read())
                {
                    LB_Divisions.Items.Add(oraRead.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            FB_Remove_Division.Enabled = false;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion
        #region "Settings"
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////// Chargement des réglages /////////////////////////////////////////////////////
        private void LoadSettings()
        {
            DGV_Teams.RowHeadersWidth = Properties.Settings.Default.DGV_Row_Headers_Width;
            oddRowColor = TP_Final.Properties.Settings.Default.OddRowColor;
            evenRowColor = TP_Final.Properties.Settings.Default.EvenRowColor;
            this.Location = TP_Final.Properties.Settings.Default.Main_Form_Location;
            this.Size = TP_Final.Properties.Settings.Default.Main_Form_Size;
            DGV_Teams.Font = TP_Final.Properties.Settings.Default.DGV_Font;

            string[] widthStrings = Properties.Settings.Default.DGV_Column_Width.Split(',');
            if (widthStrings.Count() > 0)
            {
                for (int colIndex = 0; colIndex < DGV_Teams.ColumnCount; colIndex++)
                {
                  // DGV_Teams.Columns[colIndex].Width = int.Parse(widthStrings[colIndex]);
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
        #endregion
        #region "Connection"
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
        ////////////////////////////////////////////////// Connection à la BD //////////////////////////////////////////////////////////
        private void Connect()
        {
            string Dsource = "(DESCRIPTION=" + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=205.237.244.251)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

            String ChaineConnexion = "Data Source=" + Dsource
            + ";User Id= hunterro;Password =oracle1";
            conn.ConnectionString = ChaineConnexion;

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Application.Exit();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion
        #region Flash_buttons
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
        /////////////////////////////// Gestion du clique du bouton flash du retrait d'une division ////////////////////////////////////
        private void FB_Remove_Division_Click(object sender, EventArgs e)
        {
            DeleteForm dlg = new DeleteForm();

            dlg.ElementSupprime = "la division " + LB_Divisions.SelectedItem.ToString();

            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Remove_Division();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////// Gestion du clique du bouton flash de retrait d'une équipe //////////////////////////////////
        private void FB_Remove_Team_Click(object sender, EventArgs e)
        {
            DeleteForm dlg = new DeleteForm();

            dlg.ElementSupprime = "les " + DGV_Teams.SelectedRows[0].Cells[0].Value.ToString() + " de cette division";

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Remove_Team();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion
        #region Fonctions_flash_buttons
        /////////////////////////////////////////////// Ajout d'une division dans la BD ////////////////////////////////////////////////
        private void Add_Division(string name, DateTime joined)
        {
            OracleParameter pname = new OracleParameter(":nom", OracleDbType.Varchar2, 20);
            OracleParameter pdate = new OracleParameter(":date", OracleDbType.Date);

            string sqlADD = "insert into division (nom, datecreation) values(:pname, to_date(:pdate, 'DD-MM-YYYY'))";

            pname.Value = name;
            pdate.Value = joined;

            try
            {
                OracleCommand oraInsert = new OracleCommand(sqlADD, conn);

                oraInsert.Parameters.Add(pname);
                oraInsert.Parameters.Add(pdate);
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
        /////////////////////////////////////////// Retrait d'une division dans la BD //////////////////////////////////////////////////
        private void Remove_Division()
        { 
            string sqlDelete = "delete from division where nom = '" + LB_Divisions.SelectedItem.ToString()+ "'";
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
                Add_Team(form.m_Team_Name, form.m_Team_Joined, form.m_file_Name, form.m_Team_Town, LB_Divisions.SelectedItem.ToString());
                LS_Logos.AddElement(form.m_file_Name, form.m_Team_Name);  
            }

                        
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////// Gestion du clique du bouton flash d'édition d'équipe ///////////////////////////////////////
        private void FB_Edit_Team_Click(object sender, EventArgs e)
        {
            Edit_Team();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////// Ajout d'une équipe dans la BD /////////////////////////////////////////////////
        private void Add_Team(string name, DateTime joined, string logo, string town, string division)
        { 
            OracleParameter pname = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
            OracleParameter pcreation = new OracleParameter(":creation", OracleDbType.Date);
            OracleParameter pphoto = new OracleParameter(":photo", OracleDbType.Blob);           
            OracleParameter ptown = new OracleParameter(":ville", OracleDbType.Varchar2, 30);
            OracleParameter pdivision = new OracleParameter(":division", OracleDbType.Varchar2, 20);           

            string sqlADD = "insert into equipe (nom, dateintroduction, logo, ville, division) values(:nom, to_date(:creation,'DD-MM-YYYY'), :photo, :ville, :division)";

            FileStream Streamp = new FileStream(logo, FileMode.Open, FileAccess.Read);

            byte[] buffer1 = new byte[Streamp.Length];
            Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
            Streamp.Close();

            pname.Value = name;
            pcreation.Value = joined;
            pphoto.Value = buffer1;            
            ptown.Value = town;
            pdivision.Value = division;
            
            try
            {
                OracleCommand oraInsert = new OracleCommand(sqlADD, conn);
                oraInsert.Parameters.Add(pname);
                oraInsert.Parameters.Add(pcreation);
                oraInsert.Parameters.Add(pphoto);
                oraInsert.Parameters.Add(ptown);
                oraInsert.Parameters.Add(pdivision);

                oraInsert.CommandType = CommandType.Text;
                oraInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            InitializeDGV();

            if (DGV_Teams.RowCount > 0 && DGV_Teams.RowCount < MAX_TEAMS)
            {
                FB_Remove_Team.Enabled = true;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////// Retrait d'une équipe dans la BD ///////////////////////////////////////////////////
        private void Remove_Team()
        { 
            LS_Logos.RemoveElement(DGV_Teams.SelectedRows[0].Cells[0].Value.ToString());
            string sqlDelete = "delete from equipe where nom = '" + DGV_Teams.SelectedRows[0].Cells[0].Value.ToString() + "'";

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
            InitializeDGV();
            if (DGV_Teams.RowCount == 0)
            {
                FB_Remove_Team.Enabled = false;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////// Modification d'une équipe ////////////////////////////////////////////////////
        private void Edit_Team()
        {
            Team_Form form = new Team_Form();

            form.m_TeamName = DGV_Teams.SelectedRows[0].Cells[0].Value.ToString();
            form.m_TeamTown = DGV_Teams.SelectedRows[0].Cells[2].Value.ToString();
            form.m_Division = DGV_Teams.SelectedRows[0].Cells[3].Value.ToString();

            form.oddRowColor = oddRowColor;
            form.evenRowColor = evenRowColor;
            form.conn = conn;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LS_Logos.EditElement(form.m_TeamName, form.Image_LogoScroller);
                Update_Team(form.m_TeamTown,form.m_TeamName, form.m_Division);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////// Ajuste le DGV pour qu'il soit de la même taille que son contrôle parent ///////////////////////
        private void Resize_DGV_Teams()
        {
            foreach (DataGridViewColumn Col in DGV_Teams.Columns)
            {
                Col.Width = DGV_Teams.Size.Width / DGV_Teams.ColumnCount;
            }
        }

        private void Update_Team(string town, string team, string division)
        {
            OracleParameter ptown = new OracleParameter(":ville", OracleDbType.Varchar2, 30);
            OracleParameter pteam = new OracleParameter(":equipe", OracleDbType.Varchar2, 30);
            OracleParameter pdivision = new OracleParameter(":division", OracleDbType.Varchar2, 20);

            string sqlUpdate = "BEGIN update equipe set ville = :ville where nom = :equipe;" + 
                "update equipe set division = :division where nom = :equipe; END; ";

            OracleCommand oraCMD = new OracleCommand(sqlUpdate, conn);
            oraCMD.CommandType = CommandType.Text;

            ptown.Value = town;
            pteam.Value = team;
            pdivision.Value = division;

            try
            {
                oraCMD.Parameters.Add(ptown);
                oraCMD.Parameters.Add(pteam);
                oraCMD.Parameters.Add(pdivision);

                oraCMD.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #region Menus_contextuels
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
        ////////////////////////////// Gestion de l'option suppression du menu contextuel du LB_Division ///////////////////////////////
        private void tsmi_Remove_Division_Click(object sender, EventArgs e)
        {
            Remove_Division();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #endregion
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
            FB_Edit_Team.Enabled = true;

            if (e.Button == MouseButtons.Right)
            {
                if (DGV_Teams.SelectedRows.Count > 0)
                {
                    ContextMenuStrip cms = new ContextMenuStrip();
                    ToolStripMenuItem tsmi;
                    if (DGV_Teams.RowCount > 1 && DGV_Teams.SelectedRows[0].Index != DGV_Teams.RowCount - 1)
                    {
                        tsmi = new ToolStripMenuItem("Modifier l'enregistrement");
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
        #region bar_recherche
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
            string sql = "select * from player where nom like '" + TB_Search_Player.Text + "%'" + 
                "UNION select * from player where prenom like '" + TB_Search_Player.Text + "%' ";
            try
            {
                OracleCommand oraCMD = new OracleCommand(sql, conn);
                OracleDataReader playerReader = oraCMD.ExecuteReader();
                AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

                while (playerReader.Read())
                {
                    namesCollection.Add(playerReader["Nom"].ToString());
                    namesCollection.Add(playerReader["Prenom"].ToString());
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
        private string Find_Player_Division(string team)
        {
            string playerDivision = "";
            string sql = "select division from equipe where nom = '" + team + "'";
            try
            {
                OracleCommand oraCMD = new OracleCommand(sql, conn);
                OracleDataReader playerReader = oraCMD.ExecuteReader();

                while (playerReader.Read())
                {
                    playerDivision = playerReader["Division"].ToString();
                }
                playerReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return playerDivision;
        }
        /////////////////////////////////////////// Validation de la recherche d'un joueur /////////////////////////////////////////////
        private void TB_Search_Player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r' && TB_Search_Player.Text != "")
            {
                Team_Form form = new Team_Form();

                form.m_TeamName = Find_Player_Team();
                form.m_TeamTown = Find_Player_Town(Find_Player_Team());
                form.m_Division = Find_Player_Division(Find_Player_Team());
                form.m_Divisions_List = Initialize_Divisions_List();
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
        #endregion
        ///////////////////////////////////// Gestion du double clique pour afficher une équipe ////////////////////////////////////////
        private void DGV_Teams_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Edit_Team();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////// Réapplique les styles de rangées quand un tri est fait dans le DGV_Teams(sinon ça redevient blanc) ///////////////
        private void DGV_Teams_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ApplyRowsStyles();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////// Prévient l'édition des cellules du DGV_Teams(intégrité des données) /////////////////////////////////
        private void DGV_Teams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Form_SizeChanged(object sender, EventArgs e)
        {
             LBL_Team.Location = new Point(DGV_Teams.Location.X + (DGV_Teams.Size.Width - LBL_Team.Size.Width) / 2, DGV_Teams.Location.Y - LBL_Team.Size.Height);
        }

        #region "Show Tips in SL_Tips"
        private void DGV_Teams_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_DGV_TeamOver;
        }
        private void LB_Divisions_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_LB_Divisions;
        } 
        private void logoScroller1_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_LogoScroller;
        }
        private void FB_Add_Division_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_AddDivision;
        }
        private void FB_Remove_Division_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_RemoveDivision;
        }
        private void FB_Edit_Team_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_ShowTeam;
        } 
        private void FB_Add_Team_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_AddTeam;
        }
        private void FB_Remove_Team_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_RemoveTeam;
        }

        #endregion

        #region "Vider le SL_Tips"
        private void Empty_StatusStrip()
        {
            SL_Tips.Text = "";
        }
        private void DGV_Teams_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }
        private void LB_Divisions_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }
        private void logoScroller1_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }
        private void FB_Add_Division_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        } 
        private void FB_Remove_Division_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        } 
        private void FB_Edit_Team_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }
        private void FB_Add_Team_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        } 
        private void FB_Remove_Team_MouseLeave(object sender, EventArgs e)
        {
            Empty_StatusStrip();
        }
        #endregion

        private void LS_Logos_Load(object sender, EventArgs e)
        {
           
        }
        private void Main_Form_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Main_Form_Location = this.Location;
        }

        private void DGV_Teams_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            foreach (DataGridViewRow row in DGV_Teams.SelectedRows)
            {
                row.Height = e.Row.Height;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////// Rafraîchissement des équipes affichées dans le DGV_Teams ///////////////////////////////////
        private void LB_Divisions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Divisions.SelectedItems.Count > 0)
            {
                InitializeDGV();

                if (DGV_Teams.RowCount > MAX_TEAMS)
                    FB_Add_Team.Enabled = false;
                else
                    FB_Add_Team.Enabled = true;
                if (DGV_Teams.RowCount <= 0)
                {
                    FB_Remove_Team.Enabled = false;
                    FB_Edit_Team.Enabled = false;
                    FB_Add_Team.Enabled = false;
                }
                else
                {
                    FB_Remove_Team.Enabled = true;
                    FB_Edit_Team.Enabled = true;
                    FB_Add_Team.Enabled = true;
                }
                FB_Remove_Division.Enabled = true;
            }
            else
            {
                FB_Remove_Division.Enabled = false;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////// Création du menu contextuel du LB_Divisions ////////////////////////////////////////////
        private void LB_Divisions_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                ToolStripMenuItem tsmi = new ToolStripMenuItem("Effacer Enregistrement");
                tsmi.Click += tsmi_Remove_Division_Click;

                cms.Items.Add(tsmi);

                cms.Show(LB_Divisions, LB_Divisions.PointToClient(Cursor.Position));
            }
        }

        private void DGV_Teams_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void LS_Logos_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
