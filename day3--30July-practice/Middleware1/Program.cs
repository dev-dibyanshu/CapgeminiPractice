var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("This message is coming from a middleware");
    await next();
});
// app.MapGet("/", () => "Hello World!");
app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Hello World!");
});

app.Run();


// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.Use(async (context, next) =>
// {
//     await context.Response.WriteAsync("This message is coming from the Use middleware.<br>");

//     await next();
//     await context.Response.WriteAsync("<br>Returned back to the Use middleware.");
// });

// app.MapGet("/", async context =>
// {
//     await context.Response.WriteAsync("Hello World!");
// });

// app.Run();