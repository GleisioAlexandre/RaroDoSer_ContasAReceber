using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ProjetoContasAReceberRaro.controller;
using ProjetoContasAReceberRaro.model;

namespace ProjetoContasAReceberRaro.view
{
    public partial class FrmLogin : Form
    {
        public static string usuarioConectado;
        Thread thread;
        ClassUsuario usuario = new ClassUsuario();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void Login()
        {
            ClassLogin login = new ClassLogin();
            usuario = login.Login(txtUser.Text);
            usuarioConectado = usuario.User;
        }
        private void AbrirJanela(object obj)
        {
            Application.Run(new FrmHome());
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
            string user = usuario.User;
            string password = usuario.Password;
            thread = new Thread(AbrirJanela);
            FrmHome home = new FrmHome();
            if (txtUser.Text.Equals(user) && txtPassword.Text.Equals(password))
            {
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                MessageBox.Show("Usuário logado com sucesso!", "Login Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                home.Show();
            }
            else
            {
                MessageBox.Show("Erro ao logar no sistema, verifique suas credenciais e tente novamente!", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Clear();
                txtPassword.Clear();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
        }
    }
}
