using Hiper.Application.Contracts;
using System;
using System.Collections.Generic;

namespace Hiper.Application
{
    public class BaseApp<T> : IBaseApp<T> where T : class
    {
        public void Create(T model)
        {
            throw new NotImplementedException();
        }

        public void Delete(T model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
