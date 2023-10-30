using MAILSYSTEMCORE.DOMAIN.Entities;

namespace MAILSYSTEMCORE.DOMAIN.Repositories;

public interface IMailingRepository : IGenericRepository<MailJob>
{
    Task<string> AddMailingJob(MailJob job, List<MailJobDetail> jobDetails, CancellationToken cancellationToken = default);

    Task<bool> AddJobDetails(MailJobDetail jobDetails, CancellationToken cancellationToken = default);

    Task<List<MailJobDetail>> GetDetailsByMailJobIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<MailJob> GetMailData(Guid jobId, CancellationToken cancellationToken = default);
    Task<bool> IsMailJobForCompany(Guid jobId, Guid companyId, CancellationToken cancellationToken = default);
}
