using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<DbContext, WeatherForecastContext>();
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

//using (var db = new WeatherForecastContext())
//{
//    foreach (var item in db.WeatherForecasts)
//    {
//        Console.WriteLine(item.Id);
//        Console.WriteLine(item.Date);
//        Console.WriteLine(item.TemperatureC);
//        Console.WriteLine(item.TemperatureF);
//        Console.WriteLine(item.Summary);
//    }
//}

app.Run();
