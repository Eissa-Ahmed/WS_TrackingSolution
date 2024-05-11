namespace WS_Tracking.Entities;

public class DriverEntity
{
    public DriverEntity()
    {
        upsertDate = DateTime.UtcNow;
        InActive = true;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public DateTime upsertDate { get; set; }
    public string UpdsertBy { get; set; } = null!;
    public bool InActive { get; set; }
    public int CurdOperation { get; set; }
    [BsonIgnoreIfNull]
    public string? nationalityArabic { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? licenseExpiryDateHijri { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? WaslId { get; set; } = null;

    #region Profile
    [BsonIgnoreIfNull]
    public string? LoginId { get; set; } = null;
    public string CustomerId { get; set; } = null!;
    public string DriverName { get; set; } = null!;
    public string DriverNameAR { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? Address { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? RFID { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? iButton { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? Description { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? Image { get; set; } = null;

    #endregion
    [BsonIgnoreIfNull]
    public string? dateOfBirthHijri { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? dateOfBirthGregorian { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? mobileNumber { get; set; } = null!;
    [BsonIgnoreIfNull]
    public string? activity { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? Status { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? identityNumber { get; set; } = null!;
    [BsonIgnoreIfNull]
    public WaslOutputDriver? WaslOutput { get; set; } = null;
}



public class WaslOutputDriver
{
    public WaslOutputDriver()
    {
        result = new();
    }
    public string resultCode { get; set; } = null!;
    public ResultWaslDriver result { get; set; }
    public bool success { get; set; }
}
public class ResultWaslDriver
{
    public ResultWaslDriver()
    {
        driverInfo = new();
    }
    public bool isValid { get; set; }
    public string referenceKey { get; set; } = null!;
    public DriverInfo driverInfo { get; set; }
}
public class DriverInfo
{
    public string nationalityArabic { get; set; } = null!;
    public string nameArabic { get; set; } = null!;
    public string licenseExpiryDateHijri { get; set; } = null!;
}
