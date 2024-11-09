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

    public Task<string> Create(Option entity)
    {
        _options.Add(entity);
        return Task.FromResult(entity.Id.ToString());
    }
}