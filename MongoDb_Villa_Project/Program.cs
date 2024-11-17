using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDb_Villa_Project.Extensions;
using System.Reflection;
using Villa.DataAccessLayer.Context;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.  
builder.Services.AddServiceExtensions(); 
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); 

var mongoDatabase = new MongoClient(builder.Configuration.GetConnectionString("MongoConnection")).GetDatabase(builder.Configuration.GetSection("DatabaseName").Value);

builder.Services.AddDbContext<VillaContext>(option =>
{
    option.UseMongoDB(mongoDatabase.Client, mongoDatabase.DatabaseNamespace.DatabaseName);
});
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();