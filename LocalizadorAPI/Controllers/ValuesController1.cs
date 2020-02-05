using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using DataTransportLayer;
using Newtonsoft;

namespace LocalizadorAPI.Controllers
{
    public class ValuesController : ApiController
    {
        public string Get(string Usuario)
        {
            GerenciadorPessoa pessoa_business = new GerenciadorPessoa();

            var dados =  pessoa_business.SelecionarListaAmigo(Usuario);

            return Newtonsoft.Json.JsonConvert.SerializeObject(dados);
        }


        public string Get()
        {
            GerenciadorPessoa pessoa_business = new GerenciadorPessoa();

            var dados = pessoa_business.SelecionarListaUsuario();

            return Newtonsoft.Json.JsonConvert.SerializeObject(dados);
        }

    }
}