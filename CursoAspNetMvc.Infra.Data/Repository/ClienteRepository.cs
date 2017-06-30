using System;
using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetMvc.Infra.Data.Context;

namespace CursoAspNetMvc.Infra.Data.Repository
{
    public class ClienteRepositoryBase : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepositoryBase(CursoAspNetCoreContext context) : base(context)
        {
        }
    }
}
