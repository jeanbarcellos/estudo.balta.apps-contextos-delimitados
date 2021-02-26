using Nucleo.Core;
using System;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class Organizador
    {
        public OrganizadorId Id { get; private set; }
        public string Nome { get; private set; }
        public NomeCompleto Responsavel { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Organizador(OrganizadorId id, string nome, NomeCompleto responsavel)
        {
            Id = id;
            Nome = nome;
            Responsavel = responsavel;
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
