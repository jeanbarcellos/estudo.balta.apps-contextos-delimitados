using System;
using System.Linq.Expressions;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class OrganizadorScope
    {
        public static Expression<Func<Organizador, bool>> TodosAtivos =>
            x => x.Ativo == true;

        public static Expression<Func<Organizador, bool>> TodosAtivosAnoCorrente(int ano) =>
            x => x.Ativo == true && x.DataCadastro.Year == ano;
    }
}
