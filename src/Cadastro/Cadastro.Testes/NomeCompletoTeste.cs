using Cadastro.Core.Domain.Model.Organizadores;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cadastro.Testes
{
    [TestClass]
    public class NomeCompletoTeste
    {
        [TestMethod]
        public void TesteNomeCompleto()
        {
            NomeCompleto nome = new NomeCompleto("Jean", "Barcellos");
            Assert.AreEqual("Jean Barcellos", nome.EscreverNome());
        }
    }
}
