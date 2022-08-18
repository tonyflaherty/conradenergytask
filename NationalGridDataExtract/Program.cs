// See https://aka.ms/new-console-template for more information
using ConradEnergy.EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NationalGridDataExtract;

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile($"appsettings.json", false, true)
    .AddEnvironmentVariables()
    .Build();

var hostBuilder = Host.CreateDefaultBuilder(args)
        .ConfigureAppConfiguration(x => x.AddConfiguration(config))
        .ConfigureServices((hostContext, services) =>
        {
            services.AddScoped<ExtractService>();
            services.AddDbContext<ConradEnergyContext>(options =>
            {
#if DEBUG
                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
#endif
                options.UseSqlServer(hostContext.Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddHttpClient<IDataService, DataService>();
        })
        .Build();



await hostBuilder.Services.GetRequiredService<ExtractService>().StartAsync();
