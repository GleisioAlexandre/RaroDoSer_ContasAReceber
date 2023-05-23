using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassConexao
    {
        private string user;
        private string password;
        private string database;
        private string datasource;
        private int porta;
        public ClassConexao()
        {

        }
        public void Print()
        {
            Console.WriteLine("Usuário: " + user + "\nSenha: " + password + "\nServidor: " + datasource + "\nBanco de Dados: " + database + "\nPorta: " + porta);
        }
        public ClassConexao(string user, string password, string database, string datasource, int porta)
        {
            this.user = user;
            this.password = password;
            this.database = database;
            this.datasource = datasource;
            this.porta = porta;
        }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Database { get => database; set => database = value; }
        public string Datasource { get => datasource; set => datasource = value; }
        public int Porta { get => porta; set => porta = value; }
        public static string Conexao
        {
           
            get
            {
                return ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;
            }
        }
       

    }
}
