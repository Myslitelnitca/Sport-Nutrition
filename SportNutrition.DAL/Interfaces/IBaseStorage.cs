namespace SportNutrition.DAL.Interfaces;

public interface IBaseStorage<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task<T> GetByIdAsync(Guid id);
    Task<T> Update(T entity);
    IQueryable<T> GetAllAsync();
}