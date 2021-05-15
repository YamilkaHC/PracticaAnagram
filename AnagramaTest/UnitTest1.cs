using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrama;


namespace AnagramaTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow("Roma", "mora", true)]
        [DataRow("Roma", "amor", true)]
        [DataRow("Romo", "moro", false)]
        [DataRow("Pepe", "pepe", true)]
        [DataRow("pepa", "pape", true)]

        [TestMethod]
        public void TestMethod1(string word1, string word2, bool esperado)
        {
            bool resultado = Program.Anagrama.FuncionAnagrama(word1, word2);

            Assert.AreEqual(resultado, esperado);

        }
    }
}
