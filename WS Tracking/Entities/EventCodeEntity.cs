namespace WS_Tracking.Entities;

public class EventCodeEntity
{
    [BsonElement("Id")]
    [BsonRepresentation(BsonType.Int32)]
    public int Id { get; set; }
    public string EventCodeName { get; set; } = null!;
}
