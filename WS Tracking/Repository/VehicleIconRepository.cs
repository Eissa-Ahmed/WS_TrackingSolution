namespace WS_Tracking.Repository;

public class VehicleIconRepository : BaseRepository<VehicleIconEntity>, IVehicleIconRepository
{
    public VehicleIconRepository(ApplicationDbContext context) : base(context.VehicleIcons)
    {

    }
}
