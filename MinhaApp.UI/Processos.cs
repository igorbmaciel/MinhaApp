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
    public partial class Processos : Form
    {
        public Processos()
        {
            InitializeComponent();
        }

        private void Processos_Load(object sender, EventArgs e)
        {
            ProcessosController processosController = new ProcessosController();
            List<Processo> processos = processosController.Get();
            dgvProcessos.DataSource = processos;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrarProcesso = new CadastrarProcesso();
            cadastrarProcesso.Show();
        }
    }
}
