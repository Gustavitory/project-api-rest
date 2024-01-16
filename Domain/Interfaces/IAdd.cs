using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_rest.Domain.Interfaces;
public interface IAdd<TEntity>
{
    TEntity Add(TEntity entity);

}
