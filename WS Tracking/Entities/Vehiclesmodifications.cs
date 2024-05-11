namespace WS_Tracking.Entities;

public class VehiclesModifications
{
    public VehiclesModifications()
    {
        UpdatedDate = DateTime.Now;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public DateTime UpdatedDate { get; set; }
    public string? VehicleId { get; set; } = null;
    public bool AddToWasl { get; set; }
    [BsonIgnoreIfNull]
    public string? Name { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? colorCode { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? OwnerID { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? OwnerName { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? Weight { get; set; } = null;
    [BsonIgnoreIfNull]
    public string CustomerId { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? TrailerId { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? DriverId { get; set; } = null;
    [BsonIgnoreIfNull]
    public bool? BusinessTypeWaste { get; set; }
    [BsonIgnoreIfNull]
    public bool? BusinessTypeTransportation { get; set; }
    [BsonIgnoreIfNull]
    public bool? BusinessTypeWater { get; set; }
    [BsonIgnoreIfNull]
    public bool? BusinessTypeHajj { get; set; }
    [BsonIgnoreIfNull]
    public string? VehicleType { get; set; } = null;
    [BsonIgnoreIfNull]
    public string ChaisisNumber { get; set; } = null!;
    [BsonIgnoreIfNull]
    public vehiclePlate? vehiclePlate { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? VehicleModel { get; set; } = null;
    [BsonIgnoreIfNull]
    public int plateType { get; set; }
    [BsonIgnoreIfNull]
    public string? imeiNumber { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? activity { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? ManufacturingYear { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? SeatsNumber { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? FuelType { get; set; } = null;
    [BsonIgnoreIfNull]
    public string Icon { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? sequenceNumber { get; set; } = null;
    [BsonIgnoreIfNull]
    public int? FuelConsumption_SummerRate { get; set; }
    [BsonIgnoreIfNull]
    public int? FuelConsumption_WinterRate { get; set; }
    [BsonIgnoreIfNull]
    public string? MovementDetection { get; set; } = null;
    [BsonIgnoreIfNull]
    public int? MinSpeed { get; set; }
    [BsonIgnoreIfNull]
    public int? MinStop { get; set; }
    [BsonIgnoreIfNull]
    public int? MinPark { get; set; }
    [BsonIgnoreIfNull]
    public int? MinSat { get; set; }
    [BsonIgnoreIfNull]
    public int? MaxDistanceMSG { get; set; }
    [BsonIgnoreIfNull]
    public int? MinTripTime { get; set; }
    [BsonIgnoreIfNull]
    public int? MinTripDistance { get; set; }
    [BsonIgnoreIfNull]
    public UnitInVehicleModificationEntity? unitInVehicle { get; set; } = null;
}
public class UnitInVehicleModificationEntity
{
    public UnitInVehicleModificationEntity()
    {
        Sensors = new();
    }
    public string Id { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? DeviceType { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? DeviceModel { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? DeviceProtocol { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? IMEI { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? DevicePassword { get; set; } = null;


    public List<SensorModificationsEntity> Sensors { get; set; }
}
public class SensorModificationsEntity
{
    public SensorModificationsEntity()
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
    public List<CalibrationModifications> Calibration { get; set; }
    public List<IntervalsColorsModifications> IntervalsColors { get; set; }
}

public class CalibrationModifications
{
    public int ItemOrder { get; set; }
    public decimal X { get; set; }
    public decimal Y { get; set; }
}

public class IntervalsColorsModifications
{
    public decimal IntervalStart { get; set; }

    public decimal IntervalEnd { get; set; }
    public string Color { get; set; } = string.Empty;
}