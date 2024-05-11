namespace WS_Tracking.Repository;

public sealed class VehicleGroupRepository : BaseRepository<VehicleGroupEntity>, IVehicleGroupRepository
{
    public VehicleGroupRepository(ApplicationDbContext context) : base(context.VehicleGroup)
    {
    }
}
