using Microsoft.EntityFrameworkCore;
using PieShop.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();


// This method is an extension method provided by the Microsoft.Extensions.DependencyInjection namespace in ASP.NET Core.
// It adds the services required for controllers and views to the service collection.
// In other words, it sets up the necessary dependencies for handling MVC (Model-View-Controller) patterns in your application
// The AddControllersWithViews method configures services like model binding, action filters, and other components
// needed for handling HTTP requests and rendering views
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PieShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// This method is an extension method provided by the Microsoft.AspNetCore.Builder namespace. 
// It adds a middleware to the request pipeline that enables the serving of static files such as images, CSS files, JavaScript files,
// and other content that doesn't require server-side processing
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    //This method is an extension method provided by the Microsoft.AspNetCore.Builder namespace.
    //When added to the middleware pipeline, it intercepts unhandled exceptions that occur during the processing of an HTTP request
    //and displays a developer-friendly exception page with detailed information about the exception
    app.UseDeveloperExceptionPage();
}

// This method is an extension method provided by the Microsoft.AspNetCore.Builder namespace.
// It configures a default route for MVC, which is a convention-based approach to routing in ASP.NET Core
app.MapDefaultControllerRoute();

app.Run();