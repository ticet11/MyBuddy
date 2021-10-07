using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;

[assembly: UserSecretsId("C5B940BA-1787-45FF-B082-A25153B02F59")]
namespace MyBuddy
{
    static class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            string devEnvironmentVariable = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
            bool isDevelopment = string.IsNullOrEmpty(devEnvironmentVariable) || devEnvironmentVariable.ToLower() == "development";
            // Determines the working environment as IHostingEnvironment is unavailable in

            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            if (isDevelopment)
            {
                builder.AddUserSecrets<EmailCredentials>();
            }

            IConfiguration Configuration = builder.Build();

            ServiceProvider services = new ServiceCollection()
                .Configure<EmailCredentials>(Configuration.GetSection(nameof(EmailCredentials)))
                .AddOptions()
                .BuildServiceProvider();

            services.GetService<EmailCredentials>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDashboard(Configuration["EmailCredentials:Username"], Configuration["EmailCredentials:Password"])); //TODO-Brian: Access Secrets
        }
    }
}
