var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// 1. Registra los servicios que generan el documento OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();
Console.WriteLine($"ENTORNO ACTUAL: {app.Environment.EnvironmentName}");

// 2. Publica el endpoint que devuelve el documento JSON
if (app.Environment.IsDevelopment()){
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
