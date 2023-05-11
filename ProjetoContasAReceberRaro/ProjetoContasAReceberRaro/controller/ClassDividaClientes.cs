using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassDividaClientes
    {
        private int id_conta;
        private string cliente;
        private string entrada;
        private double valor;
        private int id_situacao;
        private string documento;
        private int id_classe;
        private string vencimento;
        private string pagamento;

        public ClassDividaClientes()
        {
        }

        public ClassDividaClientes(int id_conta, string cliente, string entrada, double valor, int id_situacao, string documento, int id_classe, string vencimento, string pagamento)
        {
            this.id_conta = id_conta;
            this.cliente = cliente;
            this.entrada = entrada;
            this.valor = valor;
            this.id_situacao = id_situacao;
            this.documento = documento;
            this.id_classe = id_classe;
            this.vencimento = vencimento;
            this.pagamento = pagamento;
        }

        public int Id_conta { get => id_conta; set => id_conta = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Entrada { get => entrada; set => entrada = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Id_situacao { get => id_situacao; set => id_situacao = value; }
        public string Documento { get => documento; set => documento = value; }
        public int Id_classe { get => id_classe; set => id_classe = value; }
        public string Vencimento { get => vencimento; set => vencimento = value; }
        public string Pagamento { get => pagamento; set => pagamento = value; }
    }
}
