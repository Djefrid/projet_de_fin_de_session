
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BibliothèqueDeClassenamespace;


namespace UnitTestProject3
{
    [TestClass]
    public class ClassCalculateur
    {
        Calculateur calc = new Calculateur();

        [TestMethod]
        public void TestMultiplier()
        {
           Assert.AreEqual(1375, calc.Multiplier(25, 55));
        }

        [TestMethod]
        public void TestDiviser()
        {
            int x = 1375;
            int y = 55;
            int resultat = calc.Diviser(x, y);

            Assert.AreEqual(25, resultat);
        }



    }
}
