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
    public class ExtensionesStringTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LanzarSiNoEsTodaNumerica_CuandoEsCadenaNoNumerica_Lanza()
        {
            // Arrange
            var cadenaNoNumerica = "12345!!dd@@c";

            // Act
            cadenaNoNumerica.LanzarSiNoEsTodaNumerica();

            // Assert lo maneja MSTest
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LanzarSiEsCadenaVaciaONula_CuandoEsCadenaVacia_Lanza()
        {
            // Arrange
            string cadenaNoNumerica = string.Empty;

            // Act
            cadenaNoNumerica.LanzarSiEsCadenaVaciaONula();

            // Assert lo maneja MSTest
        }
    }
}
