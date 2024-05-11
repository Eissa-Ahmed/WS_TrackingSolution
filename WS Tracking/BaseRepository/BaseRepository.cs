namespace WS_Tracking.BaseRepository;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly IMongoCollection<T> _collection;
    public BaseRepository(IMongoCollection<T> collection)
    {
        _collection = collection;
    }
    public async Task<T> CreateAsync(T entity, IClientSessionHandle? session = null)
    {
        if (session is null)
            await _collection.InsertOneAsync(entity);

        if (session is not null)
            await _collection.InsertOneAsync(session, entity);
        return entity;
    }

    public async Task DeleteAsync(Expression<Func<T, bool>> filter, IClientSessionHandle? session = null)
    {
        if (session is null)
            await _collection.DeleteOneAsync(filter);

        if (session is not null)
            await _collection.DeleteOneAsync(session, filter);
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, IClientSessionHandle? session = null)
    {
        List<T> result = new();
        if (session is not null)
        {
            if (filter is not null)
                result = await _collection.Find(session, filter).ToListAsync();

            if (filter is null)
                result = await _collection.Find(session, _ => true).ToListAsync();
        }
        if (session is null)
        {
            if (filter is not null)
                result = await _collection.Find(filter).ToListAsync();

            if (filter is null)
                result = await _collection.Find(_ => true).ToListAsync();
        }

        return result;
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> filter, IClientSessionHandle? session = null)
    {
        if (session is not null)
        {
            var result = await _collection.Find(session, filter).FirstOrDefaultAsync();
            return result;
        }
        else
        {
            var result = await _collection.Find(filter).FirstOrDefaultAsync();
            return result;
        }
    }

    public async Task<T> UpdateAsync(Expression<Func<T, bool>> filter, T entity, IClientSessionHandle? session = null)
    {

        if (session is not null)
        {
            await _collection.ReplaceOneAsync(session, filter, entity);
            return entity;
        }
        else
        {
            await _collection.ReplaceOneAsync(filter, entity);
            return entity;
        }
    }
}
