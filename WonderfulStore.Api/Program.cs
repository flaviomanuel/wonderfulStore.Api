using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using WonderfulStore.Api.Configurations;
using WonderfulStore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
            .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                });

builder.Services.AddHandlers();
builder.Services.AddDependencyInjections();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var CONNECTION_STRING = builder.Configuration.GetConnectionString("WonderfulStoreDatabase");

builder.Services
    .AddDbContext<AppDbContext>(options => options.UseSqlServer(CONNECTION_STRING));


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
