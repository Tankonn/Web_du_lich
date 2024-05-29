using do_an_co_so.DataAccess;
using do_an_co_so.Repositories;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IblogRepository, EFblogRepository>();
builder.Services.AddScoped<IdattourRepository, EFdattourRepository>();
builder.Services.AddScoped<IkhachsanRepository, EFkhachsanRepository>();
builder.Services.AddScoped<IphuongthucthanhtoanRepository, EFphuongthucthanhtoanRepository>();
builder.Services.AddScoped<ItourRepository, EFtourRepository>();
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
