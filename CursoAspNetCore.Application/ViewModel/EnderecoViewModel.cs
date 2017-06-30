using System;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Application.ViewModel
{
    public class EnderecoViewModel
    {
        public Guid EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid ClientId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
