using MAILSYSTEMCORE.DOMAIN.Contracts.Responses.MailJobDetails;
using MAILSYSTEMCORE.DOMAIN.Contracts.Responses.MailJobs;

namespace MAILSYSTEMCORE.DOMAIN.Contracts.Responses.MailingItems;

public class MailingItemResponse
{
    public MailJobResponse MailJob { get; set; }

    public AllMailJobDetailReponse MailJobDetails { get; set; }
}
