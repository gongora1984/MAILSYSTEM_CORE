using MAILSYSTEMCORE.DOMAIN.Entities;

namespace MAILSYSTEMCORE.DOMAIN.Abstractions;

public interface IApiProvider
{
    string GenerateApiKey(Company company);
}
