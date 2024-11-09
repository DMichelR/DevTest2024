namespace PollsApi.Application.Responses;

public class OptionResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Votes { get; set; }
}