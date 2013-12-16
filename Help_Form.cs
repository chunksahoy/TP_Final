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
    public partial class Help_Form : Form
    {
        public Help_Form()
        {
            InitializeComponent();
        }

        private void Help_Form_Load(object sender, EventArgs e)
        {
            TB_Aide.Text = "Cette application a pour but d'interfacer une base de données et de vous permettre de la modifier facilement. " +
                            "Pour tout aide en ce qui a trait des fonctionnalitées, vous pouvez survoler les objets avec votre souris et de l'aide dynamique " +
                            "sera affichée dans le coin gauche de notre application.";
        }
    }
}
