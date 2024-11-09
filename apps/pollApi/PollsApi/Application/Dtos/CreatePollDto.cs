using PollsApi.Domain.Entities;

namespace PollsApi.Application.Dtos;

public class CreatePollDto
{
    public required string Name { get; set; }
    
    public IList<CreateOptionDto> Options { get; set; }
}