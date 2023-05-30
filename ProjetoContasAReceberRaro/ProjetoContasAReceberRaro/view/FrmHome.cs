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

namespace ProjetoContasAReceberRaro
{
    public partial class FrmHome : Form
    {
        
        public FrmHome()
        {
            InitializeComponent();
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            ClassLogin login = new ClassLogin();
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblUser.Text = view.FrmLogin.usuarioConectado;
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            view.FrmCliente cliente = new view.FrmCliente();
            cliente.MdiParent = this;
            cliente.WindowState = FormWindowState.Maximized;
            cliente.Show();
        }
        private void btnContasAReceber_Click(object sender, EventArgs e)
        {
            view.FrmContasAReceber contareceber = new view.FrmContasAReceber();
            contareceber.MdiParent = this;
            contareceber.WindowState = FormWindowState.Maximized;
            contareceber.Show();
        }
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.FrmUsuario usuario = new view.FrmUsuario();
            usuario.MdiParent = this;
            usuario.WindowState = FormWindowState.Maximized;
            usuario.Show();
        }
        private void configuraçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            view.FrmConfiguracao configuracao = new view.FrmConfiguracao();
            configuracao.ShowDialog();
        }

       
    }
}
