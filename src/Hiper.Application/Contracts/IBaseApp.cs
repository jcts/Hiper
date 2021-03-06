using System;
using System.Collections.Generic;

namespace Hiper.Application.Contracts
{
    public interface IBaseApp<T> : IDisposable where T : class
    {
        void Create(T model);
        void Delete(T model);
        void Update(T model);
        T GetById(Guid id);
        ICollection<T> GetAll();
    }
}
