using CursoAspNetCore.Domain.Core.Commands;
using CursoAspNetCore.Domain.Core.Events;

namespace CursoAspNetCore.Domain.Core.Bus
{
	public interface IBus
	{
		void SendCommand<T>(T theCommand) where T : Command;
		void RaiseEvent<T>(T theEvent) where T : Event;
	}
}