using MediatR;

namespace MAILSYSTEMCORE.DOMAIN.Primitives;

public interface IDomainEvent : INotification
{
    public Guid Id { get; init; }
}
