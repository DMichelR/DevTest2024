using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PollsApi.Application.Dtos;
using PollsApi.Application.Repositories;
using PollsApi.Application.Responses;
using PollsApi.Domain.Entities;

namespace PollsApi.Presentation;

[ApiController]
[Route("/api/v1/polls")]
public class PollController(
    IPollRepository pollRepository, 
    IVoteRepository voteRepository, 
    IOptionRepository optionRepository
    ) : ControllerBase
{
    [HttpGet()]
    public async Task<IResult> GetAllPolls()
    {
        IList<Poll> polls = await pollRepository.GetAll();
        IList<PollResponse> responses = new List<PollResponse>();
        foreach (Poll poll in polls)
        {
            responses.Add(new PollResponse()
            {
                Id = poll.Id,
                Name = poll.Name,
                Options = await optionRepository.GroupbyPoll(poll.Id)
            });
        }
        return Results.Ok(responses);
    }

    [HttpPost()]
    public async Task<IResult> PostPoll([FromBody] CreatePollDto request)
    {
        Poll poll = new()
        {
            Name = request.Name
            
        };
        var created = await pollRepository.Create(poll);
        List<Option> options = request.Options.Select(o => new Option() { Name = o.Name, PollId = poll.Id }).ToList();
        options.ForEach(async o => await optionRepository.Create(o));
        PollResponse response = new()
        {
            Id = poll.Id,
            Name = poll.Name,
            Options = options
        };
        return Results.Ok(response);
    }
    
    [HttpPost("{optionId:guid}/vote")]
    public async Task<IResult> PostVote(Guid optionId, [FromBody] CreateVoteDto request)
    {
        Vote vote = new()
        {
            OptionId = optionId,
            VoterEmail = request.VoterEmail,
        };
        var response = await voteRepository.Create(vote);
        return Results.Ok(response);
    }
}