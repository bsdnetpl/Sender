using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sender.DB;
using Sender.DTO;
using Sender.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Ibox,Boxes>();
builder.Services.AddScoped<ICustomer, Customers>();
builder.Services.AddScoped<IConsignor, Consignors>();
builder.Services.AddScoped<IPos, Poses>();
builder.Services.AddScoped<IPasswordHasher<Pos>, PasswordHasher<Pos>>();
builder.Services.AddScoped<IPasswordHasher<Consignor>, PasswordHasher<Consignor>>();
builder.Services.AddScoped<IPasswordHasher<Customer>, PasswordHasher<Customer>>();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
builder.Services.AddDbContext<ConnectMssql>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CS")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
