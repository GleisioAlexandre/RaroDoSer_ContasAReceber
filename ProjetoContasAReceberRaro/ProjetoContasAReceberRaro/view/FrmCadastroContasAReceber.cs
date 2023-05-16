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
        private FrmContasAReceber contasAReceber;
        public FrmCadastroContasAReceber(FrmContasAReceber contasAReceber)
        {
            InitializeComponent();
            this.contasAReceber = contasAReceber;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }
        private void FrmCadastroContasAReceber_Load(object sender, EventArgs e)
        {
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            cbxClasse.DataSource  = crud.CarregaClasse();
            cbxSituacao.DataSource = crud.CarregaSituacao();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {

            gpbCliente.Enabled = true;
            gpbDivida.Enabled = true;
            btnCadastrar.Enabled = true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            IncluirDivida();
            
        }
        private void FrmCadastroContasAReceber_FormClosing(object sender, FormClosingEventArgs e)
        {
            contasAReceber.CarregaGridContas();
        }

        private void btnPesquisarDivida_Click(object sender, EventArgs e)
        {
            PesquisarDivida();
        }
       
        //Metodos ********************************************************************
        private string DataPagamento()
        {
          
            string pagamento = null;

            if (cbxSituacao.SelectedItem.Equals("ATRASADO") == true)
            {
                pagamento = null;
            }
            else if (cbxSituacao.SelectedItem.Equals("PAGO") == true || cbxSituacao.SelectedItem.Equals("EM DIA") == true)
            {
                pagamento = txtDataPagamento.Text;
            }
            return pagamento;
        }
        private void IncluirDivida()
        {
            string pagamento = DataPagamento();
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            try
            {
                crud.InserirDivida(Convert.ToInt32(lblCodigo.Text), txtDataEntrada.Text, Convert.ToDouble(txtValor.Text), cbxSituacao.SelectedIndex + 1, txtDocumento.Text, cbxClasse.SelectedIndex + 1, txtDataVencimento.Text, pagamento);
                MessageBox.Show("Divida incluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Inserir a informação no banco de dados! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PesquisarCliente()
        {
            ClassCrudCliente crud = new ClassCrudCliente();
            ClassCliente cliente = new ClassCliente();
            cliente = crud.PesquisaCliente(txtCliente.Text);

            lblCodigo.Text = cliente.Codigo.ToString();
            txtCliente.Text = cliente.Nome;

        }
        private void PesquisarDivida()
        {
           try
            {
                ClassCrudContasAReceber pesquisaDivida = new ClassCrudContasAReceber();
                ClassDividaClientes dividaCliente = new ClassDividaClientes();
                dividaCliente = pesquisaDivida.PesquisaDivida(txtDocumento.Text);
                lbl_id_Conta.Text = dividaCliente.Id_conta.ToString();
                txtValor.Text = dividaCliente.Valor.ToString("N2");
                txtDocumento.Text = dividaCliente.Documento;
                txtDataEntrada.Text = dividaCliente.Entrada;
                txtDataVencimento.Text = dividaCliente.Vencimento;
                txtDataPagamento.Text = dividaCliente.Pagamento;
                txtCliente.Text = dividaCliente.Cliente;
                cbxSituacao.SelectedItem = dividaCliente.Situacao;
                cbxClasse.SelectedItem = dividaCliente.Classe ;
                Console.WriteLine(dividaCliente.Situacao + "\n" + dividaCliente.Classe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar as informações no banco de dados\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            try
            {
                /* crud.EditarDivida(Convert.ToInt32(lbl_id_Conta.Text), Convert.ToInt32(lblCodigo.Text), txtDataEntrada.Text, Convert.ToDouble(txtValor.Text), Convert.ToInt32(cbxSituacao.SelectedIndex + 1), txtDocumento.Text, Convert.ToInt32(cbxClasse.SelectedIndex + 1), txtDataVencimento.Text, txtDataPagamento.Text);
                 MessageBox.Show("Cadastro Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();*/

                Console.WriteLine(cbxSituacao.SelectedIndex + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar as informações no banco de dados! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
