namespace WS_Tracking.Entities;

public class UnitEntity
{
    public UnitEntity()
    {
        upsertDate = DateTime.UtcNow;
        InActive = true;
        Sensors = new List<SensorEntity>();
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public DateTime upsertDate { get; set; }
    public string UpdsertBy { get; set; }
    public bool InActive { get; set; }
    public int CurdOperation { get; set; }
    public string IMEI { get; set; } = null!;
    public string CustomerId { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? VehicleId { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? DeviceType { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? ManufacturerName { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? DeviceModel { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? DeviceProtocol { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? SIMCardNumber { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? SIMCardSerial { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? OdometerType { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? OdometerValue { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? OperationCode { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? DevicePassword { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? DeviceSerial { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? EngineHoursType { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? EngineHoursValue { get; set; } = null;
    [BsonIgnoreIfNull]
    public List<SensorEntity> Sensors { get; set; } = null!;
}
