namespace PollsApi.Domain.Entities;

public class Vote : IEntity
{
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid OptionId { get; set; }
    public required string VoterEmail { get; set; }
}