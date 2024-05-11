
var builder = Host.CreateApplicationBuilder(args);

builder.Services.ApplyServices(builder);

var host = builder.Build();
host.Run();
