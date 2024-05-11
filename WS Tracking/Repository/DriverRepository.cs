namespace WS_Tracking.Repository;

public class DriverRepository : BaseRepository<DriverEntity>, IDriverRepository
{
    public DriverRepository(ApplicationDbContext context) : base(context.Drivers)
    {

    }
}
