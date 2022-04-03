using CoreEngine.Classes;
using CoreEngine.Interfaces;
using Serilog;
using SqlDatabaseManager.Classes;
using SqlDatabaseManager.Interfaces;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.File("Logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Services.AddControllers();

builder.Services.AddSingleton<ISettings, Settings>();
builder.Services.AddSingleton<ISqlDbManager, DapperSqlDbManager>();
builder.Services.AddSingleton<ICoreEngine, SearchEngine>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
