using System.Linq.Expressions;

namespace AplicationTpDB.Interface
{
    public interface IBaseRepository<T>
    {
        public void Add(T entity);
        Task<IEnumerable<T>> GetAll(); //Pega todos
        Task<T?> Get(Expression<Func<T, bool>> predicate); //Pega somente um
        Task AddAsync(T entity);
        T? Update(T entity);
        Task<T?> DeleteAsync(Expression<Func<T, bool>> predicate);
        public Task<IEnumerable<T>?> Listar(Expression<Func<T, bool>> predicate); //Lista com filtro
        void SaveChanges();
    }
}
