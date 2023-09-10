using interface_sugarcane_to_SAP.ConnextDB;
using interface_sugarcane_to_SAP.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Register ContextDB;

//builder.Services.AddDbContext<ContextDB>(options =>
//{

//    options.UseNpgsql(builder.Configuration.GetConnectionString("sugarcanedb"));

//});



//builder.Services.AddEntityFrameworkNpgsql()
//    .AddDbContext<ContextDB>(options =>
//    options.UseNpgsql("Server=10.4.89.188;Port=5432;User Id=postgres;Password=Crist@ll@prog!@#;"));




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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
