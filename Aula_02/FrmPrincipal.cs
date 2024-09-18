using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void TsGenero_Click(object sender, EventArgs e)
        {
            Gênero oFrm = new Gênero();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TsAutor_Click(object sender, EventArgs e)
        {
            Autor oFrmAutor = new Autor();
            oFrmAutor.MdiParent = this;
            oFrmAutor.Show();   
        }
    }
}
