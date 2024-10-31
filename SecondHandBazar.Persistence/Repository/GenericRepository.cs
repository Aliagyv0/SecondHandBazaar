using Microsoft.EntityFrameworkCore;
using SecondHandBazar.Application.Repository;
using SecondHandBazar.Domain.Entities.BaseEntities;
using SecondHandBazar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandBazar.Persistence.Repository
{
    public class GenericRepository<T>(AppDbContext _dbContext, AppDbContext context) : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        private readonly DbSet<T> _dbSet = _dbContext.Set<T>();
        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);
        public async Task<T> GetAsync(Guid id) => await _dbSet.FindAsync(id);
        public IQueryable<T> GetAll() => _dbSet.AsQueryable().AsNoTracking();
        public void Remove(T entity) => _dbSet.Remove(entity);
        public void Update(T entity)
        {
            var oldEntity = _dbSet.Find(entity.Id);
            _dbSet.Entry(oldEntity).State = EntityState.Detached;
            _dbSet.Entry(entity).State = EntityState.Added;
            _dbSet.Update(entity);
        }

    }
}
