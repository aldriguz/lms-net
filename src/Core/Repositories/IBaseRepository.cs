namespace Core.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Remove(T entity);
        Task Update(T entity);
        Task Save(T entity);
    }
}