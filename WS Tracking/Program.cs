
using Microsoft.AspNetCore.Builder;
using WS_Tracking.Hubs;

//var builder = Host.CreateApplicationBuilder(args);
var builder = WebApplication.CreateBuilder(args);

builder.Services.ApplyServices(builder);


var host = builder.Build();

//map Hub
host.MapHub<OperationCompanyHub>("/OperationCompany");
host.MapHub<UsersHub>("/Users");
host.MapHub<RoleHub>("/Users");
host.Run();
