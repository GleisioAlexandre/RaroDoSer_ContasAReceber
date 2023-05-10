using ProjetoContasAReceberRaro.controller;
using ProjetoContasAReceberRaro.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContasAReceberRaro.view
{
    public partial class FrmCadastroContasAReceber : Form
    {
        public FrmCadastroContasAReceber()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClassCrudCliente crud = new ClassCrudCliente();
            ClassCliente cliente = new ClassCliente();
            cliente = crud.PesquisaCliente(txtCliente.Text);

            lblCodigo.Text = cliente.Codigo.ToString();
            txtCliente.Text = cliente.Nome;

        }
    }
}
