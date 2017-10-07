using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Domain.Helper
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IList<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
        TEntity Adicionar(TEntity obj);
        TEntity Atualizar(TEntity obj);
        void Remover(int id);
        IList<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
    }
}
