namespace WS_Tracking.Repository;

public class VehiclesModificationsRepository : BaseRepository<VehiclesModifications>, IVehiclesModificationsRepository
{
    public VehiclesModificationsRepository(ApplicationDbContext context) : base(context.VehiclesModifications)
    {

    }
}
