using project_rest.Application.Enums;
using project_rest.Domain.Interfaces;

namespace project_rest.Application.Interfaces;
public interface ITaskService<TEntity, TEntityID> : IAdd<TEntity>, IDelete<TEntityID>, IGet<TEntity, TEntityID>, IEdit<TEntity>
{
    void ChangeStatus(TEntityID entityID, EStatus status);
}