using Application;
using DataAccess;
using DataAccess.Commons;
using Grpc.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
var config = builder.Configuration.Get<AppConfiguration>();
builder.Configuration.Bind(config);
builder.Services.AddSingleton(config!);
builder.Services.AddHttpClient();
builder.Services.AddGrpc();
builder.Services.AddAuthorization();
builder.Services.AddDaoDIs();
builder.Services.AddRepositoryDIs();

builder.Services.AddCors(opt => opt.AddDefaultPolicy(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
.WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding")));
// Add auto mapper
builder.Services.AddAutoMapper(typeof(Grpc.Mapper.AutoMapperProfiles).Assembly);
var app = builder.Build();
app.UseCors();
app.UseAuthorization();

app.UseGrpcWeb();
// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<NewsServiceImpl>().EnableGrpcWeb();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
app.Run();

