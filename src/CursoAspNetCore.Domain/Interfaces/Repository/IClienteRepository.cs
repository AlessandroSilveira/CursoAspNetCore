using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Domain.Interfaces.Repository
{
	public interface IClienteRepository : IRepository<Cliente>
    {
        void Dispose();
    }
}
