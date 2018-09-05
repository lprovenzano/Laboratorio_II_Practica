using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases;
using System.Collections.Generic;

namespace CentralitaTest
{
    [TestClass]
    public class TestPrincipal
    {
        [TestMethod]
        public void ValidarListaDeLlamadas()
        {
            //Arrange
            Centralita c = new Centralita("La centralita de ejemplo");

            //Act
            //-- No hay, pregunto directo si es no es nula. Si no lo es, true, pasa test, si lo es (no se creo) false.

            //Assert
            Assert.IsNotNull(c.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void ValidarCentralitaExceptionLocal()
        {
            //Arrange
            Centralita c = new Centralita("Fede Center");
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 30, "Rosario", 2.65f);
            
            //Act
            c = c + l1;
            c = c + l2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void ValidarCentralitaExceptionProvincial()
        {
            //Arrange
            Centralita c = new Centralita("Fede Center");
            Provincial l1 = new Provincial("Avellaneda",Provincial.Franja.Franja_1, 23f, "Cancún");
            Provincial l2 = new Provincial("Avellaneda", Provincial.Franja.Franja_1, 23f, "Cancún");

            //Act
            c = c + l1;
            c = c + l2;
        }

        [TestMethod]
        public void ValidarLlamadasIguales()
        {
            //Arrange
            Centralita c = new Centralita("Fede Center");
            Provincial l1 = new Provincial("Avellaneda", Provincial.Franja.Franja_1, 23f, "Cancún");
            Provincial l2 = new Provincial("Avellaneda", Provincial.Franja.Franja_1, 23f, "Cancún");
            Local l3 = new Local("Avellaneda", 30, "Cancún", 2.65f);
            Local l4 = new Local("Avellaneda", 30, "Cancún", 2.65f);

            //Act
            bool comp1 = l1 == l2;
            bool comp2 = l3 == l4;

            //Assert
            Assert.AreEqual(comp1, comp2);
        }
    }
}
