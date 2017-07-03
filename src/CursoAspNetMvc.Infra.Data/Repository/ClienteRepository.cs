using System;
using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetCore.Infra.Data.Repository;
using CursoAspNetMvc.Infra.Data.Context;

namespace CursoAspNetMvc.Infra.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(CursoAspNetCoreContext context) : base()
        {
        }
    }
}
