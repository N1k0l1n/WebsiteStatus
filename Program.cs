using Serilog;
using Serilog.Events;

namespace WebsiteStatus
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.File(@"C:\temp\workservice\LogFile.text")
                .CreateLogger();

            try
            {
                Log.Information("Starting up the service");

                IHost host = Host.CreateDefaultBuilder(args)
                    .UseWindowsService() // This configures the application to run as a Windows Service
                    .ConfigureServices(services =>
                    {
                        services.AddHostedService<Worker>();
                    })
                    .UseSerilog()
                    .Build();

                await host.RunAsync();
            }

            catch (Exception ex)
            {
                Log.Fatal(ex, "There was a problem starting the service");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
