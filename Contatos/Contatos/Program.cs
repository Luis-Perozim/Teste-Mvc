using Contatos.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration["ConexaoSqlite:SqliteConnectionString"];
builder.Services.AddDbContext<ContatoContexto>(options =>
    options.UseSqlite(connection)
  );

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
// Add services to the container.
builder.Services.AddRazorPages();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "default",
        template: "{controller=Contatos}/{action=Index}/{id?}"
    );
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
