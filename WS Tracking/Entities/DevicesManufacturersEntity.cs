namespace WS_Tracking.Entities;

public class DevicesManufacturersEntity
{
    public DevicesManufacturersEntity()
    {
        ListOfModels = new();
        ListOfProtocol = new();
        upsertDate = DateTime.UtcNow;
    }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public DateTime upsertDate { get; set; }
    public string UpdsertBy { get; set; } = null!;
    public bool InActive { get; set; } = false;
    public int CurdOperation { get; set; }
    public string Manufacturer { get; set; } = null!;
    public List<DevicesModelsEntity> ListOfModels { get; set; }
    public List<DeviceProtocolEntity> ListOfProtocol { get; set; }


}


