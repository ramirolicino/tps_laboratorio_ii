using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestClubFutbol
    {
        [TestMethod]
        public void TestIndicarSiSeIngersanJugadoresAlClub_RecibeLosDatos_DevuelveCantidadJugadores()
        {
            CargaDatos.Datos();

            int cant = ClubBernaleza.ListaJugadores.Count;
            int expected = 15;

            Assert.AreEqual(expected, cant);
        }


        [TestMethod]
        public void TestIndicarJugadorActivo_RecibeLosDatos_DevuelveTrueSiEsActivo()
        {
            Random random = new();
            CargaDatos.Datos();
            Jugador jugador = new Jugador(new DateTime(2020, 08, 17), "1111111111", "Roman", "Riquelme", Jugador.TipoPosiciones.Arquero);

            bool jugadorTrue = ClubBernaleza.AgregarJugador(jugador);


            Assert.IsTrue(jugadorTrue);
        }


    }
}
