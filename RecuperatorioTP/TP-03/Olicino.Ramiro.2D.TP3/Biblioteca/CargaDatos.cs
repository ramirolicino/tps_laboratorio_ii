using System;
using System.Collections.Generic;
using System.IO;

namespace Biblioteca
{
    public static class CargaDatos
    {

        public static void Datos()
        {
            Random random = new();

            //JUGADORES
            List<Jugador> ListaJugadores = new List<Jugador>()
            {
                new Jugador(new DateTime(random.Next(2015,2022), 05, random.Next(1,30)), "41235224", "Roman", "Riquelme", Jugador.TipoPosiciones.Arquero),
                new Jugador(new DateTime(random.Next(2015,2022), 07, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Ramiro", "Gonzales", Jugador.TipoPosiciones.Arquero),
                new Jugador(new DateTime(random.Next(2015,2022), 03, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Julian", "Pisco", Jugador.TipoPosiciones.Defensor),
                new Jugador(new DateTime(random.Next(2015,2022), 03, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Oscar", "Picho", Jugador.TipoPosiciones.Defensor),
                new Jugador(new DateTime(random.Next(2015,2022), 03, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Oscar", "Picho", Jugador.TipoPosiciones.Defensor),
                new Jugador(new DateTime(random.Next(2015,2022), 08, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Carlos", "Tevez", Jugador.TipoPosiciones.Defensor),
                new Jugador(new DateTime(random.Next(2015,2022), 05, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Agustin", "Olicino", Jugador.TipoPosiciones.Mediocampista),
                new Jugador(new DateTime(random.Next(2015,2022), 05, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Marcos", "Villa", Jugador.TipoPosiciones.Mediocampista),
                new Jugador(new DateTime(random.Next(2015,2022), 09, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Carlos", "Vazques", Jugador.TipoPosiciones.Mediocampista),
                new Jugador(new DateTime(random.Next(2015,2022), 11, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Martin", "Gomez", Jugador.TipoPosiciones.Mediocampista),
                new Jugador(new DateTime(random.Next(2015,2022), 12, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Ignacio", "Gomez", Jugador.TipoPosiciones.Mediocampista),
                new Jugador(new DateTime(random.Next(2015,2022), 05, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Ignacio", "De la Cruz", Jugador.TipoPosiciones.Delantero),
                new Jugador(new DateTime(random.Next(2015,2022), 05, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Matias", "Cholio", Jugador.TipoPosiciones.Delantero),
                new Jugador(new DateTime(random.Next(2015,2022), 03, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Imanol", "Dangeli", Jugador.TipoPosiciones.Delantero),
                new Jugador(new DateTime(random.Next(2015,2022), 02, random.Next(1,30)), random.Next(200000000,500000000).ToString(), "Carlos", "Gonzales", Jugador.TipoPosiciones.Delantero)
            };

            //AGREGO J AL CLUB
            foreach (Jugador j in ListaJugadores)
            {
                ClubBernaleza.AgregarJugador(j);
            }


            //CREO ARCHIVOS
            //RUTA
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaJson = Path.Combine(rutaEscritorio, "ClubBernaleza.json");
            string rutaXML = Path.Combine(rutaEscritorio, "ClubBernaleza.xml");
            string rutaTXT = Path.Combine(rutaEscritorio, "ClubBernaleza.txt");


            //GUARDO JSON
            try
            {
                Archivos<List<Jugador>>.GuardarDatosJson(rutaJson, ClubBernaleza.ListaJugadores);
                Console.WriteLine("Guardado correctamente .json");
            }
            catch (Exception)
            {
                Console.WriteLine("Error...");
            }

            //GUARDO XML
            try
            {
                Archivos<List<Jugador>>.GuardarDatosXml(rutaXML, ClubBernaleza.ListaJugadores);
                Console.WriteLine("Guardado correctamente .xml");
            }
            catch (Exception)
            {
                Console.WriteLine("Error...");
            }

            //GUARDO TXT
            try
            {
                Archivos<List<Jugador>>.GuardarDatosXml(rutaTXT, ClubBernaleza.ListaJugadores);
                Console.WriteLine("Guardado correctamente .txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
