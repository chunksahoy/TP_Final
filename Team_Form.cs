using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_Final
{
    public partial class Team_Form : Form
    {
        #region "StatusStrip text"
        private string Txt_CancelChanges = "Tips: Clique gauche pour annuler les changements faits et quitter la fenêtre.";
        private string Txt_AcceptChanges = "Tips: Clique gauche pour confirmer et appliquer les changements au niveau de la base de données et quitter la fenêtre.";
        private string Txt_ShowCalendar = "Tips: Clique gauche pour afficher la grille des parties de la saison pour cette équipe.";
        private string Txt_EditPlayer = "Tips: Clique gauche pour afficher les statistiques et les modifier du joueur sélectionné";
        private string Txt_RemovePlayer = "Tips: Clique gauche pour retirer le joueur sélectionné de cette équipe.";
        private string Txt_AddPlayers = "Tips: Clique gauche pour ouvrir une fenêtre qui vous permet d'ajouter un joueur à cette équipe.";
        private string Txt_DGV_Players = "Tips: Double clique sur l'entête d'une rangée d'un joueur pour afficher ses statistiques dans une autre fenêtre.";
        private string Txt_ChangeTeamName = "Tips: Écrivez une nouvelle ville et appuyez sur la touche 'Enter' pour changer définitivement le nom de la ville de cette équipe.";
        private string Txt_ChargeDivisionName = "Tips: Choisissez une division pour changer la division dans laquelle se trouve cette équipe.";
        private string Txt_ChangeImage = "Tips: Clique gauche sur ce logo pour ouvrir un dialogue qui vous permet de remplacer le logo de cette équipe par celui que vous avez choisi.";
        private string Txt_LBL_TeamName = "Tips: Clique gauche pour modifier définitivement la ville de cette équipe.";
        private string Txt_LBL_DivisionName = "Tips: Clique gauche pour changer la division de cette équipe.";
        #endregion

        public Team_Form()
        {
            InitializeComponent();
        }

        #region "Attributs privés"
        private DataSet myData = new DataSet();
        private BindingSource source;
        private Color oddRowColor;
        private Color evenRowColor;
        private Font Font_DGV;
        private Color Font_DGV_Color;
        #endregion
        #region "Attributs publics"
        public OracleConnection conn;
        public int m_Selected_Index;
        public string m_Logo_File_Path;
        public byte[] image;
        public string Image_LogoScroller;
<<<<<<< HEAD
        private List<int> playersNumber;
=======
        public string m_TeamName;
        public string m_TeamTown;
        public string m_Division;
        public List<string> m_Divisions_List;
        #endregion
>>>>>>> 29c67e3052ffd8dd24660743cd4107fe56a24415

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Options_Form form = new Main_Options_Form();

            form.m_EvenRowColor = evenRowColor;
            form.m_OddRowColor = oddRowColor;
            form.m_selectedFont = Font_DGV;
            form.m_SelectedFont_Color = Font_DGV_Color;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                evenRowColor = form.m_EvenRowColor;
                oddRowColor = form.m_OddRowColor;
                Font_DGV = form.m_selectedFont;
                Font_DGV_Color = form.m_SelectedFont_Color;
                UpdateControls();
            }
        }

        private void UpdateControls()
        {
            DGV_Players.Font = Font_DGV;
            DGV_Players.ForeColor = Font_DGV_Color;
            ApplyRowsStyles();
            DGV_Players.Refresh();
        }

        private void Team_Form_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.Team_Form_Location;
            InitializeTitle();
            Get_Players_Number(m_TeamName);
            InitializeDataGrid();
            RefreshLogo();
            LoadSettings();

            Resize_DGV_Players();
            Image_LogoScroller = "";
            m_Divisions_List = Initialize_Divisions_List();
            Initialize_Hidden_Updates();

        }

        private void Resize_DGV_Players()
        {
            foreach (DataGridViewColumn Col in DGV_Players.Columns)
            {
                Col.Width = (DGV_Players.Size.Width - DGV_Players.RowHeadersWidth ) / DGV_Players.ColumnCount;
            }
        }

        private void Initialize_Hidden_Updates()
        {
            TB_Town.Visible = false;
            CBX_Division.Visible = false;

            foreach (string division in m_Divisions_List)
            {
                CBX_Division.Items.Add(division);
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Team_OddRowColor = oddRowColor;
            Properties.Settings.Default.Team_EvenRowColor = evenRowColor;
            Properties.Settings.Default.Team_Form_Location = this.Location;
            Properties.Settings.Default.Team_Form_Size = this.Size;
            Properties.Settings.Default.Team_Form_Font = DGV_Players.Font;
            Properties.Settings.Default.Team_Form_Font = Font_DGV;
            Properties.Settings.Default.Team_Form_FontColor = Font_DGV_Color;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            oddRowColor = Properties.Settings.Default.Team_OddRowColor;
            evenRowColor = Properties.Settings.Default.Team_EvenRowColor;
            Font_DGV = Properties.Settings.Default.Team_Form_Font;
            Font_DGV_Color = Properties.Settings.Default.Team_Form_FontColor;
            this.Location = Properties.Settings.Default.Team_Form_Location;
            this.Size = Properties.Settings.Default.Team_Form_Size;
        }

        private void ApplyRowsStyles()
        {
            for (int index = 0; index < DGV_Players.Rows.Count; index++)
            {
                DGV_Players.Rows[index].DefaultCellStyle.BackColor = (index % 2 == 0 ? evenRowColor : oddRowColor);
            }
        }

        private void InitializeTitle()
        {
            LBL_Team.Text = m_TeamName;
            LBL_Town.Text = m_TeamTown;
            LBL_Division.Text = m_Division;
        }

        private void InitializeDataGrid()
        {
            myData.Clear();
            OracleParameter pplayer = new OracleParameter(":numjoueur", OracleDbType.Int32);
            string sql = "select nom, prenom, role, buts, passes, points, punition, numjoueur " +
                        "from vueJoueur where numjoueur=:pplayer" +
                        " group by nom, prenom, role, buts, passes, points, punition, numjoueur";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            oraCMD.CommandType = CommandType.Text;
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);
            oraCMD.Parameters.Add(pplayer);
            adapt.SelectCommand = oraCMD;

            foreach (int number in playersNumber)
            {
                pplayer.Value = number;

                adapt.Fill(myData, "equipe");
            }

            source = new BindingSource(myData, "equipe");
            DGV_Players.DataSource = source;

            ApplyRowsStyles();
        }

