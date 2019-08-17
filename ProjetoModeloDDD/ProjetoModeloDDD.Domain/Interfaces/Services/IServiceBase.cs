using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAllAsNoTraking();

        TEntity GetById(int id);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}