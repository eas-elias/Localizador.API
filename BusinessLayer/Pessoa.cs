namespace BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DataTransportLayer;
    using DataAccess;
    using System.Configuration;
    

    public class GerenciadorPessoa
    {
        PersistenciaPessoa Persistencia;
        public string Mensagem { get; set; }

        public GerenciadorPessoa()
        {
            Persistencia = new PersistenciaPessoa(ConfigurationManager.ConnectionStrings["LOCALIZADOR"].ConnectionString);
        }

        public List<Pessoa> SelecionarListaAmigo(string Usuario)
        {
            try
            {
                return Persistencia.SelecionarListaAmigo(Usuario);
            }
            catch (Exception ex)
            {
                Mensagem = "Ocorreu um erro: " + ex.Message;
                return new List<Pessoa>();
            }
        }


        public List<Pessoa> SelecionarListaUsuario()
        {
            try
            {
                return Persistencia.SelecionarListaUsuario();
            }
            catch (Exception ex)
            {
                Mensagem = "Ocorreu um erro: " + ex.Message;
                return new List<Pessoa>();
            }
        }

    }
}
