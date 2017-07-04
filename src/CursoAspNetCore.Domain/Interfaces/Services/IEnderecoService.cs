using CursoAspNetCore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CursoAspNetCore.Domain.Services
{
	public interface IEnderecoService : IDisposable
	{
		Endereco Add(Endereco obj);
		Endereco GetById(Guid id);
		IEnumerable<Endereco> GetAll();
		Endereco Update(Endereco obj);
		void Remove(Guid id);
	}
}