<<<<<<< HEAD

        private void Get_Players_Number(string team)
        {
            OracleParameter pteam = new OracleParameter(":equipe", OracleDbType.Varchar2, 30);
            playersNumber = new List<int>();
            string sqlNumPlayer = "select numjoueur from joueur where equipe=:pteam";

            OracleCommand cmd = new OracleCommand(sqlNumPlayer, conn);
            cmd.CommandType = CommandType.Text;

            pteam.Value = team;

            cmd.Parameters.Add(pteam);

            OracleDataReader oraRead = cmd.ExecuteReader();

            oraRead = cmd.ExecuteReader();
            //atteindre les numéros de joueurs, cela nous donne en même temps le nombre de joueurs dans l'équipe
            while (oraRead.Read())
            {
                playersNumber.Add(oraRead.GetInt32(0));
            }
        }

=======
>>>>>>> 29c67e3052ffd8dd24660743cd4107fe56a24415
        private void DGV_Players_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGV_Players.ClearSelection();
            DGV_Players.Rows[e.RowIndex].Selected = true;

            DGV_Players.SelectedRows[0].ReadOnly = true;
            if (e.Button == MouseButtons.Right)
            {
                if (DGV_Players.SelectedRows.Count > 0)
                {

                    ContextMenuStrip cms = new ContextMenuStrip();
                    ToolStripMenuItem tsmi;

                    tsmi = new ToolStripMenuItem("Editer l'enregistrement");
                    tsmi.Click += tsmi_Edit_Click;
                    cms.Items.Add(tsmi);

                    tsmi = new ToolStripMenuItem("Effacer l'enregistrement");
                    tsmi.Click += tsmi_Delete_Click;
                    cms.Items.Add(tsmi);
                    
                    tsmi = new ToolStripMenuItem("Police...");
                    tsmi.Click += tsmi_Font_Click;
                    cms.Items.Add(tsmi);

                    tsmi = new ToolStripMenuItem("Couleur...");
                    tsmi.Click += tsmi_Color_Click;
                    cms.Items.Add(tsmi);

                    cms.Show(DGV_Players, DGV_Players.PointToClient(Cursor.Position));
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Gestion de l'option couleur du menu contextuel du DGV_Teams //////////////////////////////////
        private void tsmi_Color_Click(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Gestion de l'option police du menu contextuel du DGV_Teams ///////////////////////////////////
        private void tsmi_Font_Click(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Gestion de l'option édition du menu contextuel du DGV_Teams //////////////////////////////////
        private void tsmi_Edit_Click(object sender, EventArgs e)
        {
            EditPlayer();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////// Gestion de l'option suppression du menu contextuel du DGV_Teams ////////////////////////////////
        private void tsmi_Delete_Click(object sender, EventArgs e)
        {
            Remove_Player();
        }
        private void EditPlayer()
        {
            Edit_Player_Form form = new Edit_Player_Form();

            form.m_Name = DGV_Players.SelectedRows[0].Cells[0].Value.ToString();
            form.m_Surname = DGV_Players.SelectedRows[0].Cells[1].Value.ToString();
            form.m_Position = DGV_Players.SelectedRows[0].Cells[2].Value.ToString();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Update_Player(form,int.Parse(DGV_Players.SelectedRows[0].Cells[7].Value.ToString()));
            }
        }

        private void Update_Player(Edit_Player_Form form, int playerNumber)
        {
            OracleParameter pname = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
            OracleParameter psurname = new OracleParameter(":prenom", OracleDbType.Varchar2, 30);
            OracleParameter pbirth = new OracleParameter(":datenaissance", OracleDbType.Date);
            OracleParameter pjersey = new OracleParameter(":numeromaillot", OracleDbType.Int32);
            OracleParameter pposition = new OracleParameter(":role", OracleDbType.Varchar2, 20);
            OracleParameter pnumber = new OracleParameter(":numjoueur", OracleDbType.Int32);

            string sql = "update joueur set nom =:pname, prenom=:psurname, datenaissance=:pbirth, numeromaillot=:pjersey, role=:pposition" +
                         " where numjoueur=:pnumber";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            oraCMD.CommandType = CommandType.Text;

            pname.Value = form.m_Name;
            psurname.Value = form.m_Surname;
            pbirth.Value = form.m_Birth;
            pjersey.Value = form.m_Jersey;
            pposition.Value = form.m_Position;
            pnumber.Value = playerNumber;

            try
            {
                oraCMD.Parameters.Add(pname);
                oraCMD.Parameters.Add(psurname);
                oraCMD.Parameters.Add(pbirth);
                oraCMD.Parameters.Add(pjersey);
                oraCMD.Parameters.Add(pposition);
                oraCMD.Parameters.Add(pnumber);

                oraCMD.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            InitializeDataGrid();
        }

        private void FB_Add_Player_Click(object sender, EventArgs e)
        {
            Add_Player_Form form = new Add_Player_Form();

            form.myData = myData;
            form.m_Location = Properties.Settings.Default.AddPlayer_Location;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Add_Player(form.m_PlayerName, form.m_PlayerSurname, form.m_Player_Birth, form.m_PlayerJersey, form.m_PlayerPosition);
            }
        }

        private void Add_Player(string name, string surname, DateTime birth, int jersey, string position)
        {
            OracleParameter pname = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
            OracleParameter psurname = new OracleParameter(":prenom", OracleDbType.Varchar2, 30);
            OracleParameter pbirth = new OracleParameter(":naissance", OracleDbType.Date);
            OracleParameter pjersey = new OracleParameter(":maillot", OracleDbType.Int32);
            OracleParameter pposition = new OracleParameter(":position", OracleDbType.Varchar2, 20);
            OracleParameter pteam = new OracleParameter(":equipe", OracleDbType.Varchar2, 30);

            string sqlADD = "insert into player (nom, prenom, datenaissance, numeromaillot, role, equipe) values(:pname, :psurname, to_date(:pbirth, 'DD-MM-YYYY'), :pjersey, " +
                ":pposition, :pteam) ";

            pname.Value = name;
            psurname.Value = surname;
            pbirth.Value = birth;
            pjersey.Value = jersey;
            pposition.Value = position;
            pteam.Value = m_TeamName;

            try
            {
                OracleCommand oraInsert = new OracleCommand(sqlADD, conn);
                oraInsert.Parameters.Add(pname);
                oraInsert.Parameters.Add(psurname);
                oraInsert.Parameters.Add(pbirth);
                oraInsert.Parameters.Add(pjersey);
                oraInsert.Parameters.Add(pposition);
                oraInsert.Parameters.Add(pteam);

                oraInsert.CommandType = CommandType.Text;
                oraInsert.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            InitializeDataGrid();
        }

        private void FB_Remove_Player_Click(object sender, EventArgs e)
        {
            Remove_Player();
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

        private void Remove_Player()
        {
            DeleteForm dlg = new DeleteForm();
            dlg.ElementSupprime =  DGV_Players.SelectedRows[0].Cells[1].Value.ToString() + " " + DGV_Players.SelectedRows[0].Cells[0].Value.ToString() + " de cette équipe";

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OracleParameter pnum = new OracleParameter(":numjoueur", OracleDbType.Int32);
                string sqlDel = "delete from joueur where numjoueur = :pnum";

                pnum.Value = DGV_Players.SelectedRows[0].Cells[5].Value.ToString();

                try
                {
                    OracleCommand oraDel = new OracleCommand(sqlDel, conn);

                    oraDel.Parameters.Add(pnum);

                    oraDel.CommandType = CommandType.Text;
                    oraDel.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                InitializeDataGrid();
            }
        }

        private void FB_Ok_Click(object sender, EventArgs e)
        {
            SaveSettings();
            DialogResult = DialogResult.OK;
        }

        private void FB_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DGV_Players_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditPlayer();
        }

        private void DGV_Players_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DGV_Players.Rows[e.RowIndex].ReadOnly = true;
                if (DGV_Players.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    DGV_Players.Rows[e.RowIndex].ReadOnly = false;
                }
            }
        }

        private void FB_Edit_Player_Click(object sender, EventArgs e)
        {
            EditPlayer();
        }

        private void LBL_Team_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LBL_Team_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_LBL_TeamName;
        }

        private void LBL_Team_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }

        #region "SL_TeamTips fill text"
        private void DGV_Players_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_DGV_Players;
        }
        private void FB_Add_Player_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_AddPlayers;
        }
        private void FB_Remove_Player_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_RemovePlayer;
        }
        private void FB_Edit_Player_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_EditPlayer;
        }
        private void FB_Display_Calendar_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_ShowCalendar;
        }
        private void FB_Ok_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_AcceptChanges;
        }
        private void FB_Cancel_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_CancelChanges;
        }
        private void PB_Logo_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_ChangeImage;
        }
        private void TB_Team_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            SL_TeamTips.Text = Txt_ChangeTeamName;
        }
        private void CBX_Division_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_ChargeDivisionName;
        }
        private void LBL_Division_MouseEnter(object sender, EventArgs e)
        {
            SL_TeamTips.Text = Txt_LBL_DivisionName;
        }
        #endregion
        #region "SL_TeamTips clear text"
        private void DGV_Players_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void Empty_SL_TeamTips()
        {
            SL_TeamTips.Text = "";
        }
        private void FB_Add_Player_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void FB_Remove_Player_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void FB_Edit_Player_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void FB_Display_Calendar_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void FB_Ok_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void FB_Cancel_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void PB_Logo_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void TB_Town_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void CBX_Division_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        private void LBL_Division_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_TeamTips();
        }
        #endregion

        private void FB_Display_Calendar_Click(object sender, EventArgs e)
        {
            Match_Historic_Form hform = new Match_Historic_Form();

            hform.m_Team = m_TeamName;
            hform.source = source;
            hform.conn = conn;

            if (hform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void RefreshLogo()
        {
            try
            {
                OracleCommand oraCMD = conn.CreateCommand();
                oraCMD.CommandText = "select logo from equipe where nom = :nom";

                oraCMD.Parameters.Add(new OracleParameter(":nom", m_TeamName));

                using (OracleDataReader oraReader = oraCMD.ExecuteReader())
                {
                    if (oraReader.Read())
                    {
                        OracleBlob blob = oraReader.GetOracleBlob(0);

                        if (!blob.IsNull)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                byte[] buffer = new byte[8 * 1024];

                                int read = 0;

                                while ((read = blob.Read(buffer, 0, 8 * 1024)) > 0)
                                {
                                    ms.Write(buffer, 0, read);
                                }
                                image = ms.ToArray();
                                PB_Logo.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            PB_Logo.Refresh();
        }
        private void UpdateLogo(string filePath)
        {
            OracleParameter plogo = new OracleParameter(":logo", OracleDbType.Blob);

            string sql = "update equipe SET logo = :plogo where nom = '" + m_TeamName + "'";

            FileStream Streamp = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            byte[] buffer1 = new byte[Streamp.Length];
            Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
            Streamp.Close();

            plogo.Value = buffer1;

            try
            {
                OracleCommand oraUpdate = new OracleCommand(sql, conn);

                oraUpdate.Parameters.Add(plogo);

                oraUpdate.CommandType = CommandType.Text;
                oraUpdate.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            RefreshLogo();
        }

        private void PB_Logo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateLogo(dlg.FileName);
                Image_LogoScroller = dlg.FileName;
            }
        }

        private void Update_Controls_Locations()
        {
            LBL_Team.Location = new Point(DGV_Players.Location.X + (DGV_Players.Size.Width - LBL_Team.Size.Width - LBL_String.Size.Width - LBL_Town.Size.Width) / 2,
                DGV_Players.Location.Y - LBL_Team.Size.Height);
            LBL_String.Location = new Point(DGV_Players.Location.X + (DGV_Players.Size.Width - LBL_String.Size.Width + LBL_Team.Size.Width - LBL_Town.Size.Width) / 2,
                DGV_Players.Location.Y - LBL_String.Size.Height);
            LBL_Town.Location = new Point(DGV_Players.Location.X + (DGV_Players.Size.Width - LBL_Town.Size.Width + LBL_Team.Size.Width + LBL_String.Size.Width) / 2,
                DGV_Players.Location.Y - LBL_Town.Size.Height);
            TB_Town.Location = new Point(LBL_Town.Location.X + (LBL_Town.Size.Width + TB_Town.Size.Width + 4) / 2,
                LBL_Town.Location.Y - TB_Town.Size.Height);
            CBX_Division.Location = new Point(LBL_Division.Location.X + (LBL_Division.Size.Width + CBX_Division.Size.Width - 64) / 2,
                LBL_Division.Location.Y + CBX_Division.Size.Height / 4);
        }
        private void Team_Form_SizeChanged(object sender, EventArgs e)
        {
            Update_Controls_Locations();
        }

        private void LBL_Town_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                TB_Town.Visible = true;
                TB_Town.Focus();
            }
        }

        private void TB_Town_Leave(object sender, EventArgs e)
        {
            Clear_Update_Box();
        }

        private void TB_Town_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r' && TB_Town.Text != "")
            {
                m_TeamTown = TB_Town.Text;
                InitializeTitle();
                Update_Controls_Locations();
                Clear_Update_Box();
            }
        }

        private void Clear_Update_Box()
        {
            TB_Town.Clear();
            TB_Town.Visible = false;
            CBX_Division.Visible = false;
        }
        private void DGV_Players_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ApplyRowsStyles();
        }

        private void TB_Division_Leave(object sender, EventArgs e)
        {
            Clear_Update_Box();
        }

        private void LBL_Division_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                CBX_Division.Visible = true;
                CBX_Division.Focus();
            }
        }

        private void CBX_Division_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Division = CBX_Division.SelectedItem.ToString();
            InitializeTitle();
            Update_Controls_Locations();
            Clear_Update_Box();
        }

        private void Team_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Team_Form_Location = this.Location;
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Form dlg = new Help_Form();
            dlg.ShowDialog();
        }
    }
}
