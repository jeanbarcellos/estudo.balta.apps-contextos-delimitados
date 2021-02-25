﻿using System;

namespace Cadastro.Core.Domain.Model.Eventos
{
    public class Periodo
    {
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public Periodo(DateTime dataInicial, int diasValidos)
        {
            DataInicial = dataInicial;
            DataFinal = DataInicial.AddDays(diasValidos);
        }
    }
}