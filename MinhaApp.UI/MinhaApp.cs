using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaApp.SVC.Controllers;

namespace MinhaApp.UI
{
    public partial class MinhaApp : Form
    {
        public MinhaApp()
        {
            InitializeComponent();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            var fornecedores = new Fornecedores();
            fornecedores.Show();
        }

        private void btnProcesso_Click(object sender, EventArgs e)
        {
            var processos = new Processos();
            processos.Show();
        }

        private void btnAutoInfracao_Click(object sender, EventArgs e)
        {
            var cadastrarAutoInfracao = new CadastrarAutoInfracao();
            cadastrarAutoInfracao.Show();
        }
    }
}
