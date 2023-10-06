using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected BlogContext _context;
        private readonly DbSet<TEntity> _dbset;
        public Repository(BlogContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entity)
        {
            await _dbset.AddRangeAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() =>
              _dbset.Remove(entity)
            );
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {

            return filter == null
                   ? await _dbset.ToListAsync()
                   : await _dbset.Where(filter).ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            _dbset.Attach(entity)
            );
        }
    }
}
