var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

// app.Use(async (context, next) =>
// {
//     await context.Response.WriteAsync("This message is coming from a middleware");
//     await next();
// });

app.MapControllerRoute(
    name : "default",
    pattern : "{controller=Home}/{action=Index}/{id?}"
    );
app.Run();