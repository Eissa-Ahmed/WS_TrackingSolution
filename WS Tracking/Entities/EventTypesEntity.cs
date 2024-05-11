namespace WS_Tracking.Entities;

internal class EventTypesEntity
{
    public EventTypesEntity()
    {
        upsertDate = DateTime.UtcNow;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public DateTime upsertDate { get; set; }
    public string UpdsertBy { get; set; } = null!;
    public string EventName { get; set; } = null!;
    public bool InActive { get; set; } = false;
    public int CurdOperation { get; set; }
}
