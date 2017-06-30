using System;
using System.Collections.Generic;
using CursoAspNetCore.Application.Interface.Repository;

namespace CursoAspNetCore.Application.Interface
{
    public class ClienteAppService : ApplicationService, IClienteAppService    {

        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService, IUnitOfWork uow) : base(uow)
        {
            _clienteService = clienteService;
        }

        public ClienteViewModel Add(ClienteViewModel obj)
        {
            var area = Mapper.Map<ClienteViewModel, Cliente>(obj);
            BeginTransaction();
            _clienteService.Add(area);
            Commit();
            return obj;
        }

        public ClienteViewModel GetById(Guid id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.GetById(id));
        }

        public IEnumerable<ClienteViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteService.GetAll());
        }

        public ClienteViewModel Update(ClienteViewModel obj)
        {
            BeginTransaction();
            _clienteService.Update(Mapper.Map<ClienteViewModel, Cliente>(obj));
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
