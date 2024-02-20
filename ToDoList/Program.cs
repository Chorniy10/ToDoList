using Microsoft.EntityFrameworkCore;
using ToDoList.DAL;
using ToDoList.DAL.Interfaces;
using ToDoList.DAL.Repositories;
using ToDoList.Domain.Entity;
using ToDoLIst.Service.Implementations;
using ToDoLIst.Service.Interfaces;
using Microsoft.AspNetCore.Mvc.Razor;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<IBaseRepository<TaskEntity>, TaskRepository>();
        builder.Services.AddScoped<ITaskService, TaskService>();
        var connectionString = builder.Configuration.GetConnectionString("MSSQL");
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        

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

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Task}/{action=Index}/{id?}");

        
        app.Run();
    }
}