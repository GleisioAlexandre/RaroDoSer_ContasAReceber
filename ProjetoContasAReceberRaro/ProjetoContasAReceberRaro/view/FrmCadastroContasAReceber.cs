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

        private void FrmCadastroContasAReceber_Load(object sender, EventArgs e)
        {
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            cbxClasse.DataSource  = crud.CarregaClasse();
            cbxSituacao.DataSource = crud.CarregaSituacao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            IncluirDivida();
        }

        private void IncluirDivida()
        {
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            try
            {
                crud.InserirDivida(Convert.ToInt32(lblCodigo.Text), dataEntrada.Value.ToString(), Convert.ToDouble(txtValor.Text), cbxSituacao.SelectedIndex + 1, txtDocumento.Text, cbxClasse.SelectedIndex + 1, dataVencimento.Value.ToString(), dataPagamento.Value.ToString());
                MessageBox.Show("Divida incluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao Inserir a informação no banco de dados! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
