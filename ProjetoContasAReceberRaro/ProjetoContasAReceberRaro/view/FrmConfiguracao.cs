using ProjetoContasAReceberRaro.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContasAReceberRaro.view
{
    public partial class FrmConfiguracao : Form
    {
        public FrmConfiguracao()
        {
            InitializeComponent();
        }
        //************************Metodos*************************
        private void EditarConfiguracaoBd()
        {
            try
            {
                StringBuilder stringDeConexao = new StringBuilder();
                stringDeConexao.Append("DataSource=").Append(txtServidor.Text).Append(";");
                stringDeConexao.Append("User=").Append(txtUsuario.Text).Append(";");
                stringDeConexao.Append("Password=").Append(txtSenha.Text).Append(";");
                stringDeConexao.Append("Database=").Append(txtCaminhoBanco.Text).Append(";");
                stringDeConexao.Append("Port=").Append(txtPorta.Text);

                Configuration configuracao = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuracao.ConnectionStrings.ConnectionStrings["ConexaoFirebird"].ConnectionString = stringDeConexao.ToString();
                configuracao.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Parametros editados com sucesso!","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar os parametros do banco de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ParametrosBd(string connectionString, string parametro)
        {
            int indexInicial = connectionString.IndexOf(parametro + "=");
            if (indexInicial >= 0)
            {
                indexInicial += parametro.Length + 1;
                int indexFinal = connectionString.IndexOf(";", indexInicial);
                if (indexFinal < 0)
                {
                    indexFinal = connectionString.Length;
                }
                return connectionString.Substring(indexInicial, indexFinal - indexInicial);
            }
            return string.Empty;
        }
        private void CarregaDadosBD()
        {
            string Conexao = ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;
            txtServidor.Text = ParametrosBd(Conexao, "DataSource");
            txtUsuario.Text = ParametrosBd(Conexao, "User");
            txtSenha.Text = ParametrosBd(Conexao, "Password");
            txtPorta.Text = ParametrosBd(Conexao, "Port");
            txtCaminhoBanco.Text = ParametrosBd(Conexao, "Database");
        }
        //********************************************************
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EditarConfiguracaoBd();
            gpbConfigBd.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void FrmConfiguracao_Load(object sender, EventArgs e)
        {
            CarregaDadosBD();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("A edição dos parametros do banco de dados pode afetar o funcionamento do sistema!", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                gpbConfigBd.Enabled = true;
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
            }
           
        }

        private void txtPorta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void txtServidor_TextChanged(object sender, EventArgs e)
        {
            txtServidor.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCaminhoBanco_TextChanged(object sender, EventArgs e)
        {
            txtCaminhoBanco.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
