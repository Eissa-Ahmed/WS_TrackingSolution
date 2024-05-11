namespace WS1.Context;

public class ApplicationDbContext
{
    private readonly IMongoDatabase _database;
    private readonly IMongoDatabase _databaseEGLTRK;
    public ApplicationDbContext(MongoDbSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        _database = client.GetDatabase(settings.DatabaseName);
        _databaseEGLTRK = client.GetDatabase(settings.DatabaseNameEGLTRK);
    }
    public IMongoDatabase Database => _database;
    public IMongoCollection<OperationCompanyEntity> OperationCompany => _database.GetCollection<OperationCompanyEntity>("OperationCompany");
    public IMongoCollection<DriverEntity> Drivers => _database.GetCollection<DriverEntity>("Drivers");
    public IMongoCollection<SensorEntity> Sensors => _database.GetCollection<SensorEntity>("Sensors");
    public IMongoCollection<VehicleEntity> Vehicles => _database.GetCollection<VehicleEntity>("Vehicles");
    public IMongoCollection<UnitEntity> Units => _database.GetCollection<UnitEntity>("Units");
    public IMongoCollection<EventTypesInfoEntity> EventTypesInfo => _databaseEGLTRK.GetCollection<EventTypesInfoEntity>("EventTypesInfo");
    public IMongoCollection<DevicesManufacturersEntity> DevicesManufacturers => _databaseEGLTRK.GetCollection<DevicesManufacturersEntity>("DevicesManufacturers");
    public IMongoCollection<VehicleIconEntity> VehicleIcons => _database.GetCollection<VehicleIconEntity>("VehicleIcons");
    public IMongoCollection<VehicleGroupEntity> VehicleGroup => _database.GetCollection<VehicleGroupEntity>("VehicleGroup");
    public IMongoCollection<VehiclesModifications> VehiclesModifications => _database.GetCollection<VehiclesModifications>("VehiclesModifications");
}
