using StarGame.API.Endpoints;
using StarGame.Application.Interfaces;
using StarGame.Application.Services;
using StarGame.Infrastructure.Providers;


var webApplicationBuilder = WebApplication.CreateBuilder(args);

webApplicationBuilder.Services.AddEndpointsApiExplorer();
webApplicationBuilder.Services.AddSwaggerGen();
webApplicationBuilder.Services.AddHttpClient<IRawgApiProvider, RawgApiProvider>();
webApplicationBuilder.Services.AddScoped<IGameService, GameService>(); 

var webApplication = webApplicationBuilder.Build();

if (webApplication.Environment.IsDevelopment())
{
    webApplication.UseSwagger();
    webApplication.UseSwaggerUI();
}

webApplication.MapGameEndpoints();
webApplication.Run();