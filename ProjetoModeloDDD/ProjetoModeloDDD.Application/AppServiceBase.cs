using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEnity> : IDisposable, IAppServiceBase<TEnity> where TEnity : class
    {
        // Para não criar uma instância da minha classe de serviço aqui.
        private readonly IServiceBase<TEnity> _serviceBase;

        public AppServiceBase(IServiceBase<TEnity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEnity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IEnumerable<TEnity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public IEnumerable<TEnity> GetAllAsNoTraking()
        {
            return _serviceBase.GetAllAsNoTraking();
        }

        public TEnity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEnity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEnity obj)
        {
            _serviceBase.Update(obj);
        }
    }
}
