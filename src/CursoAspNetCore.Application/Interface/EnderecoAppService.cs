using System;
using System.Collections.Generic;
using AutoMapper;
using CursoAspNetCore.Application.Interface.Repository;
using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetCore.Domain.Services;
using CursoAspNetCore.Application.ViewModel;

namespace CursoAspNetCore.Application.Interface
{
	public class EnderecoAppService : ApplicationService, IEnderecoAppService
    {

        private readonly IEnderecoService _enderecoService;
		private readonly IMapper _mapper;

		public EnderecoAppService(IEnderecoService enderecoService, IUnitOfWork uow,IMapper mapper) : base(uow)
        {
            _enderecoService = enderecoService;
			mapper = _mapper;
        }

        public EnderecoViewModel Add(EnderecoViewModel obj)
        {
			var endereco = _mapper.Map<EnderecoViewModel, Endereco>(obj);
			BeginTransaction();
            _enderecoService.Add(endereco);
            Commit();
            return obj;
        }

        public EnderecoViewModel GetById(Guid id)
        {
			return _mapper.Map<Endereco, EnderecoViewModel>(_enderecoService.GetById(id));
		}

        public IEnumerable<EnderecoViewModel> GetAll()
        {
			return _mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(_enderecoService.GetAll());
		}

        public EnderecoViewModel Update(EnderecoViewModel obj)
        {
            BeginTransaction();
			_enderecoService.Update(_mapper.Map<EnderecoViewModel, Endereco>(obj));
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
