using Lab1AMC.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1AMC
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Arquitectura cpu = new Frm_Arquitectura();
            cpu.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
