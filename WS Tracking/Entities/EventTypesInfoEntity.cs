namespace WS_Tracking.Entities;

public class EventTypesInfoEntity
{

    public EventTypesInfoEntity()
    {
        ResultType = new();
        upsertDate = DateTime.UtcNow;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public DateTime upsertDate { get; set; }
    public string UpdsertBy { get; set; } = null!;
    public bool InActive { get; set; } = false;
    public int CurdOperation { get; set; }
    public string EventType { get; set; } = null!;
    public bool ShowInEventDDL { get; set; }
    public List<ResultInfo> ResultType { get; set; }
}

public class ResultInfo
{
    [BsonIgnoreIfNull]
    public string? ResultType { get; set; }
    public bool IfSensor_0 { get; set; }
    public bool IfSensor_1 { get; set; }
    public bool UnitsOfMeasurement { get; set; }
    public bool Formula { get; set; }
    public bool LowestValue { get; set; }
    public bool HighestValue { get; set; }
    public bool Calibration { get; set; }
    public bool IntervalsColors { get; set; }
    public bool IntervalsColorsType { get; set; }

}

