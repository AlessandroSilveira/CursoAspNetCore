using System;
using System.Collections.Generic;
using AutoMapper;
using CursoAspNetCore.Application.Interface.Repository;
using CursoAspNetCore.Application.ViewModel;
using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetCore.Domain.Services;

namespace CursoAspNetCore.Application.Interface
{
    public class EnderecoAppService : ApplicationService, IEnderecoAppService
    {

        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService, IUnitOfWork uow) : base(uow)
        {
            _enderecoService = enderecoService;
        }

        public Endereco Add(Endereco obj)
        {
          
            BeginTransaction();
            _enderecoService.Add(obj);
            Commit();
            return obj;
        }

        public Endereco GetById(Guid id)
        {
            return _enderecoService.GetById(id);
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _enderecoService.GetAll();
        }

        public Endereco Update(Endereco obj)
        {
            BeginTransaction();
            _enderecoService.Update(obj);
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _enderecoService.Remove(id);
            Commit();
        }
        public void Dispose()
        {
            _enderecoService.Dispose();
        }
    }
}
