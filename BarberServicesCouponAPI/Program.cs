using AutoMapper;
using BarberServicesCouponAPI;
using BarberServicesCouponAPI.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDBContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultSQliteConnection"));
});

// To be implemented later
// IMapper mapper = MappingConfig.RegisterMaps().CreateMapper(); 




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Authorisation token box to come later


builder.Services.AddSwaggerGen();
// Authentication settings will come here later 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// Authentication to come later.


app.UseAuthorization();

app.MapControllers();

app.Run();
