using System;
using System.Collections.Generic;
using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;

namespace CursoAspNetCore.Domain.Services
{
	public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Add(Cliente obj)
        {
            return _clienteRepository.Add(obj);
        }

        public Cliente GetById(Guid id)
        {
            return _clienteRepository.GetById(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente Update(Cliente obj)
        {
            return _clienteRepository.Add(obj);
        }

        public void Remove(Guid obj)
        {
            _clienteRepository.Remove(obj);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
