using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nucleo.Core;

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
