using BooksStore.Data;
using BooksStore.Data.AppContext;
using BooksStore.Data.Repository;
using BooksStore.Shared.Core.Data;
using BookStore.Services;
using BookStore.Services.Implementation;
using BookStore.Services.Interface;
using HealthChecks.SqlServer;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BookDbContext>
    (option => option.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services
    .AddHealthChecks()
    .AddSqlServer(builder.Configuration.GetConnectionString(nameof(BookDbContext)));
//.AddCheck<SqlServerHealthCheck>("SqlServerHandyCheck");

builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseRouting()
    .UseEndpoints(config =>
    {
        config.MapHealthChecks("/health", new HealthCheckOptions
        {
            Predicate = _ => true,
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });
    });

app.MapControllers();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
