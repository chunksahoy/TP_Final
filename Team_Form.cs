﻿using Oracle.DataAccess.Client;
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
        #endregion

        public Team_Form()
        {
            InitializeComponent();
        }

        public OracleConnection conn;
        private DataSet myData = new DataSet();
        private BindingSource source;
        public string m_TeamName;
        public string m_TeamTown;
        public Color oddRowColor;
        public Color evenRowColor;
        public int m_Selected_Index;
        public string m_Logo_File_Path;

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Options_Form form = new Main_Options_Form();

            form.m_EvenRowColor = Properties.Settings.Default.EvenRowColor;
            form.m_OddRowColor = Properties.Settings.Default.OddRowColor;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.EvenRowColor = form.m_EvenRowColor;
                Properties.Settings.Default.OddRowColor = form.m_OddRowColor;

                Properties.Settings.Default.Save();
            }
        }

        private void Team_Form_Load(object sender, EventArgs e)
        {
            InitializeTitle();
            InitializeDataGrid();

            LoadSettings();
            ApplyRowsStyles();
            RefreshLogo();
        }

        private void SaveSettings()
        {
            string widthStrings = "";
            for (int colIndex = 0; colIndex < DGV_Players.ColumnCount; colIndex++)
            {
                widthStrings += DGV_Players.Columns[colIndex].Width.ToString();
                if (colIndex < DGV_Players.ColumnCount - 1)
                    widthStrings += ",";
            }

            Properties.Settings.Default.DGV_Players_Column_Width = widthStrings;
            Properties.Settings.Default.DGV_Players_Row_Headers_Width = DGV_Players.RowHeadersWidth;
            Properties.Settings.Default.OddRowColor = oddRowColor;
            Properties.Settings.Default.EvenRowColor = evenRowColor;
            Properties.Settings.Default.Team_Form_Location = this.Location;
            Properties.Settings.Default.Team_Form_Size = this.Size;
            Properties.Settings.Default.DGV_Font = DGV_Players.Font;

            Properties.Settings.Default.Save();
        }


        private void LoadSettings()
        {
            DGV_Players.RowHeadersWidth = Properties.Settings.Default.DGV_Players_Row_Headers_Width;
            oddRowColor = Properties.Settings.Default.OddRowColor;
            evenRowColor = Properties.Settings.Default.EvenRowColor;
            this.Location = Properties.Settings.Default.Team_Form_Location;
            this.Size = Properties.Settings.Default.Team_Form_Size;
            DGV_Players.Font = Properties.Settings.Default.DGV_Font;

            string[] widthStrings = Properties.Settings.Default.DGV_Players_Column_Width.Split(',');
            if (widthStrings.Count() > 0)
            {
                for (int colIndex = 0; colIndex < DGV_Players.ColumnCount; colIndex++)
                {
                    if(colIndex != 2)
                        DGV_Players.Columns[colIndex].Width = int.Parse(widthStrings[colIndex]);
                }
            }
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
            LBL_Team.Text = m_TeamName + " de " + m_TeamTown;
        }

        private void InitializeDataGrid()
        {
            myData.Clear();
            string sql = "select * from player where equipe = '" + m_TeamName + "'";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.Fill(myData, "divisions");

            source = new BindingSource(myData, "divisions");
            DGV_Players.DataSource = source;
            ApplyRowsStyles();
        }

        private void Show_Player()
        {

        }
        private void DGV_Players_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGV_Players.SelectedRows[0].ReadOnly = true;
            if (e.Button == MouseButtons.Right)
            {
                if (DGV_Players.SelectedRows.Count > 0)
                {

                    ContextMenuStrip cms = new ContextMenuStrip();
                    ToolStripMenuItem tsmi;
                    if (DGV_Players.RowCount > 1 && DGV_Players.SelectedRows[0].Index != DGV_Players.RowCount - 1)
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

                    cms.Show(DGV_Players, DGV_Players.PointToClient(Cursor.Position));
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Gestion de l'option couleur du menu contextuel du DGV_Teams //////////////////////////////////
        private void tsmi_Color_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = (DGV_Players.SelectedRows[0].Index % 2 == 0 ? evenRowColor : oddRowColor);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (DGV_Players.SelectedRows[0].Index % 2 == 0)
                    evenRowColor = dlg.Color;
                else
                    oddRowColor = dlg.Color;
                ApplyRowsStyles();

            }
            //Save_Settings();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Gestion de l'option police du menu contextuel du DGV_Teams ///////////////////////////////////
        private void tsmi_Font_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.Font = DGV_Players.Font;
            dlg.Color = DGV_Players.ForeColor;
            dlg.ShowColor = true;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DGV_Players.Font = dlg.Font;
                DGV_Players.ForeColor = dlg.Color;
            }
            //Save_Settings();
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
            Player_Form form = new Player_Form();

            form.m_Player_Position = DGV_Players.SelectedRows[0].Cells[4].Value.ToString();
            //form.m_Player_Goals = DGV_Players.SelectedRows[0].Cells[2].Value.ToString();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void FB_Add_Player_Click(object sender, EventArgs e)
        {
            Add_Player_Form form = new Add_Player_Form();

            form.myData = myData;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            InitializeDataGrid();
        }

        private void FB_Remove_Player_Click(object sender, EventArgs e)
        {
            Remove_Player();
        }

        private void Remove_Player()
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            InitializeDataGrid();
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
            DGV_Players.Rows[e.RowIndex].ReadOnly = true;
            if (DGV_Players.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                DGV_Players.Rows[e.RowIndex].ReadOnly = false;
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
            Cursor = Cursors.Hand;
        }

        private void LBL_Team_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
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
           // Image logo;

            string getLogo = "select logo from equipe where nom = '" + m_TeamName + "'";

            try
            {
                OracleCommand oraCMD = new OracleCommand(getLogo, conn);
                OracleDataAdapter oraAdapt = new OracleDataAdapter();
                oraAdapt.SelectCommand = oraCMD;


                oraCMD.CommandType = CommandType.Text;

                oraAdapt.Fill(myData, "logo");

               // PB_Logo.Image = 
                PB_Logo.DataBindings.Add("Image", myData, "equipe.logo", true);
            }
            catch (Exception ex)
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
                OracleCommand oraUpdate = new OracleCommand(sql,conn);

                oraUpdate.Parameters.Add(plogo);

                oraUpdate.CommandType = CommandType.Text;
                oraUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
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
            }            
        }

        private void PB_Logo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void PB_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
