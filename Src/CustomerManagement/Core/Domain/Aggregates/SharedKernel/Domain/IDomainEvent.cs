namespace  Domain.Aggregates.SharedKernel.Domain;
public interface IDomainEvent
{
    DateTime OccurredOn { get; }
}
