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
    public partial class CadastrarAutoInfracao : Form
    {
        public CadastrarAutoInfracao()
        {
            InitializeComponent();
        }

        private void CadastrarAutoInfracao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minhaAppDataSet4.Processo' table. You can move, or remove it, as needed.
            this.processoTableAdapter.Fill(this.minhaAppDataSet4.Processo);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Processo processo = new Processo();
                processo.Id = Convert.ToInt16(cmbProcesso.SelectedValue.ToString());
                processo.DataRelato = DateTime.Today;
                AutoInfracao autoInfracao = new AutoInfracao();
                autoInfracao.Processo = processo;
                autoInfracao.Agravante = cbAgravante.Checked;
                autoInfracao.Atenuante = cbAtenuante.Checked;
                autoInfracao.Gravidade = Convert.ToInt16(txtGravidade.Text);
                autoInfracao.Multa = Convert.ToDecimal(txtMulta.Text);

                AutoInfracoesController autoInfracoesController = new AutoInfracoesController();
                autoInfracoesController.Post(autoInfracao);
                MessageBox.Show("Auto Infração Cadastrado Com Sucesso!");
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
