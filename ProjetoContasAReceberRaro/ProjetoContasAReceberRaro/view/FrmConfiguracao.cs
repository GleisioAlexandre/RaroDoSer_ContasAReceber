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
        private void ConfiguracaoBd()
        {
            ClassConexao dados = new ClassConexao();
            dados.Datasource = txtServidor.Text;
            dados.Database = txtCaminhoBanco.Text;
            dados.User = txtUsuario.Text;
            dados.Password = txtSenha.Text;
            dados.Porta = Convert.ToInt32(txtPorta.Text);
            string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;
            string novaStringConexao = stringConexao
                .Replace("User= txtUsuario.text", $"User=txtUsuario.text")
                .Replace("Password = txtSenha.Text ", $"Password =txtSenha.Text")
                .Replace("Database = txtCaminhoBanco.Text", $"Database = txtCaminhoBanco.Text")
                .Replace("DataSource = txtServidor.Text", $"DataSource = txtServidor.Text")
                .Replace("Port = txtPorta.Text", $"Port = txtPorta.Text");
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var secaoStringConexao = (ConnectionStringsSection)config.GetSection("stringConexao");
            secaoStringConexao.ConnectionStrings["ConexaoFirebird"].ConnectionString = novaStringConexao;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("stringConexao");
            dados.Print();
        }
        //********************************************************
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ConfiguracaoBd();
        }
    }
}
