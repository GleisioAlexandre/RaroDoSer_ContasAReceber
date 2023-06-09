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
    public partial class FrmIncluirContasAReceber : Form
    {
        private FrmContasAReceber contasAReceber;
        public FrmIncluirContasAReceber(FrmContasAReceber contasAReceber)
        {
            InitializeComponent();
            this.contasAReceber = contasAReceber;
        }
        //*****************************Metodos***************************************
        //Metodo que ao manipular o combox Situacao altera o maskedbox pagamento para 01/01/0001
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
        //Metodo usado para inserir as dividas dos clientes no banco de dados
        private void IncluirDivida()
        {
             ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            try
            {
             crud.InserirDivida(Convert.ToInt32(lblCodigo.Text), txtDataEntrada.Text, Convert.ToDouble(txtValor.Text), cbxSituacao.SelectedIndex + 1, txtDocumento.Text, cbxClasse.SelectedIndex + 1, txtDataVencimento.Text, txtDataPagamento.Text);
             MessageBox.Show("Divida incluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
             this.Close();
            }
             catch (Exception ex)
            {
             MessageBox.Show("Erro ao Inserir a informação no banco de dados! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //Metodo usado para pesquisar o cliente devedor e atribuir o valor da divida
        private void PesquisarCliente()
        {
            ClassCrudCliente crud = new ClassCrudCliente();
            ClassCliente cliente = new ClassCliente();
            cliente = crud.PesquisaCliente(txtCliente.Text);

            lblCodigo.Text = cliente.Codigo.ToString();
            txtCliente.Text = cliente.Nome;

        }
        //Metodo usado para pesquisar as dividas já inseridas no banco de dados
        private void PesquisarDivida()
        {
             try
              {
                  ClassCrudContasAReceber pesquisaDivida = new ClassCrudContasAReceber();
                  ClassDividaClientes dividaCliente = new ClassDividaClientes();
                  dividaCliente = pesquisaDivida.PesquisaDivida(txtDocumento.Text);
                  lblCodigo.Text = dividaCliente.Id_cliente.ToString();
                  lbl_id_Conta.Text = dividaCliente.Id_conta.ToString();
                  txtValor.Text = dividaCliente.Valor.ToString("N2");
                  txtDocumento.Text = dividaCliente.Documento;
                  txtDataEntrada.Text = dividaCliente.Entrada;
                  txtDataVencimento.Text = dividaCliente.Vencimento;
                  txtDataPagamento.Text = dividaCliente.Pagamento;
                  lblCodigo.Text = dividaCliente.Id_cliente.ToString();
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
        //Metodo usado para editar as dividas caso haja alguma inserção errada
        private void EditarDivida()
        {
           
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            try
            {
                crud.EditarDivida(Convert.ToInt32(lbl_id_Conta.Text), Convert.ToInt32(lblCodigo.Text), txtDataEntrada.Text, Convert.ToDouble(txtValor.Text), (cbxSituacao.SelectedIndex + 1), txtDocumento.Text, (cbxClasse.SelectedIndex + 1), txtDataVencimento.Text, txtDataPagamento.Text);
                MessageBox.Show("Cadastro Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar as informações no banco de dados! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
        //Metodo usado para validar os valores do textbox valor
        private static void ValidacaoValor(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }else if (e.KeyChar == 44)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }
        //Metodo usado para deletar as dividas dos clientes
        private void DeletarDivida()
        {
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            try
            {
                
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja remover o registro ?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    crud.DeletarDivida(Convert.ToInt32(lbl_id_Conta.Text));
                    MessageBox.Show("Registro removido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar remover o registro do banco de dados! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo usado para iniciar os parametros do sistema
        private void Inicio()
        {
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            cbxClasse.DataSource = crud.CarregaClasse();
            cbxSituacao.DataSource = crud.CarregaSituacao();
            txtDataEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbxSituacao.SelectedIndex = 1;
        }
        //Metodo usado para liberar os botões para iniciar as operações
        private void Novo()
        {
            gpbCliente.Enabled = true;
            gpbDivida.Enabled = true;
            btnCadastrar.Enabled = true;
            btnPesquisarDivida.Enabled = true;
            btnEditar.Enabled = true;
        }
        //****************************************************************************
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }
        private void FrmCadastroContasAReceber_Load(object sender, EventArgs e)
        {
            Inicio();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarDivida();
        }
        private void cbxSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSituacao.SelectedIndex == 1)
            {
                txtDataPagamento.Text = "01/01/0001";
            }
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            DeletarDivida();
        }
        private void txtValor_Leave(object sender, EventArgs e)
        {
           if (txtValor.Text != "")
            {
                var valor = Convert.ToDecimal(txtValor.Text);
                txtValor.Text = valor.ToString("N2");
            }
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoValor(sender, e);
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            txtCliente.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            txtDocumento.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
