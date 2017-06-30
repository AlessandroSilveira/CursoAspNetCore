using System;
using System.Collections.Generic;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Domain.Interfaces.Services
{
    public interface IClienteService : IDisposable
    {
       Cliente Add(Cliente obj);
        Cliente GetById(Guid id);
        IEnumerable<Cliente> GetAll();
        Cliente Update(Cliente obj);
        void Remove(Guid id);
    }
}
