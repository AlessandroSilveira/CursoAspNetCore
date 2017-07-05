using System;
using System.Collections.Generic;
using CursoAspNetCore.Domain.Core.Events;

namespace CursoAspNetCore.Infra.Data.Repository.EventSourcing
{
	public interface IEventStoreRepository : IDisposable
	{
		void Store(StoredEvent theEvent);
		IList<StoredEvent> All(Guid aggregateId);
	}
}