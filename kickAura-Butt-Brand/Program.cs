var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // 👈 Add this line
app.UseStaticFiles();    // 👈 Add this line

app.Run();