namespace WS_Tracking.Entities;

public class DeviceProtocolEntity
{
    [BsonElement("Id")]
    [BsonRepresentation(BsonType.String)]
    public string Id { get; set; } = null!;

    public string DeviceProtocolName { get; set; } = null!;
}
