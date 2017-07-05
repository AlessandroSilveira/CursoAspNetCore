﻿using CursoAspNetCore.Domain.Core.Events;
using CursoAspNetCore.Domain.Events;

namespace CursoAspNetCore.Domain.EventHandlers
{
    public class CustomerEventHandler :
        IHandler<CustomerRegisteredEvent>,
        IHandler<CustomerUpdatedEvent>,
        IHandler<CustomerRemovedEvent>
    {
        public void Handle(CustomerUpdatedEvent message)
        {
            // Send some notification e-mail
        }

        public void Handle(CustomerRegisteredEvent message)
        {
            // Send some greetings e-mail
        }

        public void Handle(CustomerRemovedEvent message)
        {
            // Send some see you soon e-mail
        }
    }
}