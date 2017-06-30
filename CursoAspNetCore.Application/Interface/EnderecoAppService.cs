using System;
using System.Collections.Generic;
using CursoAspNetCore.Application.Interface.Repository;

namespace CursoAspNetCore.Application.Interface
{
    public class EnderecoAppService : ApplicationService, IEnderecoAppService
    {

        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService, IUnitOfWork uow) : base(uow)
        {
            _enderecoService = enderecoService;
        }

        public EnderecoViewModel Add(EnderecoViewModel obj)
        {
            var area = Mapper.Map<EnderecoViewModel, Endereco>(obj);
            BeginTransaction();
            _enderecoService.Add(area);
            Commit();
            return obj;
        }

        public EnderecoViewModel GetById(Guid id)
        {
            return Mapper.Map<Endereco, EnderecoViewModel>(_enderecoService.GetById(id));
        }

        public IEnumerable<EnderecoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(_enderecoService.GetAll());
        }

        public EnderecoViewModel Update(EnderecoViewModel obj)
        {
            BeginTransaction();
            _enderecoService.Update(Mapper.Map<EnderecoViewModel, Endereco>(obj));
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
