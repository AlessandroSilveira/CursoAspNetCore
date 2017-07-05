using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetMvc.Infra.Data.Context;

namespace CursoAspNetCore.Infra.Data.Repository
{
	public class EnderecoRepositoryBase : RepositoryBase<Endereco>, IEnderecoRepository
	{
		public EnderecoRepositoryBase(CursoAspNetCoreContext context) : base(context)
		{
		}
	}
}