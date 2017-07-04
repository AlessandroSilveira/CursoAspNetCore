using AutoMapper;
using CursoAspNetCore.Application.ViewModel;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Application.AutoMapper
{
	internal class DomainToViewModelMappingProfile: Profile
	{
		
			public DomainToViewModelMappingProfile()
			{
				CreateMap<Cliente, ClienteViewModel>();
				CreateMap<Endereco, EnderecoViewModel>();
			}
		
	}
}