using BarberConnect.Service;
using BarberConnect.Service.IService;
using BarberConnect.Utility;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient();
builder.Services.AddHttpClient<IBarberCouponService, BarberCouponService>();   
// Authentication Service Will Come here

SD.BarberCouponAPIBase = builder.Configuration["ServiceUrls:BarberCouponAPI"];
// Authentication base will come here

// Token service will come here

builder.Services.AddScoped<IBaseService, BaseService>();
builder.Services.AddScoped<IBarberCouponService, BarberCouponService>();
// Authentication service will come here

// Cookie builder service will come here

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Authentication will come here
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
