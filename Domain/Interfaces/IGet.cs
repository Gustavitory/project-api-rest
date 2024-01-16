using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_rest.Domain.Interfaces;
public interface IGet<TEntity, TEntityID>
{
    List<TEntity> Get();
    TEntity GetForId(TEntityID entityID);

}
