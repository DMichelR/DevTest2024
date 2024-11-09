namespace PollsApi.Domain.Entities;

public class Option : IEntity
{
    public Guid Id { get; } = Guid.NewGuid();
    //public int internalId { get; } = 
    public required string Name { get; set; }
    public required Guid PollId { get; set; }
    
    public IList<Vote> Votes { get; set; } = [];
}