namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using DataTransportLayer;
    using Dapper;
    using System.Data.SqlClient;
    using System.Linq;

    public class PersistenciaEndereco : Conexao
    {
        public PersistenciaEndereco(string ConnectionString) : base(ConnectionString) { }

        public Endereco SelecionarEndereco(int id)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECIONAR_ENDERECO";
                    return con.Query<Endereco>(query, id).FirstOrDefault();
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


        public List<Endereco> SelecionarLista(int idPessoa)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECIONAR_LISTA_ENDERECO";
                    return con.Query<Endereco>(query, idPessoa).ToList<Endereco>();
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
