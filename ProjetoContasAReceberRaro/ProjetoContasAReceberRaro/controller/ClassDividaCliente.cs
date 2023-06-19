using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassDividaCliente
    {
        private int id_conta;
        private int id_cliente;
        private string cliente;
        private string entrada;
        private double valor;
        private string situacao;
        private string documento;
        private string classe;
        private string vencimento;
        private string pagamento;

        public ClassDividaCliente()
        {
        }

        public ClassDividaCliente(int id_conta, int id_cliente, string cliente, string entrada, double valor, string situacao, string documento, string classe, string vencimento, string pagamento)
        {
            this.id_conta = id_conta;
            this.id_cliente = id_cliente;
            this.cliente = cliente;
            this.entrada = entrada;
            this.valor = valor;
            this.situacao = situacao;
            this.documento = documento;
            this.classe = classe;
            this.vencimento = vencimento;
            this.pagamento = pagamento;
        }

        public int Id_conta { get => id_conta; set => id_conta = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Entrada { get => entrada; set => entrada = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Classe { get => classe; set => classe = value; }
        public string Vencimento { get => vencimento; set => vencimento = value; }
        public string Pagamento { get => pagamento; set => pagamento = value; }
    }
}
