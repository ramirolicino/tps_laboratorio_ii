using System.Collections.Generic;
using System.Text;
using static Biblioteca.Jugador;

namespace Biblioteca
{
    public static class ClubBernaleza
    {
        private static List<Jugador> listaJugadores;


        //CTO
        static ClubBernaleza()
        {
            listaJugadores = new List<Jugador>();
        }

        //PROPIEDADES
        public static List<Jugador> ListaJugadores
        {
            get { return listaJugadores; }
            set { listaJugadores = value; }
        }


        //METODOS
        public static string MostrarJugadores()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CantidadJugadores: {ListaJugadores.Count}");
            foreach (Jugador j in ListaJugadores)
            {
                sb.AppendLine($"{j.ToString()}");
            }

            return sb.ToString();
        }


        /// <summary>
        /// Muestra los jugadores por posicion
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static List<Jugador> MostrarJugadoresXPosicion(TipoPosiciones tipo)
        {
            List<Jugador> jugadores = new List<Jugador>();

            foreach (Jugador j in jugadores)
            {
                if (j.Posicion == tipo)
                {
                    listaJugadores.Add(j);
                }
            }

            return jugadores;
        }

        /// <summary>
        /// Determina si un jugador esta activo 
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        private static bool JugadorActivo(Jugador jugador)
        {
            foreach (Jugador j in ListaJugadores)
            {
                if (j == jugador)
                {
                    return true;
                }
            }

            return false;
        }



        //SOBRECARGA

        /// <summary>
        /// Agrega un jugador a la lista
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        /// <exception cref="JugadorExcepcion"></exception>
        public static bool AgregarJugador(Jugador jugador)
        {
            if (jugador is not null)
            {
                if (!JugadorActivo(jugador))
                {
                    listaJugadores.Add(jugador);
                    return true;
                }
                else
                {
                    throw new JugadorExcepcion("Error! Ya existe el jugado");
                }
            }

            return false;
        }


        /// <summary>
        /// Modifica un jugador pasado por parametro
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        /// <exception cref="JugadorExcepcion"></exception>
        public static bool ModificarJugador(Jugador jugador)
        {
            if (jugador is not null)
            {
                if (JugadorActivo(jugador))
                {
                    for (int i = 0; i < listaJugadores.Count; i++)
                    {
                        if (listaJugadores[i] == jugador)
                        {
                            listaJugadores[i] = jugador;
                            return true;
                        }
                    }
                }
                else
                {
                    throw new JugadorExcepcion("Error! No se a podido modificar jugador");
                }
            }

            return false;
        }


        /// <summary>
        /// Elimina un jugador pasado por parametro
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        /// <exception cref="JugadorExcepcion"></exception>
        public static bool EliminarJugador(Jugador jugador)
        {
            if (jugador is not null)
            {
                if (JugadorActivo(jugador))
                {
                    listaJugadores.Remove(jugador);
                    return true;
                }
                else
                {
                    throw new JugadorExcepcion("Error! No se a podido eliminar jugador");
                }
            }

            return false;
        }
    }
}
