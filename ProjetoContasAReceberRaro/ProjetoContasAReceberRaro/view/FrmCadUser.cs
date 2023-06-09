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
                this.Close();
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
        private void EditarUsuario()
        {
            try
            {
                ClassCrudUsuario crud = new ClassCrudUsuario();
                crud.EditarUsuario(Convert.ToInt32(lblCodigoUser.Text), txtNome.Text, txtCpf.Text, txtUsuario.Text, txtSenha.Text);
                MessageBox.Show("Registro incluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o registro!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarUsuario()
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja remover o registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    ClassCrudUsuario crud = new ClassCrudUsuario();
                    crud.DeletarUsuario(Convert.ToInt32(lblCodigoUser.Text));
                    MessageBox.Show("Registro deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o registro!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarUsuario();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
