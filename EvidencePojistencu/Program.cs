using EvidencePojistencu.Data;
using EvidencePojistencu.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EvidenceContext>(options =>
    options.UseSqlite("Data Source=evidence.db"));
builder.Services.AddScoped<DatabazeService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pojistenci}/{action=Index}/{id?}");

app.Run();
