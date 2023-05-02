using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjetoContasAReceberRaro.model;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassBuscaCep
    {
        public  Endereco BuscaCep(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            using (var cliente = new WebClient())
            {
                cliente.Encoding = Encoding.UTF8;
                var json = cliente.DownloadString(url);
                var endereco = JsonConvert.DeserializeObject<Endereco>(json);
                    return endereco;
            }
        }
      
    }
}
