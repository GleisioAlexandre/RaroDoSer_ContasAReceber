using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.model
{
    class ClassCliente
    {
        private int codigo;
        private string nome;
        private string cpf;
        private string cnpj;
        private string cep;
        private string logradouro;
        private int numero;
        private string complemento;
        private string bairro;
        private int id_cidade;
        private int id_estado;

        public ClassCliente()
        {
        }

        public ClassCliente(int codigo, string nome, string cpf, string cnpj, string cep, string logradouro, int numero, string complemento, string bairro, int id_cidade, int id_estado)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.cnpj = cnpj;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.id_cidade = id_cidade;
            this.id_estado = id_estado;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public int Id_cidade { get => id_cidade; set => id_cidade = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
    }
}
