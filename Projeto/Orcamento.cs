using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto.DTO;
using Projeto.BLL;

namespace Projeto
{
    public partial class Orcamento : Form
    {
        public Orcamento()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Orcamento_Load(object sender, EventArgs e)
        {

            //Método que chama o grid
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            IList<orcamentos_DTO> listaOrcamento = new List<orcamentos_DTO>();
            listaOrcamento = new OrcamentosBLL().CargaOrcamentos();

            DvgOrcamento.DataSource = listaOrcamento;
        }

        private void DvgOrcamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = DvgOrcamento.CurrentRow.Index;

            txtNome.Text = Convert.ToString(DvgOrcamento["nome", sel].Value);
            txtTelefone.Text = Convert.ToString(DvgOrcamento["telefone", sel].Value);
            txtEmail.Text = Convert.ToString(DvgOrcamento["email", sel].Value);
        }

        private void BtnResponder_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }
    }
}
