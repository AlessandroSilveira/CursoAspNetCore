using System;
using CursoAspNetCore.Domain.Core.Commands;

namespace CursoAspNetCore.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
