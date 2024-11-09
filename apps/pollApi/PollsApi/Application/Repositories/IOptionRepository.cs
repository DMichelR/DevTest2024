using PollsApi.Domain.Entities;

namespace PollsApi.Application.Repositories;

public interface IOptionRepository : IRepository<Option>
{
    Task<IList<Option>> GroupbyPoll(Guid pollId);
}