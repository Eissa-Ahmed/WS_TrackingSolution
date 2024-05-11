namespace WS_Tracking.Entities;

public class OperationCompanyEntity
{
    public OperationCompanyEntity()
    {
        UpsertDate = DateTime.UtcNow;
        InActive = true;
        IsDeleted = false;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;
    public DateTime UpsertDate { get; set; }
    public string UpdsertBy { get; set; } = null!;
    public bool InActive { get; set; }
    public int CurdOperation { get; set; }
    [BsonIgnoreIfNull]
    public string? WaslId { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? activity { get; set; } = null;
    public string CustomerType { get; set; } = null!;// normal - dealer - Owner
    public string CompanyName { get; set; } = null!;
    public string CompanyType { get; set; } = null!; // company - individual
    [BsonIgnoreIfNull]
    public string? IdentityNumber { get; set; } = null;  // string(10)  Mandatory
    [BsonIgnoreIfNull]
    public string? CommercialRecordNumber { get; set; } = null;  // Mandatory
    [BsonIgnoreIfNull]
    public string? CommercialRecordIssueDateHijri { get; set; } // Mandatory
    [BsonIgnoreIfNull]
    public string? DateOfBirth { get; set; }
    [BsonIgnoreIfNull]
    public bool IsHigri { get; set; }
    [BsonIgnoreIfNull]
    public string? PhoneNumber { get; set; } = null; // Mandatory
    [BsonIgnoreIfNull]
    public string? ExtensionNumber { get; set; } = null; // Optional
    [BsonIgnoreIfNull]
    public string? EmailAddress { get; set; } = null; // Mandatory
    [BsonIgnoreIfNull]
    public string? ManagerName { get; set; } = null; // Mandatory if the entity being registered is a company.Manager name
    [BsonIgnoreIfNull]
    public string? ManagerPhoneNumber { get; set; } = null; // Mandatory if the entity being registered is a company.Manager Phone Number
    [BsonIgnoreIfNull]
    public string? ManagerMobileNumber { get; set; } = null; // Mandatory if the entity being registered is a company.Manager Mobile Number
    [BsonIgnoreIfNull]
    public string? Address { get; set; } = null;
    [BsonIgnoreIfNull]
    public int priority { get; set; }
    [BsonIgnoreIfNull]
    public string? Consuming { get; set; } = null; // fast , Normal
    [BsonIgnoreIfNull]
    public string? Comments { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? ContractNumber { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? CustomersContractNumber { get; set; } = null;
    [BsonIgnoreIfNull]
    public string? ContractEndDate { get; set; }
    public string AdminId { get; set; } = null!; // Basic Admin for this OperatingCompany
    public string UpLevelId { get; set; } = null!; // This OperatingCompany under Control from OperatingCompany 
    [BsonIgnoreIfNull]
    public string? XapiKey { get; set; } = null;
    public bool IsDeleted { get; set; }

    #region Wasl Output
    [BsonIgnoreIfNull]
    public WaslOutPutCompany? WaslOutPut { get; set; } = null;
    #endregion
}
public class WaslOutPutCompany
{
    public WaslOutPutCompany()
    {
        result = new();
    }
    public string resultCode { get; set; } = string.Empty;
    public ResultWaslCompany result { get; set; }

    public bool success { get; set; }
}
public class ResultWaslCompany
{
    public string referenceKey { get; set; } = string.Empty;
}
