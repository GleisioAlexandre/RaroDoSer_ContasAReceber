﻿using FirebirdSql.Data.FirebirdClient;
using ProjetoContasAReceberRaro.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContasAReceberRaro.controller
{
    class ClassCrudCliente
    {
        FbConnection conexao = new FbConnection(ClassConexao.Conexao);

        public DataTable CarregaGridCliente()
        {
            
            conexao.Open();
            DataTable dt = new DataTable();
            FbCommand comando = new FbCommand("select id_cliente, nome_cliente, cpf_cliente, cnpj_cliente, cep_cliente, logradouro_cliente, numero_cliente,complemento_cliente, bairro_cliente," +
                "(select estado from tb_estado where id_estado_cliente = id_uf)," +
                "(select cidade from tb_uf where id_cidade_cliente = id_cidade) " +
                "from tb_cliente",conexao);
            FbDataAdapter dataAdapter = new FbDataAdapter(comando);
            dataAdapter.Fill(dt);
            conexao.Close();

            return dt;
        }
        public List<string> CarregaEstado()
        {
            conexao.Open();
            List<string> estado = new List<string>();
            FbCommand comando = new FbCommand("select cidade from tb_uf", conexao);
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
            FbCommand comando = new FbCommand("select estado from tb_estado",conexao);
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
            conexao.Open();
            FbCommand comando = new FbCommand("insert into tb_cliente  (nome_cliente, cpf_cliente, cnpj_cliente, cep_cliente, logradouro_cliente, numero_cliente, complemento_cliente, bairro_cliente, id_cidade_cliente, id_estado_cliente) " +
                    "values" +
                    "(@nome, @cpf, @cnpj, @cep, @logradouro, @numero, @complemento, @bairro, @id_cidade, @id_estado); ",conexao);
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
        public void DeletarCliente(int id)
        {
            try
            {
                conexao.Open();
                FbCommand comando = new FbCommand("delete from tb_cliente where id_cliente = @id",conexao);
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
        public void EditarCadCliente(int id, string nome, string cnpj, string cpf, string cep, string logradouro, int numero, string complemento, string bairro, int id_cidade, int id_estado)
        {
                conexao.Close();
                FbCommand comando = new FbCommand("update tb_cliente set nome_cliente = @nome, cnpj_cliente = @cnpj, cpf_cliente = @cpf, cep_cliente = @cep, logradouro_cliente = @logradouro, numero_cliente = @numero, complemento_cliente = @complemento, bairro_cliente = @bairro, id_cidade_cliente = @id_cidade, id_estado_cliente = @id_estado where id_cliente = @id",conexao);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@cnpj", cnpj);
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
        public ClassCliente PesquisaClientePF(string dados)
        {
            conexao.Open();
            FbCommand comando = new FbCommand("select id_cliente, nome_cliente, cpf_cliente, cep_cliente, logradouro_cliente, numero_cliente, complemento_cliente, bairro_cliente, id_cidade_cliente, id_estado_cliente  from tb_cliente where nome_cliente like @nome or cpf_cliente = @cpf",conexao);
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
            ClassCliente cliente = new ClassCliente();
            conexao.Open();
            FbCommand comando = new FbCommand("select id_cliente, nome_cliente, cnpj_cliente, cep_cliente, logradouro_cliente, numero_cliente, complemento_cliente, bairro_cliente, id_cidade_cliente, id_estado_cliente  from tb_cliente where nome_cliente like @nome or cnpj_cliente = @cnpj",conexao);
            comando.Parameters.AddWithValue("@nome", dados + "%");
            comando.Parameters.AddWithValue("@cnpj", dados);
            FbDataReader leitor = comando.ExecuteReader();
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
            conexao.Close();
            return cliente;
        }
        public ClassCliente PesquisaCliente(string dados)
        {
            conexao.Open();
            FbCommand comando = new FbCommand("select id_cliente, nome_cliente from tb_cliente where nome_cliente like (@nome)",conexao);
            comando.Parameters.AddWithValue("@nome", dados + "%");
            FbDataReader leitor = comando.ExecuteReader();
            ClassCliente cliente = new ClassCliente();
            while (leitor.Read())
            {
                cliente.Codigo = Convert.ToInt32(leitor[0].ToString());
                cliente.Nome = leitor[1].ToString();
            }
            conexao.Close();
            return cliente;
        }
    }
}

