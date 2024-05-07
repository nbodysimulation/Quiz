using System.Reflection;
using Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

//ApplicationDbContext db = new ApplicationDbContext();

//app.MapGet("/", () => "Hello World!");
app.MapGet("/", () => Results.Redirect("/swagger/index.html"));

app.Run();
