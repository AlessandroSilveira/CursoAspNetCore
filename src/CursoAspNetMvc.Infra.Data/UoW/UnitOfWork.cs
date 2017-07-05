using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetMvc.Infra.Data.Context;

namespace CursoAspNetCore.Infra.Data.UoW
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly CursoAspNetCoreContext _context;

		public UnitOfWork(CursoAspNetCoreContext context)
		{
			_context = context;
		}

		public CommandResponse Commit()
		{
			var rowsAffected = _context.SaveChanges();
			return new CommandResponse(rowsAffected > 0);
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
