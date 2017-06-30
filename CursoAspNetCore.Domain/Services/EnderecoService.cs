using System;
using System.Collections.Generic;
using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;

namespace CursoAspNetCore.Domain.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository _nderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public Endereco Add(Endereco obj)
        {
            return _enderecoRepository.Add(obj);
        }

        public Endereco GetById(Guid id)
        {
            return _enderecoRepository.GetById(id);
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _enderecoRepository.GetAll();
        }

        public Endereco Update(Cliente obj)
        {
            return _enderecoRepository.Add(obj);
        }

        public void Remove(Guid obj)
        {
            _enderecoRepository.Remove(obj);
        }

        public void Dispose()
        {
            _enderecoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
