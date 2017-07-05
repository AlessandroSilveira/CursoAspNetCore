using System;
using CursoAspNetCore.Domain.Commands;
using CursoAspNetCore.Domain.Events;
using CursoAspNetCore.Domain.Interfaces;
using CursoAspNetCore.Domain.Models;
using CursoAspNetCore.Domain.Interfaces.Repository;

namespace CursoAspNetCore.Domain.CommandHandlers
{
	public class EnderecoCommandHandler : CommandHandler,
		IHandler<RegisterNewEnderecoCommand>,
		IHandler<UpdateEnderecoCommand>,
		IHandler<RemoveEnderecoCommand>
	{
		private readonly IEnderecoRepository _enderecoRepository;
		private readonly IBus Bus;

		public EnderecoCommandHandler(IEnderecoRepository enderecoRepository,
									  IUnitOfWork uow,
									  IBus bus,
									  IDomainNotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
		{
			_enderecoRepository = enderecoRepository;
			Bus = bus;
		}

		public void Handle(RegisterNewCustomerCommand message)
		{
			if (!message.IsValid())
			{
				NotifyValidationErrors(message);
				return;
			}

			var customer = new Customer(Guid.NewGuid(), message.Nome, message.Email, message.BirthDate);

			if (_clienteRepository.GetByEmail(customer.Email) != null)
			{
				Bus.RaiseEvent(new DomainNotification(message.MessageType, "The customer e-mail has already been taken."));
				return;
			}

			_clienteRepository.Add(customer);

			if (Commit())
			{
				Bus.RaiseEvent(new CustomerRegisteredEvent(customer.Id, customer.Name, customer.Email, customer.BirthDate));
			}
		}

		public void Handle(UpdateCustomerCommand message)
		{
			if (!message.IsValid())
			{
				NotifyValidationErrors(message);
				return;
			}

			var customer = new Customer(message.Id, message.Nome, message.Email, message.BirthDate);
			var existingCustomer = _clienteRepository.GetByEmail(customer.Email);

			if (existingCustomer != null)
			{
				if (!existingCustomer.Equals(customer))
				{
					Bus.RaiseEvent(new DomainNotification(message.MessageType, "The customer e-mail has already been taken."));
					return;
				}
			}

			_clienteRepository.Update(customer);

			if (Commit())
			{
				Bus.RaiseEvent(new CustomerUpdatedEvent(customer.Id, customer.Name, customer.Email, customer.BirthDate));
			}
		}

		public void Handle(RemoveCustomerCommand message)
		{
			if (!message.IsValid())
			{
				NotifyValidationErrors(message);
				return;
			}

			_clienteRepository.Remove(message.Id);

			if (Commit())
			{
				Bus.RaiseEvent(new CustomerRemovedEvent(message.Id));
			}
		}

		public void Dispose()
		{
			_clienteRepository.Dispose();
		}
	}
}