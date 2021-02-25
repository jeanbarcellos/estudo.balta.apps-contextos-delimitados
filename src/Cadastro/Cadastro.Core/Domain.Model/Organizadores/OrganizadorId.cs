using System;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class OrganizadorId
    {
        public Guid Id { get; private set; }

        public OrganizadorId()
        {
            Id = Guid.NewGuid();
        }
    }
}