using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Domain.Models;
using MinhaApp.Domain.Repositories;

namespace MinhaApp.Domain.Services
{
    public class AutoInfracaoService : IAutoInfracaoService
    {
        private readonly IAutoInfracaoRepository _repository;

        public AutoInfracaoService(IAutoInfracaoRepository repository)
        {
            _repository = repository;
        }

        public void CriarAutoInfracao(AutoInfracao autoInfracao)
        {
            _repository.CriarAutoInfracao(autoInfracao);
        }
    }
}
