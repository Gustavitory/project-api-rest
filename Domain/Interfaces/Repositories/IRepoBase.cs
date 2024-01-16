using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_rest.Domain.Interfaces.Repositories
{
    public interface IRepoBase<TEntity, TEntityID> : IAdd<TEntity>, IGet<TEntity, TEntityID>, IDelete<TEntityID>, IEdit<TEntity>
    {

    }
}