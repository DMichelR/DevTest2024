namespace PollsApi.Domain.Entities;

public class Poll : IEntity
{
    public Guid Id { get;} = Guid.NewGuid();
    public required string Name { get; set; }

}