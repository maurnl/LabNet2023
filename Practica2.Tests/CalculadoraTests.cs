using Ej.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Tests
{
    [TestClass]
    public class CalculadoraTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir_CuandoDivisorEsCero_Lanza()
        {
            // Arrange
            var calcu = new Calculadora();

            // Act
            calcu.Dividir(10, 0);

            // Assert lo maneja MSTest
        }

        [TestMethod]
        [DataRow(10, 5, 2)]
        [DataRow(25, 5, 5)]
        [DataRow(36, 6, 6)]
        public void Dividir_ConValoresCorrectos_Funciona(int dividendo, int divisor, int resultadoEsperado)
        {
            // Arrange
            var calcu = new Calculadora();

            // Act
            int resultadoObtenido = calcu.Dividir(dividendo, divisor);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
