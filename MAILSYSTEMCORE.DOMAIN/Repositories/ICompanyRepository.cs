using MAILSYSTEMCORE.DOMAIN.Entities;

namespace MAILSYSTEMCORE.DOMAIN.Repositories;

public interface ICompanyRepository : IGenericRepository<Company>
{
    ////Task<Company?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<CompanyLogin?> GetApiKeyByCompanyIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<CompanyLogin?> GetCompanyByAccessTokenAsync(string accessToken, CancellationToken cancellationToken = default);

    ////Task<Company?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

    ////Task<Company?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    ////Task<bool> IsEmailUniqueAsync(string email, CancellationToken cancellationToken = default);

    ////Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> IsValidCredentialAsync(string email, string password, CancellationToken cancellationToken = default);
}
