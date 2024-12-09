using EmreProje.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Connection string'i al ve DbContext'i DI konteynerine ekle.
var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Identity Servislerini Ekle
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

// Cookie ayarlarý
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Login"; // Login sayfasý
    options.LogoutPath = "/Login/Logout"; // Logout sayfasý
    options.AccessDeniedPath = "/Login/AccessDenied"; // Yetkisiz eriþim
});

// Add services to the container.
builder.Services.AddControllersWithViews();

// Build the application.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // HSTS (HTTP Strict Transport Security) etkinleþtir
}

// Middleware sýralamasý
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); // Kimlik doðrulama middleware'i
app.UseAuthorization();

// Default route'u ayarla
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

// Uygulamayý çalýþtýr
app.Run();
