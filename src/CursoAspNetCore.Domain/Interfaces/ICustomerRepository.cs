using Equinox.Domain.Models;

namespace CursoAspNetCore.Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByEmail(string email);
    }
}