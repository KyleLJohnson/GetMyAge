using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/myage", () =>
{
    Random rnd = new Random();

    return rnd.Next(101);
});

app.Run();