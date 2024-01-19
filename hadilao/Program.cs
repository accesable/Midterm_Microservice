using E_Commerces.Models;
using Microsoft.EntityFrameworkCore;
using hadilao;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllersWithViews();
// Load the Conntection String
String ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new Exception("Connection String Not Founded");
builder.Services.AddDbContext<ApplicationDbContext>(
    options=>options.UseMySQL(ConnectionString)
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();
