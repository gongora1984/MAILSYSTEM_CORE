using MAILSYSTEMCORE.DOMAIN.Primitives;

namespace MAILSYSTEMCORE.DOMAIN.Entities;

public partial class SearchHistoryDetail : Entity, IAuditableEntity
{
    public Guid SearchHistoryId { get; set; }

    public string? Ssn { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Dod { get; set; }
    public virtual SearchHistory SearchHistory { get; set; } = null!;
}
