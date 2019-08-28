using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Npgsql;
using Database;
using System.Windows.Forms;

namespace Database
{
    public class Conexao
    {
        String conexao;
        String sql;
        NpgsqlConnection conecta;
        NpgsqlCommand cmd;

        public Conexao()
        {
            conexao = String.Format("Server=localhost;Port=5432;username=postgres;password=123;database=Bercario");
            conecta = new NpgsqlConnection(conexao);
            cmd = new NpgsqlCommand();
        }

        //Preenche uma DataTable para inserção das cidades no cboNaturalidade
        public DataTable preencheCidades()
        {
            conecta.Open();
            cmd.Connection = conecta;
            cmd.CommandText = "select cidade from naturalidade;";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.Dispose();
            conecta.Close();
            return dt;
        }

        //Relização do cadastro de recem nascidos
        public void cadastrarRN(RecemNascido rn)
        {        
            conecta.Open();
            sql = "SELECT insertRecemNascido(@_nome, @_data_nascimento, @_hora_nascimento, @_id_sexo, @_DNVDO);";
            cmd = new NpgsqlCommand(sql, conecta);
            cmd.Parameters.Add(new NpgsqlParameter("@_nome", rn.NomeRN));                                 
            cmd.Parameters.Add(new NpgsqlParameter("@_data_nascimento", rn.DataNascimentoRN));
            cmd.Parameters.Add(new NpgsqlParameter("@_hora_nascimento", rn.HoraNascimentoRN));
            cmd.Parameters.Add(new NpgsqlParameter("@_id_sexo", rn.IdsexRN));
            cmd.Parameters.Add(new NpgsqlParameter("@_DNVDO", rn.NumeroDVNDO));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conecta.Close();            
        }

        //Cadastro das informações necessárias no Livro("A, C AUX") correspondente
        public void cadastrarLivroRegistro(Livro_Registro livro)
        {
            conecta.Open();
            sql = "SELECT insertLivro(@_id_tipo, @_n_pagina, @_n_registro, @_n_livro);";
            cmd = new NpgsqlCommand(sql, conecta);
            cmd.Parameters.Add(new NpgsqlParameter("@_id_tipo", livro.IdTipoLivro));
            cmd.Parameters.Add(new NpgsqlParameter("@_n_pagina", livro.NumeroPagina));
            cmd.Parameters.Add(new NpgsqlParameter("@_n_registro", livro.NumeroRegistro));
            cmd.Parameters.Add(new NpgsqlParameter("@_n_livro", livro.NumeroLivro));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conecta.Close();
        }

        //Cadastro dos parentes
        public void cadastrarParente(Parentesco parente)
        {
            conecta.Open();
            sql = "select insertParentesco(@_nome, @_dt_nascimento, @_idade, @_uf, @_naturalidade, @_id_parentesco);";
            cmd = new NpgsqlCommand(sql, conecta);
            cmd.Parameters.Add(new NpgsqlParameter("@_nome", parente.Nome));
            cmd.Parameters.Add(new NpgsqlParameter("@_dt_nascimento", parente.Data_nascimento));
            cmd.Parameters.Add(new NpgsqlParameter("@_idade", parente.Idade));
            cmd.Parameters.Add(new NpgsqlParameter("@_uf", parente.Uf));
            cmd.Parameters.Add(new NpgsqlParameter("@_naturalidade", parente.Naturalidade));
            cmd.Parameters.Add(new NpgsqlParameter("@_id_parentesco", parente.Id_parentesco));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conecta.Close();
        }

        //Preenchimento do DataTable para consulta e exibição de recem nascidos
        public DataTable consultaNomeRN(String pesquisa)
        {
            try
            {
                conecta.Open();
                cmd.Connection = conecta;
                cmd.CommandText = "select * from pesquisaNomeRN(@_pesquisa);";
                cmd.Parameters.Add(new NpgsqlParameter("@_pesquisa", pesquisa));
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
                conecta.Close();
                return dt;
            }
            catch (Exception ex) {
                return null;
            }
        }

        //Realização de consultas de DNV ou DO
        public DataTable consultaDnvDo(String pesquisa)
        {
            try
            {
                conecta.Open();
                cmd.Connection = conecta;
                cmd.CommandText = "select * from pesquisaDnvDo(@_pesquisa);";
                cmd.Parameters.Add(new NpgsqlParameter("@_pesquisa", pesquisa));
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
                conecta.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conulta Dnv / DO!" + ex);
                return null;
            }
        }

        //Consulta por parentesco
        public DataTable consultaParentesco(String pesquisa)
        {
            try
            {
                conecta.Open();
                cmd.Connection = conecta;
                cmd.CommandText = "select * from pesquisaParente(@_pesquisa);";
                cmd.Parameters.Add(new NpgsqlParameter("@_pesquisa", pesquisa));
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
                conecta.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
