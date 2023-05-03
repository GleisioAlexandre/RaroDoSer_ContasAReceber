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
    public partial class FrmInserirCliente : Form
    {
        public FrmInserirCliente()
        {
            InitializeComponent();
        }
        private void FrmInserirCliente_Load(object sender, EventArgs e)
        {
            ClassCrudCliente crud = new ClassCrudCliente();
            cbxEstado.DataSource = crud.CarregaEstado();
            cbxCidade.DataSource = crud.CarregaCidade();
        }
        private void cbxPessoa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPessoa.Checked == true)
            {
                lblDescricao.Text = "Rasão Social";
                lblPessoa.Text = "CNPJ";
                txtPessoa.Mask = "##,###,###/####-##";
                txtPessoa.Size = new Size(151, 26);
            }
            else
            {
                lblDescricao.Text = "Nome";
                lblPessoa.Text = "CPF";
                txtPessoa.Mask = "###,###,###-##";
                txtPessoa.Size = new Size(121, 26);
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            gpbDadosPessoais.Enabled = true;
            gpbEndereco.Enabled = true;
            btnCadatrar.Enabled = true;
            btn_novo.Enabled = false;
            txtNome.Focus();
        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            string cpf, cnpj;
            if (cbxPessoa.Checked == true)
            {
                cpf = null;
                cnpj = txtPessoa.Text;
            }
            else
            {
                cnpj = null;
                cpf = txtPessoa.Text;
            }
            ClassCrudCliente crud = new ClassCrudCliente();
            try
            {
                crud.inserirCliente(txtNome.Text, cpf, cnpj, txtCep.Text, txtLogradouro.Text, Convert.ToInt32(txtNumero.Text), txtComplemento.Text, txtBairro.Text, cbxCidade.SelectedIndex + 1, cbxEstado.SelectedIndex + 1);
                MessageBox.Show("Cliente cadastrado com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (DialogResult.Yes == MessageBox.Show("Deseja cadastrar um novo cliente ?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    txtNome.Clear();
                    txtPessoa.Clear();
                    txtCep.Clear();
                    txtLogradouro.Clear();
                    txtNumero.Clear();
                    txtComplemento.Clear();
                    txtBairro.Clear();
                    cbxEstado.SelectedIndex = 0 + 1;
                    cbxCidade.SelectedIndex = 0 + 1;
                }
                else 
                {
                    this.Close();
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar o cliente !\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCep_Validated(object sender, EventArgs e)
        {
            ClassBuscaCep buscaCep = new ClassBuscaCep();
            var endereco = buscaCep.BuscaCep(txtCep.Text);
            if (endereco != null)
            {
                txtCep.Clear();
                txtCep.Text = endereco.Cep;
                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                cbxCidade.SelectedItem = endereco.Localidade;
                cbxEstado.SelectedItem = endereco.Uf;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClassCrudCliente crud = new ClassCrudCliente();
           
            txtNome.Text = crud.PesquisaCliente(txtNome.Text);
        }
    }
}
