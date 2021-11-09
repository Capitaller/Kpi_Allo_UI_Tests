using System;
using Autofac;
using Kpi.Allo.ClientTests.Domain.Login;
using Kpi.Allo.ClientTests.Model.Domain.Login;
using Kpi.Allo.ClientTests.Model.Domain.Product;
using Kpi.Allo.ClientTests.Model.Domain.Search;
using Kpi.Allo.ClientTests.Model.Platform.Drivers;
using Kpi.Allo.ClientTests.Platform.Configuration.Environment;
using Kpi.Allo.ClientTests.Platform.Configuration.Run;
using Kpi.Allo.ClientTests.Platform.Driver;
using Kpi.Allo.ClientTests.UI.Login;
using Kpi.Allo.ClientTests.UI.Product;
using Kpi.Allo.ClientTests.UI.Search;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;

namespace Kpi.Allo.ClientTests.Bootstrap
{
    public class Bootstraper
    {
        private ContainerBuilder _builder;

        public ContainerBuilder Builder => _builder ??= new ContainerBuilder();

        public void ConfigureServices(IConfigurationBuilder configurationBuilder)
        {
            var configurationRoot = configurationBuilder.Build();
            Builder.Register<ILogger>((c, p) => new LoggerConfiguration()
                .WriteTo.File(
                    $"Logs/log_{DateTime.UtcNow:yyyy_MM_dd_hh_mm_ss}.txt",
                    LogEventLevel.Verbose,
                    "{Timestamp:dd-MM-yyyy HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger())
                .SingleInstance();

            // Configurations
            Builder.Register<IEnvironmentConfiguration>(context => configurationRoot.Get<EnvironmentConfiguration>())
                .SingleInstance();
            Builder.Register<IRunSettings>(cont => configurationRoot.Get<RunSettings>())
                .SingleInstance();

            // Logic
            Builder.RegisterType<LoginSteps>().As<ILoginSteps>().SingleInstance();
            Builder.RegisterType<SearchSteps>().As<ISearchSteps>().SingleInstance();
            Builder.RegisterType<ProductTopSteps>().As<IProductTopSteps>().SingleInstance();
            Builder.RegisterType<LoginContext>().As<ILoginContext>().SingleInstance();

            Builder.RegisterType<WebDriver>().As<IWebDriver>().SingleInstance();
        }
    }
}
