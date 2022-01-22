using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppContenedores
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void flowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFlow f = new FrmFlow();
            f.ShowDialog();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTabla f = new FrmTabla();
            f.ShowDialog();
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTabla2 f = new FrmTabla2();
            f.WindowState = FormWindowState.Minimized;
            f.ShowDialog();
        }
        //Fin
    }
}
