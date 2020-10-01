using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void dúvidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Duvidas duvidas = new Duvidas();
            duvidas.Show();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdeaSobre sobre = new IdeaSobre();
            sobre.Show();

        }
    }
}
