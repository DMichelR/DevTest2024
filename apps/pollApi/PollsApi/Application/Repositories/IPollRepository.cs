using PollsApi.Domain.Entities;

namespace PollsApi.Application.Repositories;

public interface IPollRepository : IRepository<Poll>
{
    // Task<Poll> PatchPoll(IList<Option> options, Guid pollId);
}