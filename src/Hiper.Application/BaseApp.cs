using Hiper.Application.Contracts;
using Hiper.SharedKernel.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Hiper.Application
{
    public class BaseApp<T> : IBaseApp<T> where T : class
    {
        protected readonly CommonContext _commonContext;
        protected DbSet<T> _dbSet;

        public BaseApp(CommonContext commonContext)
        {
            _commonContext = commonContext;

            _dbSet = _commonContext.Set<T>();
        }

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
            _commonContext.Dispose();
            _dbSet = null;
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
