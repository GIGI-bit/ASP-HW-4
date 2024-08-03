using Microsoft.EntityFrameworkCore;
using WebApplication_4.Data;
using WebApplication_4.Repositories;
using WebApplication_4.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ProductDbContext>(opt =>
{
    opt.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();



/////////////////////////////////////////
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
