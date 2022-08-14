// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PropertyInspection.Data;

Console.WriteLine("Hello, World!");

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var builder = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddDbContext<PropertyInspectionContext>(options => 
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        services.AddTransient<IInspectorService, InspectorService>();
    }).Build();

var service = builder.Services.GetRequiredService<IInspectorService>();
service.AddInspector();


builder.Run();