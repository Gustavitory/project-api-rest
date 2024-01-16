using project_rest.Domain.Interfaces;
using project_rest.Domain.Interfaces.Repositories;

namespace project_rest.Domain.interfaces.Repositories;
public interface IRepoTask<TEntity, TEntityID> : IAdd<TEntity>, IDelete<TEntityID>, IEdit<TEntity>, IGet<TEntity, TEntityID>, ITransaction { }