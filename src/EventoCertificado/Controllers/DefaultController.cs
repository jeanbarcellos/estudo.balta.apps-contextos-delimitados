using Cadastro.Core.Application.Organizadores;
using Emissao.Core.Application.Certificados;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EventoCertificado.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IServicoEvento _servicoEvento;
        private readonly IServicoCertificado _servicoCertificado;

        public DefaultController(IServicoEvento servicoEvento, IServicoCertificado servicoCertificado)
        {
            _servicoEvento = servicoEvento;
            _servicoCertificado = servicoCertificado;
        }

        public IActionResult Index(Guid guid, string cpf)
        {
            var evento = _servicoEvento.RecuperarEvento(new Cadastro.Core.Domain.Model.Eventos.EventoId(guid));
            var certificado = _servicoCertificado.EmitirCertificado(new Emissao.Core.Domain.Model.Certificados.EventoId(guid), cpf);

            return View();
        }
    }
}
