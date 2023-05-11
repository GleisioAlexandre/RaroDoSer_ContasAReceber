using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassCrudContasAReceber
    {
        FbConnection conexao = new FbConnection("User=SYSDBA;Password=masterkey;Database=C:/Users/Gleisio/Documents/C#/RaroDoSer_ContasAReceber/RaroDoSer_ContasAReceber/ProjetoContasAReceberRaro/ProjetoContasAReceberRaro/BD/RARO.FDB;DataSource=localhost;Port=3050");

        public DataTable CarregaGridConatas()
        {
            conexao.Open();
            DataTable dt = new DataTable();
            FbCommand comando = new FbCommand("select cr.id_contasareceber, cr.data_entrada, cr.valor, cr.documento, cr.data_vencimento, cr.data_pagamento, " +
                "(select c.nome_cliente from tb_cliente c where c.id_cliente = cr.id_cliente), " +
                "(select s.situacao from tb_situacao s where s.id_situacao = cr.id_situacao)," +
                "(select cl.class from tb_calsse cl where cl.id_class = cr.id_classe)" +
                "from tb_contas_a_receber cr", conexao);
            FbDataAdapter dataAdapter = new FbDataAdapter(comando);
            dataAdapter.Fill(dt);
            conexao.Close();
            return dt;
        } 
       public List<string> CarregaClasse()
        {
            conexao.Open();
            List<string> classe = new List<string>();
            FbCommand comando = new FbCommand("select Class from tb_calsse", conexao);
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                classe.Add(leitor.GetString(0));
            }
            leitor.Close();
            conexao.Close();
            return classe;   
        }
        public List<string> CarregaSituacao()
        {
            conexao.Open();
            List<string> situacao = new List<string>();
            FbCommand comando = new FbCommand("select situacao from tb_situacao", conexao);
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                situacao.Add(leitor.GetString(0));
            }
            leitor.Close();
            conexao.Close();
            return situacao;
        }
        public void InserirDivida(int id_cliente, string entrada, double valor, int id_situacao, string documento, int id_classe, string vencimento, string pagamento)
        {
            conexao.Open();
            FbCommand comando = new FbCommand("insert into tb_contas_a_receber (id_cliente , data_entrada, valor, id_situacao, documento, id_classe, data_vencimento, data_pagamento) " +
                                                 "values " +
                                                "(@id_cliente , @entrada, @valor, @id_situacao, @documento, @id_classe, @vencimento, @pagamento)", conexao);
            comando.Parameters.AddWithValue("@id_cliente",id_cliente);
            comando.Parameters.AddWithValue("@entrada", entrada);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@id_situacao", id_situacao);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@id_classe", id_classe);
            comando.Parameters.AddWithValue("@vencimento", vencimento);
            comando.Parameters.AddWithValue("pagamento", pagamento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
