namespace Core.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task Add(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        void Remove(T entity);
        Task<bool> Save();
        void Update(T entity);
    }
}