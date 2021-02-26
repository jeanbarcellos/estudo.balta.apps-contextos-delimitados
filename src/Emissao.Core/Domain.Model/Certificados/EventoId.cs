using Nucleo.Core;
using System;

namespace Emissao.Core.Domain.Model.Certificados
{
    public class EventoId : Identity
    {
        public EventoId() : base() { }
        public EventoId(Guid id) : base(id) { }
    }
}
