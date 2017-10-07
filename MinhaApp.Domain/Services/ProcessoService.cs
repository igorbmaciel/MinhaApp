using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Domain.Models;
using MinhaApp.Domain.Repositories;

namespace MinhaApp.Domain.Services
{
    public class ProcessoService : IProcessoService
    {
        private readonly IProcessoRepository _repository;

        public ProcessoService(IProcessoRepository repository)
        {
            _repository = repository;
        }

        public List<Processo> BuscarProcessos()
        {
            return _repository.BuscarProcessos();
        }

        public void InserirProcesso(Processo processo)
        {
            _repository.InserirProcesso(processo);
        }

        public void AtualizarProcesso(Processo processo)
        {
            _repository.AtualizarProcesso(processo);
        }

        public void ExcluirProcesso(int Id)
        {
            _repository.ExcluirProcesso(Id);
        }
    }
}
