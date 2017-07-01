using CursoAspNetCore.Application.ViewModel;
using System;
using System.Collections.Generic;

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
