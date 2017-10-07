using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaApp.Domain.Models;
using MinhaApp.SVC.Controllers;

namespace MinhaApp.UI
{
    public partial class CadastrarFornecedor : Form
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minhaAppDataSet2.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.minhaAppDataSet2.Produto);
            // TODO: This line of code loads data into the 'minhaAppDataSet1.Endereco' table. You can move, or remove it, as needed.
            this.enderecoTableAdapter1.Fill(this.minhaAppDataSet1.Endereco);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Endereco endereco = new Endereco();
                endereco.Id = Convert.ToInt16(cmbEndereco.SelectedValue.ToString());
                Produto produto = new Produto();
                produto.Id = Convert.ToInt16(cmbProduto.SelectedValue.ToString());
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Cnpj = txtCNPJ.Text;
                fornecedor.RazaoSocial = txtRazaoSocial.Text;
                fornecedor.InscricaoMunicipal = txtInscricaoMunicipal.Text;
                fornecedor.ReceitaBruta = Convert.ToDecimal(txtReceitaBruta.Text);
                fornecedor.Endereco = endereco;
                fornecedor.Produto = produto;

                FornecedoresController fornecedoresController = new FornecedoresController();
                fornecedoresController.Post(fornecedor);
                MessageBox.Show("Fornecedor Cadastrado Com Sucesso!");
                ActiveForm.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                ActiveForm.Close();
            }
        }
    }
}
