namespace WS_Tracking.BaseRepository;

public interface IBaseRepository<T> where T : class
{
    public Task<T> GetAsync(Expression<Func<T, bool>> filter, IClientSessionHandle? session = null);
    public Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, IClientSessionHandle? session = null);
    public Task<T> CreateAsync(T entity, IClientSessionHandle? session = null);
    public Task<T> UpdateAsync(Expression<Func<T, bool>> filter, T entity, IClientSessionHandle? session = null);
    public Task DeleteAsync(Expression<Func<T, bool>> filter, IClientSessionHandle? session = null);
}
