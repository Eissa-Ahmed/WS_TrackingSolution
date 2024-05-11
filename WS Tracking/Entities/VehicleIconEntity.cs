namespace WS_Tracking.Entities;

public class VehicleIconEntity
{
    public VehicleIconEntity()
    {
        upsertDate = DateTime.UtcNow;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public DateTime upsertDate { get; set; }
    public string UpdsertBy { get; set; } = null!;
    public string? CustomerId { get; set; } = null;
    public string Name { get; set; } = null!;
}
