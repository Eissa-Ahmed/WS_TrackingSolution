namespace WS_Tracking.Entities;

public class SensorEntity
{
    public SensorEntity()
    {
        Calibration = new();
        IntervalsColors = new();
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string SensorId { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? IMEI { get; set; } = null;
    public string SensorName { get; set; } = null!;
    public string EventType { get; set; } = null!;
    public string EventCode { get; set; } = null!;
    [BsonIgnoreIfNull]
    public bool? Showintooltip { get; set; }
    [BsonIgnoreIfNull]
    public bool? ShowlastChangetime { get; set; }
    [BsonIgnoreIfNull]
    public bool? FixedSensor { get; set; }
    [BsonIgnoreIfNull]
    public string? ResultType { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? IfSensor_0 { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? IfSensor_1 { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? UnitsOfMeasurement { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? FormulaOp { get; set; } = null;
    [BsonIgnoreIfNull]
    public decimal? FormulaValue { get; set; }
    [BsonIgnoreIfNull]
    public decimal? LowestValue { get; set; }
    [BsonIgnoreIfNull]
    public decimal? HighestValue { get; set; }
    public List<Calibration> Calibration { get; set; }
    public List<IntervalsColors> IntervalsColors { get; set; }
}

public class Calibration
{
    public int ItemOrder { get; set; }
    public decimal X { get; set; }
    public decimal Y { get; set; }
}

public class IntervalsColors
{
    public decimal IntervalStart { get; set; }

    public decimal IntervalEnd { get; set; }
    public string Color { get; set; } = string.Empty;
}
