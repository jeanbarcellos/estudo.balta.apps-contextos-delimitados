using System.Collections.Generic;

namespace Cadastro.Core.Domain.Model.Eventos
{
    class Evento
    {
        public EventoId EventoId { get; private set; }
        public OrganizadorId OrganizadorId { get; private set; }
        public string Nome { get; set; }
        public ICollection<Participante> Participantes { get; private set; }
        public Periodo PeriodoEntregaCertificado { get; private set; }


        public Evento() { }

        public Evento(EventoId eventoId, OrganizadorId organizadorId)
        {
            EventoId = eventoId;
            OrganizadorId = organizadorId;

            Participantes = new List<Participante>();
        }

        public void AdicionarParticipante(Participante participante)
        {
            Participantes.Add(participante);
        }

        public void AtualizarListaDeParticipantes(ICollection<Participante> participantes)
        {
            Participantes.Clear();
            Participantes = participantes;
        }
    }
}
