namespace WS_Tracking.Model;

public class MongoDbSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string DatabaseNameEGLTRK { get; set; } = null!;
    public string UserManagementDatabaseName { get; set; } = null!;
}