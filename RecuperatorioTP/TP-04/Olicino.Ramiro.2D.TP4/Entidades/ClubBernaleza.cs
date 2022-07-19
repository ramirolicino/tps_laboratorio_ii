using System.Collections.Generic;
using System.Text;
using static Entidades.Jugador;

namespace Entidades
{
    //DELEGADO
    public delegate void NotificadorModificacion();


    public static class ClubBernaleza
    {

        private static List<Jugador> listaJugadoresActivos;
        private static List<Jugador> listaJugadoresInactivos;

        //Creo el evento
        public static event NotificadorModificacion JugadorAlterado;


        /// <summary>
        /// Cargo las listas con los datos de la db
        /// </summary>
        static ClubBernaleza()
        {
            listaJugadoresActivos = JugadorDAO.CargaJugadores(1);
            listaJugadoresInactivos = JugadorDAO.CargaJugadores(0);
        }



        //PROPIEDADES

        /// <summary>
        /// Muestra Listado de jugadores
        /// </summary>
        public static List<Jugador> ListaJugadoresActivos
        {
            get { return listaJugadoresActivos; }
            set { listaJugadoresActivos = value; }
        }

        public static List<Jugador> ListaJugadoresInactivos
        {
            get
            { return listaJugadoresInactivos; }

            set
            {
                listaJugadoresInactivos = value;
            }
        }


        //METODOS


        /// <summary>
        /// Retorna el puesto de tipo TipoPosiciones en string
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static string CargaPuestoString(TipoPosiciones tipo)
        {
            switch (tipo)
            {
                case TipoPosiciones.Arquero:
                    return "Arquero";

                case TipoPosiciones.Defensor:
                    return "Defensor";

                case TipoPosiciones.Mediocampista:
                    return "Mediocampista";

                case TipoPosiciones.Delantero:
                    return "Delantero";

                default:
                    return "X";
            }
        }


        /// <summary>
        /// Muestra la lista de todos los jugadores
        /// </summary>
        /// <returns></returns>
        public static string MostrarJugadores()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CantidadJugadores: {ListaJugadoresActivos.Count}");
            foreach (Jugador j in ListaJugadoresActivos)
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
        public static List<Jugador> MostrarJugadoresXPosicion(Jugador.TipoPosiciones tipo)
        {
            List<Jugador> jugadores = new List<Jugador>();

            foreach (Jugador j in jugadores)
            {
                if (j.Posision == CargaPuestoString(tipo))
                {
                    listaJugadoresActivos.Add(j);
                }
            }

            return jugadores;
        }

        /// <summary>
        /// Determina si un jugador pertenece a la lista
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        private static bool JugadorActivo(Jugador jugador)
        {
            foreach (Jugador j in ListaJugadoresActivos)
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
        /// Agerga un jugador a la lista, utilidando operador == 
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
                    if (JugadorDAO.Agregar(jugador) && JugadorAlterado is not null)
                    {
                        ListaJugadoresActivos = JugadorDAO.CargaJugadores(1);
                        //ActualizarJugadoresActivos();
                    }
                    return true;
                }
                else
                {
                    throw new JugadorExcepcion("Error! Jugador ya existente");
                }
            }
            return false;
        }

        /// <summary>
        /// Da de baja (no elimina) el jugador seleccionado de la lista
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static bool BajaJugador(Jugador jugador)
        {
            if (jugador is not null)
            {
                if (JugadorActivo(jugador))
                {
                    jugador.Estado = false;
                    if (JugadorDAO.EstadoJugador(jugador) && JugadorAlterado is not null)
                    {
                        ActualizarJugadoresActivos();
                    }

                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Elimina jugador seleccionado de la lista
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static bool EliminarJugador(Jugador jugador)
        {
            if (jugador is not null)
            {
                if (JugadorActivo(jugador))
                {
                    if (JugadorDAO.Eliminar(jugador.ID) && JugadorAlterado is not null)
                    {
                        ActualizarJugadoresActivos();
                    }

                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Modifica al jugador seleccionado
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static bool ModificarJugador(Jugador jugador)
        {
            if (jugador is not null)
            {
                if (JugadorDAO.Modificar(jugador) && JugadorAlterado is not null)
                {
                    ActualizarJugadoresActivos();
                }

                return true;
            }
            return false;
        }


        /// <summary>
        /// Actualiza la lista de jugadores desde la base de datos y lanza el evento.
        /// /// </summary>
        public static void ActualizarJugadoresActivos()
        {
            ListaJugadoresActivos = JugadorDAO.CargaJugadores(1);
            JugadorAlterado.Invoke();
        }

        /// <summary>
        /// Actualiza la lista de jugadores desde la base de datos y lanza el evento.
        /// /// </summary>
        public static void ActualizarJugadoresInactivos()
        {
            ListaJugadoresInactivos = JugadorDAO.CargaJugadores(0);
            JugadorAlterado.Invoke();
        }
    }
}
