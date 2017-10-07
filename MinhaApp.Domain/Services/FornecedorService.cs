using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Domain.Models;
using MinhaApp.Domain.Repositories;

namespace MinhaApp.Domain.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public List<Fornecedor> BuscarFornecedores()
        {
            return _repository.BuscarFornecedores();
        }

        public void CriarFornecedor(Fornecedor fornecedor)
        {
            _repository.CriarFornecedor(fornecedor);
        }
        
    }
}
