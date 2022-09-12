var builder = WebApplication.CreateBuilder(args);

var configer = builder.Configuration["WelcomeMessage"];

var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Midlweer 1 dan salom");
    await next();
});
app.MapGet("/",async context=>
{
    await context.Response.WriteAsync("Hello world!!!!");
});

app.MapGet("/config", () => configer);


app.Run();
