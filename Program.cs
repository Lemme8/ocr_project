using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using IronOcr;

var builder = WebApplication.CreateBuilder(args);

IronOcr.License.LicenseKey = "IRONSUITE.MOVESPEED999.GMAIL.COM.14709-5810B94A09-EWQOKP664JBOXW-N2VDTIVZQDWM-FFX3ZGWYSCC7-YUNQBUPU56DW-72M7P7HX6T2P-XPZYRDGAAIVZ-5IXK4S-TRFA74ICWCOOEA-DEPLOYMENT.TRIAL-XRGN2O.TRIAL.EXPIRES.01.DEC.2024";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
