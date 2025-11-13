using EnviosApiRest.Repositories;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Inject Repo
builder.Services.AddScoped<IEnvioRepository,MemoryEnvioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Here
}

// Should only be in Development Environment
app.MapOpenApi();
app.MapScalarApiReference(); 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
