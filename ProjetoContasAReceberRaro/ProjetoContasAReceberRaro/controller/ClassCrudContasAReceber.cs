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
        FbConnection conexao = new FbConnection("User=SYSDBA;Password=masterkey;Database=D:/C#/ProjetoRaroDoSer/ProjetoContasAReceberRaro/ProjetoContasAReceberRaro/BD/RARO.FDB;DataSource=localhost;Port=3050");

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
    }
}
