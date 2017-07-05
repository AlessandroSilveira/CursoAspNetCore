using System;
using CursoAspNetCore.Domain.Validations;
using System.Collections.Generic;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Domain.Commands
{
	public class RegisterNewClienteCommand  : CustomerCommand
	{

		public RegisterNewClienteCommand( string nome , string sobrenome, string email, DateTime dataCadastro, DateTime dataNascimento,
		 bool etivo , ICollection<Endereco> enderecos )
	{
		Nome = nome,
		Sobrenome = sobrenome;
		Email = email;
		BirthDate = birthDate;
	}

	public override bool IsValid()
	{
		ValidationResult = new RegisterNewCustomerCommandValidation().Validate(this);
		return ValidationResult.IsValid;
	}
}
}