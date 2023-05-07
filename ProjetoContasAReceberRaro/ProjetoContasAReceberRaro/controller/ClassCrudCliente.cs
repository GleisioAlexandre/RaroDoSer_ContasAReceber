using FirebirdSql.Data.FirebirdClient;
using ProjetoContasAReceberRaro.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassCrudCliente
    {
        FbConnection conexao = new FbConnection("User=SYSDBA;Password=masterkey;Database=C:/Users/Gleisio/Documents/C#/RaroDoSer_ContasAReceber/ProjetoContasAReceberRaro/ProjetoContasAReceberRaro/BD/RARO.FDB;DataSource=localhost;Port=3050");
       
        public DataTable CarregaGridCliente()
        {
            conexao.Open();
            DataTable dt = new DataTable();
            FbCommand comando = new FbCommand("select id_cliente, nome_cliente, cpf_cliente, cnpj_cliente, cep_cliente, logradouro_cliente, numero_cliente,complemento_cliente, bairro_cliente," +
                "(select estado from tb_estado where id_estado_cliente = id_uf)," +
                "(select cidade from tb_uf where id_cidade_cliente = id_cidade) " +
                "from tb_cliente", conexao);
            FbDataAdapter dataAdapter = new FbDataAdapter(comando);
            dataAdapter.Fill(dt);
            conexao.Close();

            return dt;
        }
        public List<string> CarregaEstado()
        {
            conexao.Open();
            List<string> estado = new List<string>();
            FbCommand comando = new FbCommand("select u.cidade from tb_uf u", conexao);
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                estado.Add(leitor.GetString(0));
            }
            conexao.Close();
            return estado;
        }
        public List<string> CarregaCidade()
        {
            conexao.Open();
            List<string> cidade = new List<string>();
            FbCommand comando = new FbCommand("select e.estado from tb_estado e", conexao);
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                cidade.Add(leitor.GetString(0));
            }
            conexao.Close();
            return cidade;
        }
        public void inserirCliente(string nome, string cpf, string cnpj, string cep, string logradouro, int numero, string complemento, string bairro, int id_cidade, int id_estado)
        {
            try
            {
                conexao.Open();
                FbCommand comando = new FbCommand("insert into tb_cliente  (nome_cliente, cpf_cliente, cnpj_cliente, cep_cliente, logradouro_cliente, numero_cliente, complemento_cliente, bairro_cliente, id_cidade_cliente, id_estado_cliente) " +
                    "values" +
                    "(@nome, @cpf, @cnpj, @cep, @logradouro, @numero, @complemento, @bairro, @id_cidade, @id_estado); ", conexao);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@cnpj", cnpj);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@logradouro", logradouro);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.Parameters.AddWithValue("@complemento", complemento);
                comando.Parameters.AddWithValue("@bairro", bairro);
                comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                comando.Parameters.AddWithValue("@id_estado", id_estado);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir o registro ao bacno de dados!: \n {ex.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void DeletarCliente(int id)
        {
            try
            {
                conexao.Open();
                FbCommand comando = new FbCommand("delete from tb_cliente where id_cliente = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao remover o registro do banco de dados! \n{ex.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void EditarCadClientePf(int id, string nome, string cpf, string cep, string logradouro, int numero, string complemento, string bairro, int id_cidade, int id_estado)
        {
            try
            {
                conexao.Open();
                FbCommand comando = new FbCommand("update tb_cliente c set nome_cliente = @nome, cpf_cliente = @cpf, cep_cliente = @cep, logradouro_cliente = @logradouro, numero_cliente = @numero, complemento_cliente = @complemento, bairro_cliente = @bairro, id_cidade_cliente = @idcidade, id_estado_cliente = @estado where id_cliente = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@logradouro", logradouro);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.Parameters.AddWithValue("@complemento", complemento);
                comando.Parameters.AddWithValue("@bairro", bairro);
                comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                comando.Parameters.AddWithValue("@id_estado", id_estado);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Atualizar o registro no banco de dados!\n {ex.Message }");
            }
            finally
            {
                conexao.Close();
            }
        }
        public ClassCliente PesquisaClientePF(string dados)
        {
            conexao.Open();
            FbCommand comando = new FbCommand("select id_cliente, nome_cliente, cpf_cliente, cep_cliente, logradouro_cliente, numero_cliente, complemento_cliente, bairro_cliente, id_cidade_cliente, id_estado_cliente  from tb_cliente where nome_cliente like @nome or cpf_cliente = @cpf", conexao);
            comando.Parameters.AddWithValue("@nome", dados + "%");
            comando.Parameters.AddWithValue("@cpf", dados);
            FbDataReader leitor = comando.ExecuteReader();
            ClassCliente cliente = new ClassCliente();
            while (leitor.Read())
            {
                cliente.Codigo = Convert.ToInt32(leitor[0]);
                cliente.Nome = leitor[1].ToString();
                cliente.Cpf = leitor[2].ToString();
                cliente.Cep = leitor[3].ToString();
                cliente.Logradouro = leitor[4].ToString();
                cliente.Numero = Convert.ToInt32(leitor[5].ToString());
                cliente.Complemento = leitor[6].ToString();
                cliente.Bairro = leitor[7].ToString();
                cliente.Id_cidade = Convert.ToInt32(leitor[8]);
                cliente.Id_estado = Convert.ToInt32(leitor[9]);
            }
            leitor.Close();
            conexao.Close();
            return cliente;
        }
        public ClassCliente PesquisaClinetePJ(string dados)
        {
            conexao.Open();
            FbCommand comando = new FbCommand("select id_cliente, nome_cliente, cnpj_cliente, cep_cliente, logradouro_cliente, numero_cliente, complemento_cliente, bairro_cliente, id_cidade_cliente, id_estado_cliente  from tb_cliente where nome_cliente like @nome or cnpj_cliente = @cnpj", conexao);
            comando.Parameters.AddWithValue("@nome", dados + "%");
            comando.Parameters.AddWithValue("@cnpj", dados);
            FbDataReader leitor = comando.ExecuteReader();
            ClassCliente cliente = new ClassCliente();
            while (leitor.Read())
            {
                cliente.Codigo = Convert.ToInt32(leitor[0]);
                cliente.Nome = leitor[1].ToString();
                cliente.Cnpj = leitor[2].ToString();
                cliente.Cep = leitor[3].ToString();
                cliente.Logradouro = leitor[4].ToString();
                cliente.Numero = Convert.ToInt32(leitor[5].ToString());
                cliente.Complemento = leitor[6].ToString();
                cliente.Bairro = leitor[7].ToString();
                cliente.Id_cidade = Convert.ToInt32(leitor[8]);
                cliente.Id_estado = Convert.ToInt32(leitor[9]);
            }
            return cliente;
        }
    }
}

