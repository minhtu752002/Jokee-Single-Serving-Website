using JokeBackEnd.Data;
using JokeBackEnd.Service;
using JokeBackEnd.Service.Jokes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<JokesDbContext>(option =>
{
	option.UseSqlServer(builder.Configuration.GetConnectionString("JokesDatabase"));
});
builder.Services.AddTransient<IJokesService, JokesService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

//Show UseCor with CorsPolicyBuilder
app.UseCors(builder =>
{
	builder
	.AllowAnyOrigin()
	.AllowAnyMethod()
	.AllowAnyHeader();
}); 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
