using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestClubFutbol
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void AgegarJugadorSQL_RecibeJugador_RetornaTrueSiAgrego()
        {
            Jugador jugador = new Jugador(DateTime.Today, "111111111", "Jose", "Luis", "Delantero", true);

            bool expected = ClubBernaleza.AgregarJugador(jugador);

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void CantidadJugadorSQL_RecibeListaJugadores_RetornaCantidad()
        {
            int cantidadJugadores = ClubBernaleza.ListaJugadoresActivos.Count;
            int expected = 33;

            Assert.AreEqual(expected, cantidadJugadores);
        }
    }
}
