using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using webapi.Models;

namespace webapi.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(DbContext context)
        {
            this._dbContext = context;
            this._dbSet = context.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public virtual IEnumerable<T> Get(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = "", int skip = 0,
            int take = 0)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null && take != 0)
            {
                return orderBy(query).Skip(skip).Take(take).ToList();
            }
            else if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        /// <summary>
        /// Return a record set based on a raw SQL statement
        /// </summary>
        /// <param name="query">SQL Query</param>
        /// <param name="parameters">Parameters</param>
        /// <returns></returns>
        public IEnumerable<T> GetWithRawSql(string query, params object[] parameters)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentException("Query is empty");
            }

            return _dbSet.FromSqlRaw(query, parameters).ToList();
        }

        public virtual T GetById(object id)
        {
            return _dbSet.Find(id);
        }


        public virtual T GetFirstOrDefault(Expression<Func<T, bool>> filter = null,
                    params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;

            foreach (Expression<Func<T, object>> include in includes)
                query = query.Include(include);

            return query.FirstOrDefault(filter);
        }
    }
}
