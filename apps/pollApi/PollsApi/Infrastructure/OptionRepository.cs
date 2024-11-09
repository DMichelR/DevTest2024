using PollsApi.Application.Repositories;
using PollsApi.Domain.Entities;

namespace PollsApi.Infrastructure;

public class OptionRepository : IOptionRepository
{
    private readonly IList<Option> _options = [];
    public Task<IList<Option>> GetAll()
    {
        return Task.FromResult(_options);
    }

    public Task<Option> Create(Option entity)
    {
        _options.Add(entity);
        return Task.FromResult(entity);
    }

    public Task<IList<Option>> GroupbyPoll(Guid pollId)
    {
        IList<Option> grupedOptions = _options.Where(o => o.PollId == pollId).ToList();
        return Task.FromResult(grupedOptions); 
        
    }
}