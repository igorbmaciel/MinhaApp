using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MinhaApp.DataAccess.Repositories;
using MinhaApp.Domain.Models;
using MinhaApp.Domain.Services;

namespace MinhaApp.SVC.Controllers
{
    public class AutoInfracoesController : ApiController
    {
        private readonly IAutoInfracaoService _service;

        public AutoInfracoesController()
        {
            var _repository = new AutoInfracaoRepository();
            _service = new AutoInfracaoService(_repository);
        }

        // GET: api/AutoInfracoes
        public List<AutoInfracao> Get()
        {
           return new List<AutoInfracao>();
        }

        // GET: api/AutoInfracao/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AutoInfracoes
        public void Post(AutoInfracao autoInfracao)
        {
            _service.CriarAutoInfracao(autoInfracao);
        }

        // PUT: api/AutoInfracoes/5
        public void Put()
        {
            
        }

        // DELETE: api/AutoInfracao/5
        public void Delete(int id)
        {
            
        }
    }
}