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
using MinhaApp.Domain.Models;

namespace MinhaApp.UI
{
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FornecedoresController fornecedoresController = new FornecedoresController();
            List<Domain.Models.Fornecedor> fornecedor = fornecedoresController.Get();
            dgvFornecedor.DataSource = fornecedor;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           var cadastrarFornecedor = new CadastrarFornecedor();
            cadastrarFornecedor.Show();
        }
    }
}
