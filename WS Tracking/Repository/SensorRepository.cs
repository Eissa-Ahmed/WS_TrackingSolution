namespace WS_Tracking.Repository;

public class SensorRepository : BaseRepository<SensorEntity>, ISensorRepository
{
    public SensorRepository(ApplicationDbContext context) : base(context.Sensors)
    {

    }
}
