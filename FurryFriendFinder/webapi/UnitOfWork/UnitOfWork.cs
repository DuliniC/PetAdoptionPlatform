using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Net;
using webapi.Models;
using webapi.Models.Entities;
using webapi.Repositories;

namespace webapi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private FFriendFinderDbContext _dbContext;
        private IGenericRepository<User> userRepository = null;
        public UnitOfWork(FFriendFinderDbContext friendFinderDbContext)
        {
            _dbContext = friendFinderDbContext;
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(_dbContext);
                }
                return userRepository;
            }
        }
        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
