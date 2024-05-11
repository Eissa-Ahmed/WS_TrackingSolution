namespace WS_Tracking.Repository;

public class EventTypesInfoRepository : BaseRepository<EventTypesInfoEntity>, IEventTypesInfoRepository
{
    public EventTypesInfoRepository(ApplicationDbContext dbContext) : base(dbContext.EventTypesInfo)
    {

    }
}
