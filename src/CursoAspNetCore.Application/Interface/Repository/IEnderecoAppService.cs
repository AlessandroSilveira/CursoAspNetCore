using CursoAspNetCore.Application.ViewModel;
using System;
using System.Collections.Generic;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Application.Interface.Repository
{
	public interface IEnderecoAppService : IDisposable
    {
        Endereco Add(Endereco obj);
        Endereco GetById(Guid id);
        IEnumerable<Endereco> GetAll();
        Endereco Update(Endereco obj);
        void Remove(Guid id);
    }
}
