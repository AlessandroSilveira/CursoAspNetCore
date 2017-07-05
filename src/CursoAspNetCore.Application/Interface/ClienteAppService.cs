using System;
using System.Collections.Generic;
using AutoMapper;
using CursoAspNetCore.Application.Interface.Repository;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetCore.Domain.Interfaces.Services;
using CursoAspNetCore.Application.ViewModel;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Application.Interface
{
	public class ClienteAppService : ApplicationService, IClienteAppService
	{
		private readonly IClienteService _clienteService;
		private readonly IMapper _mapper;

		public ClienteAppService(IClienteService clienteService, IUnitOfWork uow,IMapper mapper) : base(uow)
		{
			_clienteService = clienteService;
			mapper = _mapper;
		}

		public ClienteViewModel Add(ClienteViewModel obj)
		{
			var area = _mapper.Map<ClienteViewModel, Cliente>(obj);
			BeginTransaction();
			_clienteService.Add(area);
			Commit();
			return obj;
		}

		public ClienteViewModel GetById(Guid id)
		{
			return _mapper.Map<Cliente, ClienteViewModel>(_clienteService.GetById(id));
		}

		public IEnumerable<ClienteViewModel> GetAll()
		{
			return _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteService.GetAll());
		}

		public ClienteViewModel Update(ClienteViewModel obj)
		{
			BeginTransaction();
			_clienteService.Update(_mapper.Map<ClienteViewModel, Cliente>(obj));
			Commit();
			return obj;
		}

		public void Remove(Guid id)
		{
			BeginTransaction();
			_clienteService.Remove(id);
			Commit();
		}

		public void Dispose()
		{
			_clienteService.Dispose();
		}
	}
}
