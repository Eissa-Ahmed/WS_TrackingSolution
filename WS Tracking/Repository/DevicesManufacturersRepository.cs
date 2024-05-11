namespace WS_Tracking.Repository;

public class DevicesManufacturersRepository : BaseRepository<DevicesManufacturersEntity>, IDevicesManufacturersRepository
{
    public DevicesManufacturersRepository(ApplicationDbContext dbContext) : base(dbContext.DevicesManufacturers)
    {

    }
}
