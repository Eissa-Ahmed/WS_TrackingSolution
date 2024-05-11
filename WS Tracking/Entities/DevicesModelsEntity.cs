namespace WS_Tracking.Entities;

public class DevicesModelsEntity
{
    public DevicesModelsEntity()
    {
        ProtocolsForModel = new();
        EventCodesForModel = new();
    }
    [BsonElement("Id")]
    [BsonRepresentation(BsonType.String)]
    public string Id { get; set; } = null!;
    public string DeviceModel { get; set; } = null!;
    public List<DeviceProtocolEntity> ProtocolsForModel { get; set; }
    public List<EventCodeEntity> EventCodesForModel { get; set; }
}
