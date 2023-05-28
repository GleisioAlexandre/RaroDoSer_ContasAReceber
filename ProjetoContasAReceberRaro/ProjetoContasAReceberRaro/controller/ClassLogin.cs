using FirebirdSql.Data.FirebirdClient;
using ProjetoContasAReceberRaro.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassLogin
    {
        string stringConexao = ClassConexao.Conexao;
        ClassUsuario usuario = new ClassUsuario();
        public ClassUsuario Login(string dados)
        {
            FbConnection conexao = new FbConnection(stringConexao);
            conexao.Open();
            FbCommand comando = new FbCommand("select usuario, senha from tb_usuario where usuario = @usuario", conexao);
            comando.Parameters.AddWithValue("@usuario", dados);
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                usuario.User = leitor[0].ToString();
                usuario.Password = leitor[1].ToString();
            }
            conexao.Close();
            return usuario;
        }
        public string UsuarioLogado()
        {
            return usuario.User;
        }
    }
}
