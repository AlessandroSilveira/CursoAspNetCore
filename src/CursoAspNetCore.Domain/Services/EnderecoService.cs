﻿using CursoAspNetCore.Domain.Entities;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CursoAspNetCore.Domain.Services
{
	public class EnderecoService : IEnderecoService
	{
		private readonly IEnderecoRepository _enderecoRepository;

		public EnderecoService(IEnderecoRepository enderecoRepository)
		{
			_enderecoRepository = enderecoRepository;
		}

		public Endereco Add(Endereco obj)
		{
			return _enderecoRepository.Add(obj);
		}

		public Endereco GetById(Guid id)
		{
			return _enderecoRepository.GetById(id);
		}

		public IEnumerable<Endereco> GetAll()
		{
			return _enderecoRepository.GetAll();
		}

		public Endereco Update(Endereco obj)
		{
			return _enderecoRepository.Add(obj);
		}

		public void Remove(Guid obj)
		{
			_enderecoRepository.Remove(obj);
		}

		public void Dispose()
		{
			_enderecoRepository.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
