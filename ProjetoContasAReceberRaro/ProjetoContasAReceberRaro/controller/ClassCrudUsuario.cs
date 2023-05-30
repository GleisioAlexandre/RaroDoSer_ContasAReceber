using FirebirdSql.Data.FirebirdClient;
using ProjetoContasAReceberRaro.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassCrudUsuario
    {
        DataTable dt = new DataTable();
        FbConnection conexao = new FbConnection(ClassConexao.Conexao);
        public DataTable CarregaUsuario()
        {
            conexao.Open();
            FbCommand comando = new FbCommand("select * from tb_usuario", conexao);
            FbDataAdapter dataAdapter = new FbDataAdapter(comando);
            dataAdapter.Fill(dt);
            conexao.Close();
            return dt;
        }
        public void InserirUsuario(string nome, string cpf, string usuario, string senha)
        {
            conexao.Open();
            FbCommand comando = new FbCommand("insert into tb_usuario (nome, cpf, usuario, senha) values (@nome, @cpf, @usuario, @senha) ", conexao);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        } 
        public ClassUsuario PesquisaUsuario(string dados)
        {
            ClassUsuario usuario = new ClassUsuario();
            conexao.Open();
            FbCommand comando = new FbCommand("select id_usuario, nome, cpf, usuario, senha from tb_usuario where nome = @nome ", conexao);
            comando.Parameters.AddWithValue("@nome", dados);
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                usuario.Id_usuario = Convert.ToInt32(leitor[0]);
                usuario.Nome = leitor[1].ToString();
                usuario.Cpf = leitor[2].ToString();
                usuario.User = leitor[3].ToString();
                usuario.Password = leitor[4].ToString();
            }
            leitor.Close();
            conexao.Close();
            return usuario;
        }
    }
}
