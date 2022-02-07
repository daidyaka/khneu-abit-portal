using Microsoft.EntityFrameworkCore;
using Enrollee.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// получаем строку подключения из файла конфигурации
string connection = "Server=localhost;Database=enrolleeDB;Trusted_Connection=True;";
// добавляем контекст MobileContext в качестве сервиса в приложение
builder.Services.AddDbContext<EnrolleContext>(options =>
    options.UseSqlServer(connection));
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
