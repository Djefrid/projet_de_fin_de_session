using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliothequeDeClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeDeClasse.Tests
{
    [TestClass()]
    public class CalculateurTests
    {
        Calculateur Calc = new Calculateur();

        [TestMethod]
        public void TesterDivision()
        {
            // Arrange
            int x = 25;
            int y = 5;

            // Act
            int resultat = Calc.Diviser(x, y);

            // Assert
            Assert.AreEqual(5, resultat);
        }

        [TestMethod]
        public void TesterMultiplication()
        {
            // Arrange
            int x = 25;
            int y = 55;

            // Act
            int resultat = Calc.Multiplier(x, y);

            // Assert
            Assert.AreEqual(1375, resultat);
        }

        [TestMethod]
        public void TesterExposant()
        {
            // Arrange
            double x = 5;
            double y = 3;

            // Act
            double resultat = Calc.Exposant(x, y);

            // Assert
            Assert.AreEqual(125, resultat);
        }

        [TestMethod]
        public void TesterLogarithme()
        {
            // Arrange
            double x = 100;

            // Act
            double resultat = Calc.Logarithme(x);

            // Assert
            Assert.AreEqual(2, resultat);
        }
    }
}