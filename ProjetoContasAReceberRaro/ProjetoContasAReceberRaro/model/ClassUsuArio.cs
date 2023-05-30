using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.model
{
    class ClassUsuario
    {
        private int id_usuario;
        private string nome;
        private string cpf;
        private string user;
        private string password;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
    }
}
