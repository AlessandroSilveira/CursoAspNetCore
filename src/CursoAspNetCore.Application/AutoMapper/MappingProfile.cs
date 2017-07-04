using AutoMapper;

namespace CursoAspNetCore.Application.AutoMapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Worklog, AgileWorklog>();
			CreateMap<AgileWorklog, Worklog>();
		}
	}
}
 