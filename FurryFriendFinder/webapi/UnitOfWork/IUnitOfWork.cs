using Microsoft.EntityFrameworkCore;
using webapi.Models;
using webapi.Models.Entities;
using webapi.Repositories;

namespace webapi.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        public int Save();
    }
}
