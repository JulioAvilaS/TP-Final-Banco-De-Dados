using AplicationTpDB.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using AplicationTpDB.Interface;

namespace AplicationTpDB.Domain.Repositorios.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T?> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                var deleted = await _dbSet.FirstOrDefaultAsync(predicate);
                if (deleted != null)
                {
                    _dbSet.Remove(deleted);
                }
                return deleted;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T?> Get(Expression<Func<T, bool>> predicate)
        {
            try
            {
                var item = await _dbSet.FirstOrDefaultAsync(predicate);
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var itens = await _dbSet.AsNoTracking().ToListAsync();

            return itens ?? new List<T>();
        }

        public T? Update(T entity)
        {
            if (entity != null)
            {
                try
                {
                    _dbSet.Update(entity);
                    return entity;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return null;
        }

        public async Task<IEnumerable<T>?> Listar(Expression<Func<T, bool>> predicate)
        {
            try
            {
                var itens = await _dbSet.Where(predicate).AsNoTracking().ToListAsync();
                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
