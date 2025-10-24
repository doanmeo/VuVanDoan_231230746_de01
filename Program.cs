using Microsoft.EntityFrameworkCore;
using VuVanDoan_231230746_de01.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. L?y chu?i k?t n?i
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. ??ng ký DbContext v?i SQL Server
builder.Services.AddDbContext<VvdComputerContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=vvdHome}/{action=VvdIndex}/{id?}");

app.Run();
