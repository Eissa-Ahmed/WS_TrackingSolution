

namespace WS_Tracking;

public static class RegisterModule
{

    public static IServiceCollection ApplyServices(this IServiceCollection services, IHostApplicationBuilder builder)
    {
        ConfigurationBackgroundService(builder);
        ConfigurationDbContext(builder);
        ConfigurationWindowsService(builder);
        ConfigurationSerilog(builder);
        ConfigurationDI(builder);
        ConfigurationSignalR(builder);
        ConfigurationAuthentication(builder);

        return services;
    }

    private static void ConfigurationAuthentication(IHostApplicationBuilder builder)
    {
        var jwtSettings = new JWTSettings();
        builder.Configuration.GetSection(nameof(JWTSettings)).Bind(jwtSettings);
        builder.Services.AddSingleton(jwtSettings);

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = false;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings.Issuer,
                ValidAudience = jwtSettings.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key)),
                ClockSkew = TimeSpan.FromMinutes(5)
            };
        });
    }

    private static void ConfigurationSignalR(IHostApplicationBuilder builder)
    {
        builder.Services.AddSignalR();
    }

    private static void ConfigurationDI(IHostApplicationBuilder builder)
    {
        builder.Services.AddSingleton(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        builder.Services.AddTransient<IAuthenticationServices, AuthenticationServices>();
        builder.Services.AddTransient<IOperationCompanyRepository, OperationCompanyRepository>();
        builder.Services.AddTransient<IDriverRepository, DriverRepository>();
        builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();
        builder.Services.AddTransient<IUnitRepository, UnitRepository>();
        builder.Services.AddTransient<ISensorRepository, SensorRepository>();
        builder.Services.AddTransient<IDevicesManufacturersRepository, DevicesManufacturersRepository>();
        builder.Services.AddTransient<IEventTypesInfoRepository, EventTypesInfoRepository>();
        builder.Services.AddTransient<IVehicleIconRepository, VehicleIconRepository>();
        builder.Services.AddTransient<IVehicleGroupRepository, VehicleGroupRepository>();
        builder.Services.AddTransient<IVehiclesModificationsRepository, VehiclesModificationsRepository>();
        builder.Services.AddSingleton<OperationCompanyHelper>();
        builder.Services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
        builder.Services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
    }

    private static void ConfigurationWindowsService(IHostApplicationBuilder builder)
    {
        builder.Services.AddWindowsService(opt => opt.ServiceName = "ZLamar");
    }

    private static void ConfigurationSerilog(IHostApplicationBuilder builder)
    {
        builder.Logging.ClearProviders();
        builder.Services.AddSerilog(lc => lc
            .MinimumLevel.Debug()
            .Enrich.FromLogContext()
            .WriteTo.File(Path.Join(builder.Environment.ContentRootPath, "Logs/MyLogs.log")));
    }

    private static void ConfigurationBackgroundService(IHostApplicationBuilder builder)
    {
        builder.Services.AddHostedService<OperationCompanyService>();
    }

    private static void ConfigurationDbContext(IHostApplicationBuilder builder)
    {
        MongoDbSettings mongoDbSettings = new MongoDbSettings();
        builder.Configuration.GetSection(nameof(MongoDbSettings)).Bind(mongoDbSettings);
        builder.Services.AddSingleton(mongoDbSettings);
        ApplicationDbContext dbContext = new ApplicationDbContext(mongoDbSettings);
        builder.Services.AddSingleton(dbContext);
    }
}
