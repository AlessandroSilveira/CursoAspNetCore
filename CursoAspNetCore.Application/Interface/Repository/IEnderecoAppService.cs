using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspNetCore.Application.Interface.Repository
{
    public interface IEnderecoAppService : IDisposable
    {
        EnderecoViewModel Add(EnderecoViewModel obj);
        EnderecoViewModel GetById(Guid id);
        IEnumerable<EnderecoViewModel> GetAll();
        EnderecoViewModel Update(EnderecoViewModel obj);
        void Remove(Guid id);
    }
}
