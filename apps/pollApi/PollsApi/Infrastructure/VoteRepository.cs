using PollsApi.Application.Repositories;
using PollsApi.Domain.Entities;

namespace PollsApi.Infrastructure;

public class VoteRepository : IVoteRepository
{
    private readonly IList<Vote> _votes = [];
    public Task<IList<Vote>> GetAll()
    {
        return Task.FromResult(_votes);
    }

    public Task<Vote> Create(Vote entity)
    {
        _votes.Add(entity);
        return Task.FromResult(entity);
    }
}