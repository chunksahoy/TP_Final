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

        public Font m_selectedFont;
        public Color m_selectedColor = Color.Black;

        private void Main_Options_Form_Load(object sender, EventArgs e)
        {
            PN_EvenRow_Color.BackColor = m_EvenRowColor;
            PN_OddRow_Color.BackColor = m_OddRowColor;
            CBX_DGV_Font.SelectedValue = m_selectedFont.Name;
            CBX_DGV_Font.Text = m_selectedFont.Name;
            InitializeFonts();
        }

        private void InitializeFonts()
        {
            m_selectedFont = this.Font;
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

        private void PN_OddRow_Color_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void PN_OddRow_Color_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void RefreshPanels()
        {
            PN_OddRow_Color.BackColor = m_OddRowColor;
            PN_EvenRow_Color.BackColor = m_EvenRowColor;
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OddRowColor = m_OddRowColor;
            Properties.Settings.Default.EvenRowColor = m_EvenRowColor;
        }

        private void BTN_DGV_Font_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.Font = m_selectedFont;
            dlg.ShowColor = true;
            dlg.Color = m_selectedColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_selectedFont = dlg.Font;
                m_selectedColor = dlg.Color;
                CBX_DGV_Font.Text = m_selectedFont.Name;
                //Properties.Settings.Default.DGV_Font_Size = m_selectedFont.Size;
            }
        }

        private void CBX_DGV_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
           // m_selectedFont = new Font(CBX_DGV_Font.Text, m_selectedFont.Size);
            CBX_DGV_Font.Text = m_selectedFont.Name;
        }
    }
}
