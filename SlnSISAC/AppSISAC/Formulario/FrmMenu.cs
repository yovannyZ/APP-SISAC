using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSISAC.Formulario
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void utilitariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompania frm = new FrmCompania();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
