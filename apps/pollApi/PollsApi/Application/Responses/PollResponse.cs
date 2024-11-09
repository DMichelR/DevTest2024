using PollsApi.Domain.Entities;

namespace PollsApi.Application.Responses;

public class PollResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IList<Option> Options { get; set; }
}