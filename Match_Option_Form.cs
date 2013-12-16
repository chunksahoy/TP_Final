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
    public partial class Match_Option_Form : Form
    {
        #region "Attributs publics"
        public Color Home_oddRowColor;
        public Color Home_evenRowColor;
        public Color Visitor_oddRowColor;
        public Color Visitor_evenRowColor;
        public Color Home_FontColor;
        public Color Visitor_FontColor;
        public Font Font_DGV_Home;
        public Font Font_DGV_Visitor;
        #endregion
        public Match_Option_Form()
        {
            InitializeComponent();
        }

        private void InitializeFonts()
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                CBX_Home.Items.Add(font.Name);
                CBX_Visitor.Items.Add(font.Name);
            }
            CBX_Home.Text = Font_DGV_Home.Name;
            CBX_Visitor.Text = Font_DGV_Visitor.Name;
        }

        #region "Tab index Home"

        private void PN_EvenRow_Color_Home_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = Home_evenRowColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Home_evenRowColor = dlg.Color;
                PN_EvenRow_Color_Home.BackColor = Home_evenRowColor;
            }
        }
        private void PN_OddRow_Color_Home_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = Home_oddRowColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Home_oddRowColor = dlg.Color;
                PN_OddRow_Color_Home.BackColor = Home_oddRowColor;
            }
        }
        private void BTN_Font_Home_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.ShowColor = true;
            dlg.Font = Font_DGV_Home;
            dlg.Color = Home_FontColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CBX_Home.Text = dlg.Font.Name;
                Font_DGV_Home = dlg.Font;
                Home_FontColor = dlg.Color;
            }
        }
        private void CBX_Home_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font_DGV_Home = new Font(CBX_Home.Text, Font_DGV_Home.Size);
        }
        #endregion  
        #region "Tab index Visitor"
        private void PN_EvenRow_Color_Visitor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = Visitor_oddRowColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Visitor_evenRowColor = dlg.Color;
                PN_EvenRow_Color_Visitor.BackColor = Visitor_evenRowColor;
            }
        }

        private void PN_OddRow_Color_Visitor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = Visitor_oddRowColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Visitor_oddRowColor = dlg.Color;
                PN_OddRow_Color_Visitor.BackColor = Visitor_oddRowColor;
            }
        }
        private void BTN_Font_Visitor_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.ShowColor = true;
            dlg.Font = Font_DGV_Visitor;
            dlg.Color = Visitor_FontColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CBX_Visitor.Text = dlg.Font.Name;
                Font_DGV_Visitor = dlg.Font;
                Visitor_FontColor = dlg.Color;
            }
        }
        private void CBX_Visitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font_DGV_Visitor = new Font(CBX_Visitor.Text, Font_DGV_Visitor.Size);
        }
        #endregion
       
        private void Match_Option_Form_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.MatchOption_Location;
            PN_EvenRow_Color_Home.BackColor = Home_evenRowColor;
            PN_OddRow_Color_Home.BackColor = Home_oddRowColor;
            PN_EvenRow_Color_Visitor.BackColor = Visitor_evenRowColor;
            PN_OddRow_Color_Visitor.BackColor = Visitor_oddRowColor;
            InitializeFonts();
            BTN_Ok.Select();
        }

        private void Match_Option_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MatchOption_Location = this.Location;
        }
    }
}
