using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassCrudProduto
    {
        DataTable dt = new DataTable();
        FbConnection conexao = new FbConnection(ClassConexao.Conexao);

        public DataTable CarregaProduto()
        {
            conexao.Open();
            FbCommand comando = new FbCommand("select * from tb_produto", conexao);
            FbDataAdapter dataAdapter = new FbDataAdapter(comando);
            dataAdapter.Fill(dt);
            conexao.Close();
            return dt;
        }
    }
}
