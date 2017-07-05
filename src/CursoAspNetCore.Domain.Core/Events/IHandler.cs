using System;

namespace CursoAspNetCore.Domain.Core.Events
{
	public interface IHandler<in T> where T : Message
	{
		void Handle(T message);
	}
}