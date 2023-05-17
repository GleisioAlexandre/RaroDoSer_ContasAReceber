using FirebirdSql.Data.FirebirdClient;
using ProjetoContasAReceberRaro.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassCrudContasAReceber
    {
        string stringConexao = ClassConexao.Conexao;
        public DataTable CarregaGridConatas()
        {
            FbConnection conexao = new FbConnection(stringConexao);
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
            FbConnection conexao = new FbConnection(stringConexao);
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
            FbConnection conexao = new FbConnection(stringConexao);
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
        //Classe usada para inserir dividas dos clientes no banco de dados
        public void InserirDivida(int id_cliente, string entrada, double valor, int id_situacao, string documento, int id_classe, string vencimento, string pagamento)
        {
            FbConnection conexao = new FbConnection(stringConexao);
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
        public ClassDividaClientes PesquisaDivida(string dados)
        {
            FbConnection conexao = new FbConnection(stringConexao);
            conexao.Open();
            FbCommand comando = new FbCommand("select cr.id_contasareceber, cr.id_cliente, cr.data_entrada, cr.valor, cr.documento, cr.data_vencimento, cr.data_pagamento," +
                "(select c.nome_cliente from tb_cliente c where cr.id_cliente = c.id_cliente)," +
                "(select s.situacao from tb_situacao s where cr.id_situacao = s.id_situacao)," +
                "(select cl.class from tb_calsse cl where cr.id_classe = cl.id_class)" +
                "from tb_contas_a_receber cr where cr.documento = @documento", conexao);
            comando.Parameters.AddWithValue("@documento", dados);
            FbDataReader leitor = comando.ExecuteReader();
            ClassDividaClientes divida = new ClassDividaClientes();
            while (leitor.Read())
            {
                divida.Id_conta = Convert.ToInt32(leitor[0].ToString());
                divida.Id_cliente = Convert.ToInt32(leitor[1].ToString());
                divida.Entrada = leitor[2].ToString();
                divida.Valor = Convert.ToDouble(leitor[3].ToString());
                divida.Documento = leitor[4].ToString();
                divida.Vencimento = leitor[5].ToString();
                divida.Pagamento = leitor[6].ToString();
                divida.Cliente = leitor[7].ToString();
                divida.Situacao = leitor[8].ToString();
                divida.Classe = leitor[9].ToString();
            }conexao.Close();
            return divida;
        }
        public void EditarDivida(int id_contas, int cliente, string entrada, double valor, int situacao, string documento, int classe, string vencimento, string pagamento)
        {
            FbConnection conexao = new FbConnection(stringConexao);
            conexao.Open();
            FbCommand comando = new FbCommand("update tb_contas_a_receber  set id_cliente = @cliente, data_entrada = @entrada, valor = @valor, id_situacao = @situacao, documento = @documento, id_classe = @classe, data_vencimento = @vencimento, data_pagamento = @pagamento where id_contasareceber = @id_contasareceber", conexao);
            comando.Parameters.AddWithValue("@cliente", cliente);
            comando.Parameters.AddWithValue("@entrada", entrada);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@situacao", situacao);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@classe", classe);
            comando.Parameters.AddWithValue("@vencimento", vencimento);
            comando.Parameters.AddWithValue("@pagamento", pagamento);
            comando.Parameters.AddWithValue("@id_contasareceber", id_contas);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
