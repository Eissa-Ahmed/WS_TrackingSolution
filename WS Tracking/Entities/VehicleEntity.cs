namespace WS_Tracking.Entities;

public class VehicleEntity
{
    public VehicleEntity()
    {
        WaslOutput = new HashSet<WaslOutputVehicles>();
        upsertDate = DateTime.UtcNow;
        InActive = true;
        //Accepted = true;
        //IsAdded = true;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public DateTime upsertDate { get; set; }
    public string UpdsertBy { get; set; } = null!;
    //public bool Accepted { get; set; }
    //public bool IsAdded { get; set; }
    //public bool RequestAddInWasl { get; set; }
    public bool InActive { get; set; }
    public int? CurdOperation { get; set; }
    [BsonIgnoreIfNull]
    public string? waslId { get; set; } = null;
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

    #region Profile
    public string CustomerId { get; set; } = null!;

    //سيتم ربطه بالجرار
    [BsonIgnoreIfNull]
    public string? TrailerId { get; set; } = null;

    //سيتم ربطه بالسائقين
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
    public string ChaisisNumber { get; set; } = null!;

    #region Vehicle Plate
    [BsonIgnoreIfNull]
    public vehiclePlate? vehiclePlate { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? VehicleModel { get; set; } = null;
    public int plateType { get; set; }
    [BsonIgnoreIfNull]
    public string? imeiNumber { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? activity { get; set; } = null;
    #endregion
    [BsonIgnoreIfNull]
    public string? ManufacturingYear { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? SeatsNumber { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? FuelType { get; set; } = null;
    public string Icon { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? sequenceNumber { get; set; } = null;
    #endregion

    // Rate (iters per 100 km)
    #region Fuel Consumption 
    [BsonIgnoreIfNull]
    public int? FuelConsumption_SummerRate { get; set; }
    [BsonIgnoreIfNull]
    public int? FuelConsumption_WinterRate { get; set; }

    #endregion


    #region Accuracy
    [BsonIgnoreIfNull]
    public string? MovementDetection { get; set; } = null; // GPS + ACC OR GPS
    [BsonIgnoreIfNull]
    public int? MinSpeed { get; set; } // KM/h
    [BsonIgnoreIfNull]
    public int? MinStop { get; set; } //second
    [BsonIgnoreIfNull]
    public int? MinPark { get; set; }//Second
    [BsonIgnoreIfNull]
    public int? MinSat { get; set; }
    [BsonIgnoreIfNull]
    public int? MaxDistanceMSG { get; set; }
    [BsonIgnoreIfNull]
    public int? MinTripTime { get; set; } //Second
    [BsonIgnoreIfNull]
    public int? MinTripDistance { get; set; }  // meter
    #endregion

    [BsonIgnoreIfNull]
    public UnitInVehicleEntity? unitInVehicle { get; set; } = null;
    [BsonIgnoreIfNull]
    public IEnumerable<WaslOutputVehicles> WaslOutput { get; set; }



}
public class vehiclePlate
{
    public string number { get; set; } = null!;
    public string rightLetter { get; set; } = null!;
    public string middleLetter { get; set; } = null!;
    public string leftLetter { get; set; } = null!;
}

public class UnitInVehicleEntity
{
    public UnitInVehicleEntity()
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


    public List<SensorEntity> Sensors { get; set; }
}

#region Wasl Output

public class WaslOutputVehicles
{
    public WaslOutputVehicles()
    {
        result = new();
    }
    public string? resultCode { get; set; } = null;
    public ResultWaslVehicles result { get; set; }
    public bool success { get; set; } = false;
}
public class ResultWaslVehicles
{
    public ResultWaslVehicles()
    {
        vehicleInfo = new();
    }
    public bool isValid { get; set; }
    [BsonIgnoreIfNull]
    public string? rejectionReason { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? referenceKey { get; set; } = null;
    [BsonIgnoreIfNull]
    public vehicleInfo vehicleInfo { get; set; }
}
public class vehicleInfo
{
    [BsonIgnoreIfNull]
    public string? licenseExpiryDateHijri { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? brandArabic { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? manufacturerArabic { get; set; } = null;
    [BsonIgnoreIfNull]
    public int modelYear { get; set; }
    [BsonIgnoreIfNull]
    public string? colorArabic { get; set; } = null;
}
#endregion


