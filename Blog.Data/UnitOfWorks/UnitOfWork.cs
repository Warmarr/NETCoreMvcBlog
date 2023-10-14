using Blog.Data.Context;
using Blog.Data.Repositories.Abstract;
using Blog.Data.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async ValueTask DisposeAsync()
        {
            await _appDbContext.DisposeAsync();
        }

        public int Save()
        {
           return _appDbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _appDbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(_appDbContext);
        }
    }
}
