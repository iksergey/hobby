var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoint =>
  endpoint.MapControllerRoute(
    name: "Default",
    pattern: "api/{controller}/{action}/{arg?}"
  )
);

app.Run();