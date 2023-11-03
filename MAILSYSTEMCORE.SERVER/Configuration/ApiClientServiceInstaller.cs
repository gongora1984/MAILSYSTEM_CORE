using MAILSYSTEMCORE.SERVER.Services;

namespace MAILSYSTEMCORE.SERVER.Configuration;

public class ApiClientServiceInstaller : IServiceInstaller
{
    /// <summary>
    /// Dependency Injection configuration.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        // Services Here.
        services.AddSingleton<WeatherForecastService>();
        ////services.AddScoped<IAccountClient, AccountClient>();
        ////services.AddScoped<ICompanyClient, CompanyClient>();
        ////services.AddScoped<IListItemClient, ListItemClient>();
        ////services.AddScoped<IMailingClient, MailingClient>();
        ////services.AddScoped<IStateClient, StateClient>();
    }
}
