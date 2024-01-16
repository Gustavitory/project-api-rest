using project_rest.Domain.Interfaces;

namespace project_rest.Application.Interfaces;
public interface IServiceBase<TEntity, TEntityID> : IAdd<TEntity>, IDelete<TEntityID>, IGet<TEntity, TEntityID>, IEdit<TEntity> { }