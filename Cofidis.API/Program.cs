using Cofidis.Domain.ViewModels;
using Cofidis.Domain.Business;
using Cofidis.Domain.Interfaces.Business;
using Cofidis.Domain.Services;
using Cofidis.Domain.Interfaces.Services;
using Cofidis.Domain.Interfaces.Infrasctructure;
using Cofidis.Infrastructure;
using Cofidis.Domain.Interfaces.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IDbEnv, DbEnv>();
builder.Services.AddTransient<IDigitalMobileKey, DigitalMobileKey>();
builder.Services.AddTransient<IRiskAnalysis, RiskAnalysis>();
builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddTransient<ILoginInfra, LoginInfra>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => Results.Ok(new MessageVM { Message = "Hello! Cofidis API Here!" }));
app.MapGet("/login/{nif}", (ILoginService loginService, string nif) =>
                {
                    var result = loginService.Login(nif);
                    return Results.Ok(new AuthenticationVM { XAuthToken = result });
                });
app.MapGet("/creditAnalysis/{unemploymentRate}/{inflation}",
           (HttpContext context,
           float unemploymentRate,
           float inflation,
           IRiskAnalysis riskAnalysis) =>
                {
                    var token = context.Request.Headers["X-Auth-Token"].ToString();
                    try
                    {
                        var result = riskAnalysis.GetOpinionForCredit(unemploymentRate, inflation, token);
                        return Results.Ok(new ResultVM { Result = (result ? "True" : "False") });
                    }
                    catch (KeyNotFoundException) 
                    {
                        return Results.Unauthorized();
                    }
                });

app.Run();