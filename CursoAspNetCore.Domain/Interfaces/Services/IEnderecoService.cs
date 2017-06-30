using System;
using System.Collections.Generic;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Domain.Interfaces.Services
{
    public interface IEnderecoService : IDisposable
    {
        Endereco Add(Endereco obj);
        Endereco GetById(Endereco id);
        IEnumerable<Endereco> GetAll();
        Endereco Update(Endereco obj);
        void Remove(Guid id);
    }
}
