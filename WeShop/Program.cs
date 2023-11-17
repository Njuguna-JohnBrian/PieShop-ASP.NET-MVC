var builder = WebApplication.CreateBuilder(args);

// This method is an extension method provided by the Microsoft.Extensions.DependencyInjection namespace in ASP.NET Core.
// It adds the services required for controllers and views to the service collection.
// In other words, it sets up the necessary dependencies for handling MVC (Model-View-Controller) patterns in your application
// The AddControllersWithViews method configures services like model binding, action filters, and other components
// needed for handling HTTP requests and rendering views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// This method is an extension method provided by the Microsoft.AspNetCore.Builder namespace. 
// It adds a middleware to the request pipeline that enables the serving of static files such as images, CSS files, JavaScript files,
// and other content that doesn't require server-side processing
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "Hello World!");

app.Run();
