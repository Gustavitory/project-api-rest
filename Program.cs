using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_rest.Middlewares;
using services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//añadimos los controllers 
builder.Services.AddControllers();

//Forma uno de inyectar dependencia(recomendada):
builder.Services.AddScoped<IHelloWorldService, HelloWorldService>();

//forma dos de inyectar dependencia (permite pasar parametros a la clase):
//builder.Services.AddScoped<IHelloWorldService>(p => new HelloWorldService());

// CONECTAMOS LA BASE DE DATOS:
//extraemos la configuracion
var connectionString = builder.Configuration.GetConnectionString("PostgreConnection");
//realizamos la coneccion:
builder.Services.AddDbContext<PostgreContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// app.UseWelcomePage();
app.useTimeMiddleware();

app.MapControllers();

app.Run();