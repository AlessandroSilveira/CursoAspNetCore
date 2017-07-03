using System;
using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetCore.Infra.Data.Repository;
using CursoAspNetMvc.Infra.Data.Context;

namespace CursoAspNetMvc.Infra.Data.Repository
{
    public class EnderecoRepositoryBase : RepositoryBase<Endereco>, IClienteRepository
    {
        public EnderecoRepositoryBase(CursoAspNetCoreContext context) : base(context)
        {
        }
    }
}
