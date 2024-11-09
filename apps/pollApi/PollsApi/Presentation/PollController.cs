using Microsoft.AspNetCore.Mvc;
using PollsApi.Application.Dtos;
using PollsApi.Application.Repositories;
using PollsApi.Domain.Entities;

namespace PollsApi.Presentation;

[ApiController]
[Route("/api/v1/polls")]
public class PollController(IPollRepository pollRepository) : ControllerBase
{
    [HttpGet()]
    public async Task<IResult> GetAllPolls()
    {
        return Results.Ok(await pollRepository.GetAll());
    }

    [HttpPost()]
    public async Task<IResult> PostPoll([FromBody] CreatePollDto request)
    {
        Poll poll = new()
        {
            Name = request.Name,
        };
        string response = await pollRepository.Create(poll);
        return Results.Ok(response);
    }
}