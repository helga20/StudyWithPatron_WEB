using Microsoft.EntityFrameworkCore;
using StudyWithPatron.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Threading.Tasks;

namespace StudyWithPatron.DAL.Repositories
{
    internal class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly PatronContext _context;

        public GenericRepository(PatronContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }

            this._context = context;
            this._dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            return _dbSet.FindAsync(id);
        }

        public void Create(T entity)
        {
            if (entity == null)
            { 
                throw new ArgumentNullException();
            }

            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            _dbSet.Remove(entity);
        }
    }
}