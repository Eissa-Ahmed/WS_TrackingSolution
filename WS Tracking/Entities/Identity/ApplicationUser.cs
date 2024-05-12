namespace WS_Tracking.Entities.Identity;

[CollectionName("Users")]
public class ApplicationUser : MongoIdentityUser
{
    public ApplicationUser()
    {
        UserEmails = new();
        UserPhones = new();
        CodeUser = new();
        RefreshToken = new();
        VehicleGroups = new();
    }
    [BsonElement("FirstName")]
    [BsonRepresentation(BsonType.String)]
    [DisallowNull]
    public string FirstName { get; set; } = null!;

    [BsonElement("LastName")]
    [BsonRepresentation(BsonType.String)]
    [DisallowNull]
    public string LastName { get; set; } = null!;

    [BsonElement("CreationBy")]
    [BsonRepresentation(BsonType.String)]
    [DisallowNull]
    public string CreationBy { get; set; } = null!;

    [BsonElement("CreationDate")]
    [BsonRepresentation(BsonType.DateTime)]
    [DisallowNull]
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;

    [BsonElement("IsActive")]
    [BsonRepresentation(BsonType.Boolean)]
    [DisallowNull]
    public bool IsActive { get; set; } = true;

    [BsonElement("IsDeleted")]
    [BsonRepresentation(BsonType.Boolean)]
    [DisallowNull]
    public bool IsDeleted { get; set; } = false;

    [BsonElement("AlreadyLogin")]
    [BsonRepresentation(BsonType.Boolean)]
    [DisallowNull]
    public bool AlreadyLogin { get; set; } = false;

    [BsonElement("CustomerId")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? CustomerId { get; set; } = null;

    #region Profile

    [BsonElement("ImageName")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? ImageName { get; set; } = null;
    [BsonElement("TimeZone")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? TimeZone { get; set; } = null;
    [BsonElement("Name")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? Name { get; set; } = null;
    [BsonElement("Company")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? Company { get; set; } = null;
    [BsonElement("CompanyAr")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? CompanyAr { get; set; } = null;
    [BsonElement("CommercialNumber")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? CommercialNumber { get; set; } = null;
    [BsonElement("TaxNumber")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? TaxNumber { get; set; } = null;
    [BsonElement("Country")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? Country { get; set; } = null;
    [BsonElement("City")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? City { get; set; } = null;
    [BsonElement("PostalCode")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? PostalCode { get; set; } = null;
    [BsonElement("Address")]
    [BsonRepresentation(BsonType.String)]
    [BsonIgnoreIfNull]
    public string? Address { get; set; } = null;

    #endregion

    [BsonElement("UserEmails")]
    public List<UserEmails> UserEmails { get; set; }

    [BsonElement("UserPhones")]
    public List<UserPhones> UserPhones { get; set; }

    [BsonElement("CodeUser")]
    public List<CodeUser> CodeUser { get; set; }

    [BsonElement("RefreshToken")]
    public List<RefreshToken> RefreshToken { get; set; }
    [BsonElement("VehicleGroups")]
    [BsonIgnoreIfNull]
    public List<string>? VehicleGroups { get; set; }

}

public class UserEmails
{
    [BsonElement("Email")]
    [BsonRepresentation(BsonType.String)]
    public string Email { get; set; } = string.Empty;
}
public class UserPhones
{
    [BsonElement("Phone")]
    [BsonRepresentation(BsonType.String)]
    public string Phone { get; set; } = string.Empty;
}

public class CodeUser
{
    public string Code { get; set; } = string.Empty;
    public bool IsUsed { get; set; } = false;
    public DateTime ExpireCode { get; set; } = DateTime.UtcNow.AddMinutes(10);
    public bool IsActive => Code is not null && DateTime.UtcNow < ExpireCode && !IsUsed;

}
public class RefreshToken
{
    public string Token { get; set; } = String.Empty;
    public DateTime ExpireOn { get; set; } = DateTime.UtcNow.AddDays(1);
    public bool IsExpire => DateTime.UtcNow > ExpireOn;
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime? RevokedOn { get; set; }
    public bool IsActive => !IsExpire && RevokedOn == null;
}
