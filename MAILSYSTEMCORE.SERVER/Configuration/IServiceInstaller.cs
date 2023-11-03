namespace MAILSYSTEMCORE.SERVER.Configuration;

public interface IServiceInstaller
{
    void Install(IServiceCollection services, IConfiguration configuration);
}
