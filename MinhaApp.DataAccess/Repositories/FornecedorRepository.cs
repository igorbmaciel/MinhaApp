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
    public class FornecedorRepository : IFornecedorRepository
    {
        protected MinhaAppContext Db = new MinhaAppContext();

        public List<Fornecedor> BuscarFornecedores()
        {
            return Db.Set<Fornecedor>().ToList();
        }

        public void CriarFornecedor(Fornecedor fornecedor)
        {
            Db.Set<Fornecedor>().Add(fornecedor);
            Db.SaveChanges();
        }
    }
}
