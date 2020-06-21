using DevIO.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevIO.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : Entity
    {
      
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Add(TEntity entity);
        Task Remover(Guid Id);
        Task Atualizar(TEntity entity);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
        
    }
}
