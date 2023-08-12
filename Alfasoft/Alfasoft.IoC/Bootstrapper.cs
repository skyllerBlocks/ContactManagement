using Alfasoft.Application.Services;
using Alfasoft.Dapper.Factory;
using Alfasoft.Dapper.Repositories;
using Alfasoft.Domain.Enum;
using Alfasoft.Domain.Interfaces.Repositories;
using Alfasoft.Domain.Interfaces.Services;
using ExternalServices.ExternalInterface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Alfasoft.IoC
{
    public class Bootstrapper
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //Services
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IPersonService, PersonService>();

            //Repositories
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();

            //External Services
            services.AddRefitClient<IRestcountriesService>().ConfigureHttpClient(x =>
            {
                x.BaseAddress = new Uri("https://restcountries.com/v3.1/");
            });

            //Connections
            var connectionDict = new Dictionary<EnumDataBaseConnection, string>
            {
                {EnumDataBaseConnection.DBSQLite, configuration.GetSection("ConnectionStrings:DBSQLite:DataSource").Value}
            };

            services.AddSingleton<IDictionary<EnumDataBaseConnection, string>>(connectionDict);
            services.AddTransient<IDbConnectionFactory, DapperConnectionFactory>();
        }
    }

}