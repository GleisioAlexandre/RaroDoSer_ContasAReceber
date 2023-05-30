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
    public partial class FrmCadUser : Form
    {
        public FrmCadUser()
        {
            InitializeComponent();
        }
        private void CadastrarUsuario()
        {
            ClassCrudUsuario crud = new ClassCrudUsuario();
            try
            {
                crud.InserirUsuario(txtNome.Text, txtCpf.Text, txtUsuario.Text, txtSenha.Text);
                MessageBox.Show("Usuário Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar inserir os dados no sistema!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PesqusiarUsuario()
        {
            ClassCrudUsuario crud = new ClassCrudUsuario();
            ClassUsuario usuario = new ClassUsuario();
            usuario = crud.PesquisaUsuario(txtNome.Text);
            lblCodigoUser.Text = usuario.Id_usuario.ToString();
            txtNome.Clear();
            txtNome.Text = usuario.Nome;
            txtCpf.Text = usuario.Cpf;
            txtUsuario.Text = usuario.User;
            txtSenha.Text = usuario.Password;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            gpbUsuario.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesqusiarUsuario();
        }
    }
}
