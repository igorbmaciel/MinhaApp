using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.DataAccess.Context;
using MinhaApp.Domain.Models;
using MinhaApp.Domain.Repositories;


namespace MinhaApp.DataAccess.Repositories
{
    public class ProcessoRepository :IProcessoRepository
    {
        protected MinhaAppContext Db = new MinhaAppContext();

        public List<Processo> BuscarProcessos()
        {
            return Db.Set<Processo>().ToList();
        }

        public void InserirProcesso(Processo processo)
        {
            Db.Set<Processo>().Add(processo);
            Db.SaveChanges();
        }

        public void AtualizarProcesso(Processo processo)
        {
            throw new NotImplementedException();
        }

        public void ExcluirProcesso(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
