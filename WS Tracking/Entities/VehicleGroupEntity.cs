namespace WS_Tracking.Entities;

public sealed class VehicleGroupEntity
{
    public VehicleGroupEntity()
    {
        Vehicles = new HashSet<VehicleGroupEntityVehiclesId>();
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public string GroupName { get; set; } = null!;
    public string OperationCompanyId { get; set; } = null!;
    public string CreatedById { get; set; } = null!;
    public string CreatedByEmail { get; set; } = null!;
    public ICollection<VehicleGroupEntityVehiclesId> Vehicles { get; set; }
}
public sealed class VehicleGroupEntityVehiclesId
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;

}
