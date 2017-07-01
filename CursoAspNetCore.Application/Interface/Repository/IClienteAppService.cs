using CursoAspNetCore.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace CursoAspNetCore.Application.Interface.Repository
{
	public interface IClienteAppService : IDisposable
    {
        ClienteViewModel Add(ClienteViewModel obj);
        ClienteViewModel GetById(Guid id);
        IEnumerable<ClienteViewModel> GetAll();
        ClienteViewModel Update(ClienteViewModel obj);
        void Remove(Guid id);
    }
}
