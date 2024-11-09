using PollsApi.Application.Repositories;
using PollsApi.Domain.Entities;

namespace PollsApi.Infrastructure;

public class PollRepository : IPollRepository
{
    private readonly IList<Poll> _polls = [];
    public Task<IList<Poll>> GetAll()
    {
        return Task.FromResult(_polls);
    }

    public  Task<Poll> Create(Poll entity)
    {
        _polls.Add(entity);
        return Task.FromResult(entity);
    }
    
}