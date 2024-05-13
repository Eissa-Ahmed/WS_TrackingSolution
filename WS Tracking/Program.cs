//var builder = Host.CreateApplicationBuilder(args);
var builder = WebApplication.CreateBuilder(args);

builder.Services.ApplyServices(builder);

var host = builder.Build();
//host.UseMiddleware<WebSocketMiddleware>();
/*host.MapHub<OperationCompanyHub>("/hubs/OperationCompany");
host.MapHub<UsersHub>("/hubs/Users");
host.MapHub<RoleHub>("/hubs/Role");*/

host.Run();


