using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Final_Project.Data;
using Final_Project.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Final_ProjectDbContextConnection") ?? throw new InvalidOperationException("Connection string 'Final_ProjectDbContextConnection' not found.");

builder.Services.AddDbContext<Final_ProjectDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<Final_ProjectUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<Final_ProjectDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

//injecting the database context
builder.Services.AddDbContext<TableBookingDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Final_ProjectDbContextConnection"))
);


//added for the login
builder.Services.AddRazorPages();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Resturant}/{action=Index}/{id?}");


//for the razor pages
app.MapRazorPages();

app.Run();
