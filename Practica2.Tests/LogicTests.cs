using Ej.BLL;
using Ej.BLL.Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Practica2.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Logic_LanzarExcepcion_LanzaCorrecta()
        {
            // Arrange
            var logic = new Logic();

            // Act
            logic.LanzarExcepcion();
            // Assert lo maneja MSTest
        }

        [TestMethod]
        [ExpectedException(typeof(PresionasteBotonRojoException))]
        public void Logic_LanzarExcepcionPersonalizada_LanzaCorrecta()
        {
            // Arrange
            var logic = new Logic();

            // Act
            logic.LanzarExcepcionPersonalizada();
            // Assert lo maneja MSTest
        }
    }
}
