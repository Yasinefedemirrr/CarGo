using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using CarGo.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// PostgreSQL ba�lant�s�n� ekleyin (appsettings.json'dan alarak)
builder.Services.AddDbContext<CarGoContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection")));

// Add services to the container.
builder.Services.AddControllers();
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
