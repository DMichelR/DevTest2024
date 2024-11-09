using PollsApi.Domain.Entities;

namespace PollsApi.Application.Repositories;

public interface IRepository<TEntity> where TEntity : IEntity
{
     Task<IList<TEntity>> GetAll();
     
     Task<string> Create(TEntity entity);
}