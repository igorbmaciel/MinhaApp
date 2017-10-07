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
    public class FornecedoresController : ApiController
    {
        private readonly IFornecedorService _service;

        public FornecedoresController()
        {
            var _repository = new FornecedorRepository();
            _service = new FornecedorService(_repository);
        }

        // GET: api/Fornecedores
        public List<Fornecedor> Get()
        {
            return _service.BuscarFornecedores();
        }

        // GET: api/Fornecedor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Fornecedores
        public void Post(Fornecedor fornecedor)
        {
            _service.CriarFornecedor(fornecedor);
        }

        // PUT: api/Fornecedores/5
        public void Put(Processo processo)
        {
          
        }

        // DELETE: api/Fornecedor/5
        public void Delete(int id)
        {
            
        }
    }
}