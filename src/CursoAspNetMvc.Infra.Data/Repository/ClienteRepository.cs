
using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetMvc.Infra.Data.Context;

namespace CursoAspNetCore.Infra.Data.Repository
{
	public class ClienteRepositoryBase : RepositoryBase<Cliente>, IClienteRepository
	{
		public ClienteRepositoryBase(CursoAspNetCoreContext context) : base(context)
		{
		}
	}
}