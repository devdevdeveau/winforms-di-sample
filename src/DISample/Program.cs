using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DISample;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize(); // DO ME FIRST

        var host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<Form1>();
                services.AddTransient<Form2>();
                services.AddSingletonForm<Form3>();
                services.AddSingleton<IFormFactory, FormFactory>();
                services.AddSingleton<GameState>();
            }).Build();

        using var scope = host.Services.CreateScope();

        var form1 = scope.ServiceProvider.GetRequiredService<Form1>();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Application.Run(form1);
    }
}