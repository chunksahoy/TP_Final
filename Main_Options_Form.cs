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
    public partial class Main_Options_Form : Form
    {
        public Main_Options_Form()
        {
            InitializeComponent();
        }
        public Color m_OddRowColor;
        public Color m_EvenRowColor;
        public Color m_SelectedFont_Color;
        public Font m_selectedFont;
        public Point m_Location;

        private void Main_Options_Form_Load(object sender, EventArgs e)
        {
            this.Location =  Properties.Settings.Default.MainOption_Location;
            PN_EvenRow_Color.BackColor = m_EvenRowColor;
            PN_OddRow_Color.BackColor = m_OddRowColor;
            CBX_DGV_Font.SelectedValue = m_selectedFont.Name;
            CBX_DGV_Font.Text = m_selectedFont.Name;
            InitializeFonts();
        }

        private void InitializeFonts()
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                CBX_DGV_Font.Items.Add(font.Name);
            }
            CBX_DGV_Font.SelectedValue = m_selectedFont.Name;
        }

        private void PN_EvenRow_Color_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = m_EvenRowColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_EvenRowColor = dlg.Color;
                RefreshPanels();
            }
        }

        private void PN_OddRow_Color_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = m_OddRowColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_OddRowColor = dlg.Color;
                RefreshPanels();
            }
        }

        private void RefreshPanels()
        {
            PN_OddRow_Color.BackColor = m_OddRowColor;
            PN_EvenRow_Color.BackColor = m_EvenRowColor;
        }

        private void BTN_DGV_Font_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.ShowColor = true;
            dlg.Font = m_selectedFont;
            dlg.Color = m_SelectedFont_Color;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_selectedFont = dlg.Font;
                CBX_DGV_Font.Text = m_selectedFont.Name;
                m_SelectedFont_Color = dlg.Color;
            }
        }

        private void CBX_DGV_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_selectedFont = new Font(CBX_DGV_Font.Text, m_selectedFont.Size);
        }

        private void Main_Options_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainOption_Location = this.Location;
        }
    }
}
