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
    public partial class CadastrarProcesso : Form
    {
        public CadastrarProcesso()
        {
            InitializeComponent();
        }

        private void CadastrarProcesso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minhaAppDataSet3.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.minhaAppDataSet3.Fornecedor);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Id = Convert.ToInt16(cmbFornecedor.SelectedValue.ToString());
                Processo processo = new Processo();
                processo.Fornecedor = fornecedor;
                processo.DataRelato = Convert.ToDateTime(txtData.Text);
                processo.FiscalResponsavel = txtResponsavel.Text;
                processo.RelatoFiscalizacao = txtRelato.Text;

                ProcessosController processosController = new ProcessosController();
                processosController.Post(processo);
                MessageBox.Show("Processo Cadastrado Com Sucesso!");
                ActiveForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                ActiveForm.Close();
            }
        }
    }
}
