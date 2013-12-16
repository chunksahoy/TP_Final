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
    public partial class Match_Historic_Form : Form
    {
        public Match_Historic_Form()
        {
            InitializeComponent();
        }

        #region "Attributs publics"
        public OracleConnection conn = new OracleConnection();
        public DataSet myData = new DataSet();
        public BindingSource source;
<<<<<<< HEAD
        List<int> playerNumbers;
=======
>>>>>>> 29c67e3052ffd8dd24660743cd4107fe56a24415
        public string m_Team;
        #endregion
        #region "Attributs privés"
        private Color evenRowColor;
        private Color oddRowColor;
        private Color Font_DGV_Color;
        private Font Font_DGV;
        #endregion 

        #region "Texte du SL_Tips"
        private string Txt_DGV_Historic = "Tips: Double clique sur l'entête d'une rangée d'un match pour afficher ses sttistiques dans une autre fenêtre.";
        private string Txt_AddMatch = "Tips: Clique gauche pour ouvrir un dialogue qui permet d'ajouter match à cette équipe.";
        private string Txt_RemoveMatch = "Tips: Clique gauche pour effacer le match selectionné de l'équipe choisie.";
        private string Txt_EditMatch = "Tips: Clique gauche pour afficher les statistiques du match selectionné dans la grille.";
        private string Txt_Btn_Ok = "Tips: Clique gauche pour confirmer les changements faits dans cette fenêtre et quitter cette dernière.";
        private string Txt_Btn_Cancel = "Tips: Clique gauche pour canceller les changements faits dans cette fenêtre et quitter cette dernière.";
        #endregion

        private void Match_Historic_Form_Load(object sender, EventArgs e)
        {
            LoadSettings();
            InitializeDGV();
        }

        private void InitializeDGV()
        {
            myData.Clear();
            string sql = " select * from match where receveur = '" + m_Team +
                "' UNION select * from match where visiteur = '" + m_Team + "'";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            OracleDataAdapter adapt = new OracleDataAdapter(sql, conn);

            adapt.Fill(myData, "divisions");

            source = new BindingSource(myData, "divisions");
            DGV_Historic.DataSource = source;

            DGV_Historic.Font = Font_DGV;
            DGV_Historic.ForeColor = Font_DGV_Color;
            ApplyRowsStyles();
            Resize_DGV_Historic();
        }

        private void Initialize_Players_Stats(string team)
        {
            OracleParameter pplayer = new OracleParameter(":numjoueur", OracleDbType.Int32);
            OracleParameter pmatch = new OracleParameter(":numeromatch", OracleDbType.Int32);

            string sqlInit = "insert into fichepersonnelle values(0,0,0,:pplayer,:pmatch)";
            List<int> playersNumber = new List<int>();
            OracleCommand oraCMD = new OracleCommand(sqlInit, conn);

            oraCMD.CommandType = CommandType.Text;
 
            playersNumber = Get_Players_Number(team);

            oraCMD.Parameters.Add(pplayer);
            oraCMD.Parameters.Add(pmatch);

            foreach (int number in playersNumber)
            {
                pplayer.Value = number;
                pmatch.Value = Get_Match_Number();

                oraCMD.ExecuteNonQuery();
            }
        }

        private int Get_Match_Number()
        {
            int matchNumber = 0;
            string numMatch = "select seqMatchs.currval from dual";

            OracleCommand cmd = new OracleCommand(numMatch, conn);
            cmd.CommandType = CommandType.Text;

            OracleDataReader matchRead = cmd.ExecuteReader();

            while (matchRead.Read())
            {
                matchNumber = matchRead.GetInt32(0);
            }

            return matchNumber;
        }

        private List<int> Get_Players_Number(string team)
        {
            OracleParameter pteam = new OracleParameter(":equipe", OracleDbType.Varchar2, 30);
            playerNumbers = new List<int>();
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
                playerNumbers.Add(oraRead.GetInt32(0));
            }
            return playerNumbers;
        }
        private void Resize_DGV_Historic()
        {
            foreach (DataGridViewColumn Col in DGV_Historic.Columns)
            {
                Col.Width = (DGV_Historic.Size.Width - DGV_Historic.RowHeadersWidth)  / DGV_Historic.ColumnCount;
            }
        }

        private void FB_Add_Match_Click(object sender, EventArgs e)
        {
            Add_Match();
        }

        private void Add_Match()
        {
            Add_Match_Form mform = new Add_Match_Form();
            mform.m_TeamName = m_Team;
            mform.conn = conn;

<<<<<<< HEAD
=======
            mform.m_Location = Properties.Settings.Default.AddMatch_Location;
>>>>>>> 29c67e3052ffd8dd24660743cd4107fe56a24415

            if (mform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OracleParameter phome = new OracleParameter(":receveur", OracleDbType.Varchar2, 20);
                OracleParameter pvisitor = new OracleParameter(":visiteur", OracleDbType.Varchar2, 20);
                OracleParameter pdate = new OracleParameter(":date", OracleDbType.Date);
                OracleParameter pstadium = new OracleParameter(":lieu", OracleDbType.Varchar2, 30);
                OracleParameter pVscore = new OracleParameter(":vscore", OracleDbType.Int32);
                OracleParameter pHscore = new OracleParameter(":hscore", OracleDbType.Int32);

                phome.Value = mform.m_Home;
                pvisitor.Value = mform.m_Visitor;
                pdate.Value = mform.m_Date;
                pstadium.Value = mform.m_Stadium;
                pVscore.Value = 0;
                pHscore.Value = 0;

                try
                {
                    string sqlInsert = "insert into match (receveur, visiteur, daterencontre, " +
                        "lieurencontre, scorevisiteur, scorereceveur) values (:phome, :pvisitor, to_date(:pdate, 'DD-MM-YYYY')," +
                        " :pstadium, :pVscore, :pHscore)";

                    OracleCommand oraInsert = new OracleCommand(sqlInsert, conn);

                    oraInsert.Parameters.Add(phome);
                    oraInsert.Parameters.Add(pvisitor);
                    oraInsert.Parameters.Add(pdate);
                    oraInsert.Parameters.Add(pstadium);
                    oraInsert.Parameters.Add(pVscore);
                    oraInsert.Parameters.Add(pHscore);

                    oraInsert.CommandType = CommandType.Text;
                    oraInsert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                Initialize_Players_Stats(mform.m_Home);
                Initialize_Players_Stats(mform.m_Visitor);
                InitializeDGV();
            }
        }

        private void FB_Remove_Match_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            DeleteForm dlg = new DeleteForm();
            dlg.ElementSupprime = "le match numéro " + DGV_Historic.SelectedRows[0].Cells[0].Value.ToString();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Remove_Match();
            }
        }

        private void Remove_Match()
        {
            string sqlDel = "delete from match where numeromatch = " + DGV_Historic.SelectedRows[0].Cells[0].Value.ToString();
=======
                Remove_Match();      
        }

        private void Remove_Match()
        {      
            DeleteForm dlg = new DeleteForm();
            dlg.ElementSupprime = "le match numéro " + DGV_Historic.SelectedRows[0].Cells[0].Value.ToString();
>>>>>>> 29c67e3052ffd8dd24660743cd4107fe56a24415

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlDel = "delete from match where numeromatch = " + DGV_Historic.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    OracleCommand oraDel = new OracleCommand(sqlDel, conn);

                    oraDel.CommandType = CommandType.Text;
                    oraDel.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                InitializeDGV();
            }
        }

        private void FB_Edit_Match_Click(object sender, EventArgs e)
        {
            Edit_Match();
        }

        private void Edit_Match()
        {
            if (DGV_Historic.RowCount > 0)
            {
                Match_Form form = new Match_Form();

                form.conn = conn;

                form.m_numMatch = int.Parse(DGV_Historic.SelectedRows[0].Cells[0].Value.ToString());
                form.m_Home = DGV_Historic.SelectedRows[0].Cells[1].Value.ToString();
                form.m_Visitor = DGV_Historic.SelectedRows[0].Cells[2].Value.ToString();
                form.m_Date = DateTime.Parse(DGV_Historic.SelectedRows[0].Cells[3].Value.ToString()).ToShortDateString();
                form.m_Stadium = DGV_Historic.SelectedRows[0].Cells[4].Value.ToString();
                form.m_Visitor_Score = int.Parse(DGV_Historic.SelectedRows[0].Cells[5].Value.ToString());
                form.m_Home_Score = int.Parse(DGV_Historic.SelectedRows[0].Cells[6].Value.ToString());
                form.home_Players_Number = Get_Players_Number(DGV_Historic.SelectedRows[0].Cells[1].Value.ToString());
                form.visit_Players_Number = Get_Players_Number(DGV_Historic.SelectedRows[0].Cells[2].Value.ToString());
                form.ShowDialog();

                InitializeDGV();
            }
        }

        private void FB_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void DGV_Historic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Historic_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGV_Historic.ClearSelection();
            DGV_Historic.Rows[e.RowIndex].Selected = true;

            if (e.Button == MouseButtons.Right)
            {
                if (DGV_Historic.SelectedRows.Count > 0)
                {
                    ContextMenuStrip cms = new ContextMenuStrip();
                    ToolStripMenuItem tsmi;

                    tsmi = new ToolStripMenuItem("Modifier l'enregistrement");
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

                    cms.Show(DGV_Historic, DGV_Historic.PointToClient(Cursor.Position));
                }
            }
        }
        private void tsmi_Color_Click(Object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = (DGV_Historic.SelectedRows[0].Index % 2 == 0 ? evenRowColor : oddRowColor);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (DGV_Historic.SelectedRows[0].Index % 2 == 0)
                    evenRowColor = dlg.Color;
                else
                    oddRowColor = dlg.Color;
                ApplyRowsStyles();
            }
        }
        private void tsmi_Font_Click(Object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.ShowColor = true;
            dlg.Font = Font_DGV;
            dlg.Color = Font_DGV_Color;

            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Font_DGV = dlg.Font;
                Font_DGV_Color = dlg.Color;
                UpdateControls();
            }
        }
        private void tsmi_Delete_Click(Object sender, EventArgs e)
        {
            Remove_Match();
        }
        private void tsmi_Edit_Click(Object sender, EventArgs e)
        {
            Edit_Match();
        }

        private void DGV_Historic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DGV_Historic_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            foreach (DataGridViewRow row in DGV_Historic.SelectedRows)
            {
                row.Height = e.Row.Height;
            }
        }

        private void FB_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Match_Historic_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Options_Form dlg = new Main_Options_Form();

            dlg.m_SelectedFont_Color = Font_DGV_Color;
            dlg.m_selectedFont = Font_DGV;
            dlg.m_OddRowColor = oddRowColor;
            dlg.m_EvenRowColor = evenRowColor;

            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Font_DGV_Color = dlg.m_SelectedFont_Color;
                Font_DGV = dlg.m_selectedFont;
                oddRowColor = dlg.m_OddRowColor;
                evenRowColor = dlg.m_EvenRowColor;
                UpdateControls();
            }
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.MatchHistoric_OddRowColor = oddRowColor;
            Properties.Settings.Default.MatchHistoric_EvenRowColor = evenRowColor;
            Properties.Settings.Default.MatchHistoric_Font = Font_DGV;
            Properties.Settings.Default.MatchHistoric_FontColor = Font_DGV_Color;
            Properties.Settings.Default.MatchHistoric_Location = this.Location;
        }

        private void LoadSettings()
        {
            Font_DGV = Properties.Settings.Default.MatchHistoric_Font;
            Font_DGV_Color = Properties.Settings.Default.MatchHistoric_FontColor;
            oddRowColor = Properties.Settings.Default.MatchHistoric_OddRowColor;
            evenRowColor = Properties.Settings.Default.MatchHistoric_EvenRowColor;
            this.Location = Properties.Settings.Default.MatchHistoric_Location;
        }
        private void UpdateControls()
        {
            DGV_Historic.Font = Font_DGV;
            DGV_Historic.ForeColor = Font_DGV_Color;
            ApplyRowsStyles();
        }

        private void ApplyRowsStyles()
        {
            for (int index = 0; index < DGV_Historic.Rows.Count; index++)
            {
                DGV_Historic.Rows[index].DefaultCellStyle.BackColor = (index % 2 == 0 ? evenRowColor : oddRowColor);
            }
        }

        #region "Remplir le Status Strip (SL_Tips)"
        private void FB_Add_Match_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_AddMatch;
        }
        private void FB_Remove_Match_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_RemoveMatch;
        }
        private void DGV_Historic_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_DGV_Historic;
        }
        private void FB_Edit_Match_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_EditMatch;
        }
        private void FB_Ok_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_Btn_Ok;
        }
        private void FB_Cancel_MouseEnter(object sender, EventArgs e)
        {
            SL_Tips.Text = Txt_Btn_Cancel;
        }
        #endregion
        #region "Empty SL_Tips"
        private void FB_Edit_Match_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_Tips();
        }
        private void FB_Ok_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_Tips();
        }
        private void FB_Remove_Match_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_Tips();
        }

        private void FB_Add_Match_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_Tips();
        } 
        private void DGV_Historic_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_Tips();
        }

        private void FB_Cancel_MouseLeave(object sender, EventArgs e)
        {
            Empty_SL_Tips();
        }
        private void Empty_SL_Tips()
        {
            SL_Tips.Text = "";
        }
        #endregion

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Form dlg = new Help_Form();
            dlg.ShowDialog();
        }
    }
}
