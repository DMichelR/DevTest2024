namespace PollsApi.Application.Dtos;

public class CreateVoteDto
{
    public required Guid OptionId { get; set; }
    public required string VoterEmail { get; set; }
}