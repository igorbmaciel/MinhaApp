using MinhaApp.DataAccess.Repositories;
using MinhaApp.Domain.Repositories;
using MinhaApp.Domain.Services;
using System.Collections.Generic;
using System.Web.Http;
using MinhaApp.Domain.Models;

namespace MinhaApp.SVC.Controllers
{
    public class ProcessosController : ApiController
    {
        private readonly IProcessoService _service;

        public ProcessosController()
        {
            var _repository = new ProcessoRepository();
            _service = new ProcessoService(_repository);
        }

        // GET: api/Processos
        public List<Processo> Get()
        {
            return _service.BuscarProcessos();
        }

        // GET: api/Processo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Processos
        public void Post(Processo processo)
        {
            _service.InserirProcesso(processo);
        }

        // PUT: api/Processos/5
        public void Put(Processo processo)
        {
            _service.AtualizarProcesso(processo);
        }

        // DELETE: api/Processo/5
        public void Delete(int id)
        {
            _service.ExcluirProcesso(id);
        }
    }
}
