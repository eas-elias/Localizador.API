namespace DataAccess
{
    using System;
    using DataTransportLayer;
    using Dapper;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Collections.Generic;

    public class PersistenciaPessoa : Conexao
    {

        public PersistenciaPessoa(string ConnectionString) : base(ConnectionString) { }

        public Pessoa SelecionarPessoa(int id)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECIONAR_PESSOA";
                    return con.Query<Pessoa>(query, id).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }




        public List<Pessoa> SelecionarListaAmigo(string Usuario)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECIONAR_LISTA_AMIGO";

                    return con.Query<Pessoa, Endereco, Pessoa>(
                         sql: query,
                         map: (pessoa, endereco) =>
                         {
                             pessoa.EnderecoAtual = endereco;
                             return pessoa;
                         },
                         param: new { @DS_USUARIO = Usuario },
                         splitOn: "IdEndereco",
                         commandType: System.Data.CommandType.StoredProcedure
                    ).ToList();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }



        public List<Pessoa> SelecionarListaUsuario()
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECIONAR_LISTA_USUARIO";

                    return con.Query<Pessoa>(
                         sql: query,
                         commandType: System.Data.CommandType.StoredProcedure
                    ).ToList();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }



    }
}
