namespace WS_Tracking.Entities.Identity;

[CollectionName("Roles")]
public class ApplicationRole : MongoIdentityRole
{
    [BsonElement("CustomerId")]
    [BsonRepresentation(BsonType.String)]
    public string CustomerId { get; set; } = string.Empty;

    [BsonElement("IsActive")]
    [BsonRepresentation(BsonType.Boolean)]
    public bool IsActive { get; set; } = true;
}
