using AutoMapper;
using CursoAspNetCore.Application.ViewModel;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Application.AutoMapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Cliente, ClienteViewModel>();
			CreateMap<Endereco, EnderecoViewModel>();
			CreateMap<ClienteViewModel, Cliente>();
			CreateMap<EnderecoViewModel,Endereco>();
		}
	}
}
 