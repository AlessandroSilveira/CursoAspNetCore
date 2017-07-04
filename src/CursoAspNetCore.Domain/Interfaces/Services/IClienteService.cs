using CursoAspNetCore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CursoAspNetCore.Domain.Services
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
