using System;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class Organizador
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }

        public Organizador()
        {
            Id = Guid.NewGuid();
        }
    }
}
