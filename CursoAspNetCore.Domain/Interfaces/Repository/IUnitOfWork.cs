using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspNetCore.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}
