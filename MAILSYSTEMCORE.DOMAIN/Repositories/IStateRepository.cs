using MAILSYSTEMCORE.DOMAIN.Entities;

namespace MAILSYSTEMCORE.DOMAIN.Repositories;

public interface IStateRepository : IGenericRepository<State>
{
    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);
    Task<bool> IsAbbreviationUniqueAsync(string abbreviation, CancellationToken cancellationToken = default);
}
