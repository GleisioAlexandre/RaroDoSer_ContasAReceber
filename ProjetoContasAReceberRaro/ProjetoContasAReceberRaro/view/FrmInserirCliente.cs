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
        private FrmCliente cliente;
        public FrmInserirCliente(FrmCliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }
        private void FrmInserirCliente_Load(object sender, EventArgs e)
        {
            CarregaEstadoECidade();
        }
        private void cbxPessoa_CheckedChanged(object sender, EventArgs e)
        {
            IteracaoPfPj();
        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            BtnNovo();
           
        }
        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            CadastrarCliente();
        }
        private void txtCep_Validated(object sender, EventArgs e)
        {
            ConsultaCep();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCliente();          
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCliente();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarCliente();
        }
        private void FrmInserirCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            cliente.AtualizaGrid();
        }
        //Metodo usado para carregar as cidades e estados dos comboxs
        private void CarregaEstadoECidade()
        {
            ClassCrudCliente crud = new ClassCrudCliente();
            cbxEstado.DataSource = crud.CarregaEstado();
            cbxCidade.DataSource = crud.CarregaCidade();
        }
        //Metodo usado para insserir informações dos clientes no banco de dados
        private void CadastrarCliente()
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
        //Metodo usado para exibir as informações dos clientes nos texbox e combobox da tela de cadastro, para uma possivel alteração nos dados
        private void PesquisarCliente()
        {
            if (cbxPessoa.Checked == true)
            {
                try
                {
                    string pJ = null;

                    if (txtNome.Text == "")
                    {
                        pJ = txtPessoa.Text;
                    }
                    else
                    {
                        pJ = txtNome.Text;
                    }
                    ClassCrudCliente crud = new ClassCrudCliente();
                    ClassCliente cliente = new ClassCliente();
                    cliente = crud.PesquisaClinetePJ(pJ);

                    lblCodigo.Text = cliente.Codigo.ToString();
                    txtNome.Text = cliente.Nome;
                    txtPessoa.Text = cliente.Cnpj;
                    txtCep.Text = cliente.Cep;
                    txtLogradouro.Text = cliente.Logradouro;
                    txtNumero.Text = cliente.Numero.ToString();
                    txtComplemento.Text = cliente.Complemento;
                    txtBairro.Text = cliente.Bairro;
                    cbxCidade.SelectedIndex = cliente.Id_cidade - 1;
                    cbxEstado.SelectedIndex = cliente.Id_estado - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar as informações do cliente, ou dados inexistentes!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    string pf = null;
                    if (txtNome.Text == "")
                    {
                        pf = txtPessoa.Text;
                    }
                    else
                    {
                        pf = txtNome.Text;
                    }
                    ClassCrudCliente crud = new ClassCrudCliente();
                    ClassCliente cliente = new ClassCliente();
                    cliente = crud.PesquisaClientePF(pf);
                    txtNome.Focus();
                    lblCodigo.Text = cliente.Codigo.ToString();
                    txtNome.Text = cliente.Nome;
                    txtPessoa.Text = cliente.Cpf;
                    txtCep.Text = cliente.Cep;
                    txtLogradouro.Text = cliente.Logradouro;
                    txtNumero.Text = cliente.Numero.ToString();
                    txtComplemento.Text = cliente.Complemento;
                    txtBairro.Text = cliente.Bairro;
                    cbxCidade.SelectedIndex = cliente.Id_cidade - 1;
                    cbxEstado.SelectedIndex = cliente.Id_estado - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar as informações do cliente, ou dados inexistentes!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Metodo usado para alterar as informações dos clientes que foram selecionadoas no metodo anterior
        private void EditarCliente()
        {
            string pf = null;
            string pj = null;
            try
            {
                ClassCrudCliente crud = new ClassCrudCliente();
                if (txtPessoa.Text.Length == 18)
                {
                    pj = txtPessoa.Text;
                    pf = null;
                }
                else if (txtPessoa.Text.Length == 14)
                {
                    pf = txtPessoa.Text;
                    pj = null;
                }
                crud.EditarCadCliente(Convert.ToInt32(lblCodigo.Text), txtNome.Text, pj, pf, txtCep.Text, txtLogradouro.Text, Convert.ToInt32(txtNumero.Text), txtComplemento.Text, txtBairro.Text, cbxCidade.SelectedIndex + 1, cbxEstado.SelectedIndex + 1);
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o registro do cliente!" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo Usado para remover registros do banco
        private void DeletarCliente()
        {
            ClassCrudCliente crud = new ClassCrudCliente();
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    crud.DeletarCliente(Convert.ToInt32(lblCodigo.Text));
                    MessageBox.Show("Registro removido com sucesso !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar remover o registro !/n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo usado para buscar o endereço do cliente apartir do cep
        private void ConsultaCep()
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
        //Metodo usado para habilitar os botons "Cadastrar", "Pesquisar","Editar", "Deletar"
        private void BtnNovo()
        {
            gpbDadosPessoais.Enabled = true;
            gpbEndereco.Enabled = true;
            btnCadatrar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btn_novo.Enabled = false;
            txtNome.Focus();
        }
        //Metodo usado para fazer a mudança de caracteristica do comboBox pessoa
        private void IteracaoPfPj()
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

        
    }
}
