using LogicaAccesoDatos;
using LogicaAccesoDatos.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();
//builder.Services.AddScoped<IRepositorioAtleta, RepositorioAtleta>();
//builder.Services.AddScoped<IRepositorioEvento, RepositorioEvento>();
string cadenaConexion = builder.Configuration.GetConnectionString("CadenaConexion");
builder.Services.AddDbContext<LibreriaContext>(options=>options.UseSqlServer(cadenaConexion));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
