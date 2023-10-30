using MAILSYSTEMCORE.DOMAIN.Repositories;

namespace MAILSYSTEMCORE.DOMAIN.Abstractions;

public interface IUnitOfWork
{
    ICommonRepository CommonRepository { get; }

    ICompanyRepository CompanyRepository { get; }

    IListItemRepository ListItemRepository { get; }

    IStateRepository StateRepository { get; }

    IMailingRepository MailingRepository { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
