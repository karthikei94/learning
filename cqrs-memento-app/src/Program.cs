using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using cqrs_memento_app.Application.Commands;
using cqrs_memento_app.Application.Queries;
using cqrs_memento_app.Application.Services;
using cqrs_memento_app.Infrastructure.Persistence;
using cqrs_memento_app.Infrastructure.ServiceBus;

namespace cqrs_memento_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<ITextRepository, TextRepository>();
                    services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
                    services.AddSingleton<IDepartmentRepository, DepartmentRepository>();
                    services.AddSingleton<TextService>();
                    services.AddSingleton<InMemoryServiceBus>();

                    // Register command and query handlers
                    services.AddTransient<SaveTextCommand>();
                    services.AddTransient<GetTextQuery>();
                });
    }
}