using FinanSmart.Dados;
using FinanSmart.Dados.Repositorios;
using FinanSmart.Dominio.Interface.Repository;
using FinanSmart.Dominio.Interface.Serviços;
using FinanSmart.Servicos.Serviços;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Contexto>();

builder.Services.AddScoped<ICategoriaServico, CategoriaServico>();
builder.Services.AddScoped<IcategoriaRepository, CategoriaRepository>();

builder.Services.AddScoped<IGastoRepository, GastosRepository>();

builder.Services.AddScoped<ICadastroRepository, CadastroRepository>();
builder.Services.AddScoped<ICadastroService, CadastroServico>();
builder.Services.AddScoped<ILoginService, LoginService>();

builder.Services.AddSession();


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

app.UseSession();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
