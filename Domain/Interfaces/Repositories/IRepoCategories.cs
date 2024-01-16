using project_rest.Domain.Interfaces;
using project_rest.Domain.Interfaces.Repositories;

namespace project_rest.Domain.interfaces.Repositories;
public interface IRepoCategories<TEntity, TEntityID> : IGet<TEntity, TEntityID>, ITransaction { }
