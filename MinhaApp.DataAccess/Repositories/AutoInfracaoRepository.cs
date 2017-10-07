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
    public class AutoInfracaoRepository : IAutoInfracaoRepository
    {
        protected MinhaAppContext Db = new MinhaAppContext();
        public void CriarAutoInfracao(AutoInfracao autoInfracao)
        {
            Db.Set<AutoInfracao>().Add(autoInfracao);
            Db.SaveChanges();
        }
    }
}
