using StarGame.API.Endpoints;
using StarGame.Application.DependencyInjection;
using StarGame.Application.Interfaces;
using StarGame.Infrastructure.DependencyInjection;
using StarGame.Infrastructure.Providers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IRawgApiProvider, RawgApiProvider>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGameEndpoints();

app.Run();