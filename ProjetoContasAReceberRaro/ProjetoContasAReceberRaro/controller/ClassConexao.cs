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
        public static string Conexao
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;
            }
        }
    }
}
