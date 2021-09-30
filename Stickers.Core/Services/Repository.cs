using Microsoft.EntityFrameworkCore;
using Stickers.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Stickers.Core.Services
{
    public class Repository<TEntity> where TEntity : class
    {
        private readonly StickersDbContext _context;
        public Repository(StickersDbContext context)
        {
            this._context = context;
        }

        public IQueryable<TEntity> DbSet => _context.Set<TEntity>();
        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            if (entity == null)
            {
                return null;
            }

            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();

            return entity;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
