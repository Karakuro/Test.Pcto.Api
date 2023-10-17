using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Test.Pcto.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

string connStr = builder.Configuration.GetConnectionString("Default");
builder.Services.AddSqlite<SchoolDbContext>(connStr);

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

using(var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetService<SchoolDbContext>();
    ctx.Database.Migrate();
    if(!ctx.Tutors.Any())
    {
        string json = File.ReadAllText("tutors.json");
        List<Tutor> tutors = JsonSerializer.Deserialize<List<Tutor>>(json);
        tutors.ForEach(t => t.TutorId = 0);
        ctx.Tutors.AddRange(tutors);
        ctx.SaveChanges();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
