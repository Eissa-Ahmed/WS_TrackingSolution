namespace WS_Tracking.Repository;

public class VehicleRepository : BaseRepository<VehicleEntity>, IVehicleRepository
{
    public VehicleRepository(ApplicationDbContext context) : base(context.Vehicles)
    {

    }
}
