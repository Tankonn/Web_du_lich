using do_an_co_so.DataAccess;
using do_an_co_so.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình DbContext với chuỗi kết nối từ cấu hình
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Cấu hình Identity với một lần đăng ký
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
.AddDefaultTokenProviders()
.AddDefaultUI()
.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

// Đăng ký các dịch vụ tùy chỉnh
builder.Services.AddScoped<IblogRepository, EFblogRepository>();
builder.Services.AddScoped<IdattourRepository, EFdattourRepository>();
builder.Services.AddScoped<IkhachsanRepository, EFkhachsanRepository>();
builder.Services.AddScoped<IphuongthucthanhtoanRepository, EFphuongthucthanhtoanRepository>();
builder.Services.AddScoped<ItourRepository, EFtourRepository>();

var app = builder.Build();

// Cấu hình pipeline xử lý HTTP request
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication(); // Thêm middleware xác thực
app.UseAuthorization(); // Thêm middleware phân quyền

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Tour}/{action=Index}/{id?}"
    );
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
