using Persistence;
using Application;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Core.Security;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddSecurityServices();

builder.Services.AddStackExchangeRedisCache(opt => opt.Configuration = "localhost:6379");


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();
