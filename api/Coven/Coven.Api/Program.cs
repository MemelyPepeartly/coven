using Microsoft.EntityFrameworkCore;
using Coven.Api.Hubs;
using Coven.Api.Services;
using Coven.Data.Entities;
using Coven.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();

// Database
builder.Services.AddDbContext<CovenContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("CovenDB")));
builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddScoped<IWorldAnvilService, WorldAnvilService>();

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
{
    builder.AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .WithOrigins("http://localhost:4200");
}));

builder.WebHost
    .UseKestrel()
    .UseContentRoot(Directory.GetCurrentDirectory())
    .UseIISIntegration()
    .UseStartup("Coven.Api")
    .UseIISIntegration();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");
app.MapControllers();
app.MapHub<ChatHub>("/ChatHub");

app.Run();
