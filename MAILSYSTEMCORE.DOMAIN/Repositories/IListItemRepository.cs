using MAILSYSTEMCORE.DOMAIN.Entities;

namespace MAILSYSTEMCORE.DOMAIN.Repositories;

/// <summary>
/// ListItem Repository Interface.
/// </summary>
public interface IListItemRepository : IGenericRepository<ListItem>
{
    Task<bool> IsSystemCategoryUniqueAsync(string systemCategory, CancellationToken cancellationToken = default);
    Task<bool> IsSystemTagUniqueAsync(string systemCategory, string systemTag, CancellationToken cancellationToken = default);
}
