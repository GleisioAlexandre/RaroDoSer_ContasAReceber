using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.model
{
    class Endereco
    {
        private string logradouro;
        private string bairro;
        private string localidade;
        private string uf;
        private string cep;

        public Endereco()
        {
        }

        public Endereco(string logradouro, string bairro, string localidade, string uf, string cep)
        {
            this.Logradouro = logradouro;
            this.Bairro = bairro;
            this.Localidade = localidade;
            this.Uf = uf;
            Cep = cep;

        }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Localidade { get => localidade; set => localidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }

    }
}
