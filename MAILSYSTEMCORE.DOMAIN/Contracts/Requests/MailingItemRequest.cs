namespace MAILSYSTEMCORE.DOMAIN.Contracts.Requests;

public record MailingItemRequest(MailJobRequest job, List<MailJobDetailRequest> jobDetails);
