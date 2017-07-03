using System;
using System.Collections.Generic;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Application.ViewModel
{
    public class ClienteViewModel
    {
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
