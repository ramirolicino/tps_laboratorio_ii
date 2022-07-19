using System;
using System.Text;

namespace Biblioteca
{
    /// <summary>
    /// Identifica un jugador, incluye Interface de IJugador
    /// </summary>
    public class Jugador : IJugador
    {

        //ENUMERADOS
        public enum TipoPosiciones
        {
            Arquero, Defensor, Mediocampista, Delantero
        }


        //ATRIBUTOS
        protected string dni;
        protected string nombre;
        protected string apellido;
        protected DateTime fechaIngreso;
        protected TipoPosiciones posicion;


        //CONSTRUCTORES
        public Jugador()
        {

        }

        public Jugador(DateTime fechaIngreso, string dni, string nombre, string apellido, TipoPosiciones posicion)
        {
            this.fechaIngreso = fechaIngreso;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.posicion = posicion;
        }



        //PROPIEDADES
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { this.apellido = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { this.fechaIngreso = value; }
        }

        public TipoPosiciones Posicion
        {
            get { return posicion; }
            set { this.posicion = value; }
        }

        public int PermanenciaEnElClub
        {
            get { return CalcularPermanencia(); }
        }

        public int PartidosJugados
        {
            get { return CalcularPartidosJugados(); }
        }


        public float PromedioGolesxPartido
        {
            get { return CalcularPromedioGolesxPartido(); }
        }

        public int AsistenciasTotales
        {
            get { return CalcularAsistenciasTotales(); }
        }

        public int GolesTotales
        {
            get { return CalcularGolesTotales(); }
        }



        //METODOS
        public override string ToString()
        {
            return this.MostrarJugador();
        }

        public string MostrarJugador()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"JUGADOR: {nombre} {apellido}");
            sb.AppendLine($"FechaIngreso: {fechaIngreso.ToShortDateString()}");
            sb.AppendLine($"PermanenciaEnElClub: {PermanenciaEnElClub}");
            sb.AppendLine($"Posicion: {posicion}");
            sb.AppendLine($"PartidosJugados: {PartidosJugados}");
            sb.AppendLine($"GolesXPartido: {GolesTotales}");
            sb.AppendLine($"AsistenciasXPartido: {AsistenciasTotales}");
            sb.AppendLine($"PromedioGolesXPartido: {PromedioGolesxPartido:N2}");
            sb.AppendLine("**************************");

            return sb.ToString();
        }


        /// <summary>
        /// Calcula el tiempo en dias que permanece al club
        /// </summary>
        /// <returns></returns>
        public int CalcularPermanencia()
        {
            if (fechaIngreso > DateTime.Today)
            {
                return 0;
            }
            else
            {
                TimeSpan ts = DateTime.Today.Subtract(FechaIngreso);
                return (int)ts.TotalDays + 1;
            }
        }


        public int CalcularPartidosJugados()
        {
            Random random = new Random();
            int partidos;

            partidos = random.Next(0, 50);

            return partidos;
        }


        public int CalcularGolesTotales()
        {
            Random random = new Random();
            int asistencia = 0;

            if (PartidosJugados > 0 && PartidosJugados < 10)
            {
                asistencia = random.Next(0, 8);
            }
            else if (PartidosJugados > 10 && PartidosJugados < 30)
            {
                asistencia = random.Next(0, 30);
            }
            else if (PartidosJugados > 30 && PartidosJugados < 50)
            {
                asistencia = random.Next(0, 50);
            }

            return asistencia;
        }

        public int CalcularAsistenciasTotales()
        {
            Random random = new Random();
            int asistencia = 0;

            if (PartidosJugados > 0 && PartidosJugados < 10)
            {
                asistencia = random.Next(0, 8);
            }
            else if (PartidosJugados > 10 && PartidosJugados < 30)
            {
                asistencia = random.Next(0, 30);
            }
            else if (PartidosJugados > 30 && PartidosJugados < 50)
            {
                asistencia = random.Next(0, 50);
            }

            return asistencia;
        }

        public float CalcularPromedioGolesxPartido()
        {
            float prom = 0;

            if (PartidosJugados > 0)
            {
                prom = (float)GolesTotales / PartidosJugados;
            }

            return prom;
        }



        //SOBRECARGA
        
        /// <summary>
        /// Determina si un jugador es igual a otro por el DNI
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1 is not null && j2 is not null)
            {
                return j1.dni == j2.dni;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        /// <summary>
        /// Rescritura del metodo Equals(), reutilizando la sobrecarga del operador ==.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Jugador jugador = obj as Jugador;
            return jugador != null && this == jugador;
        }

        /// <summary>
        /// Rescritura del metodo GetHashCode()
        /// </summary>
        /// <returns>Devuelve el hashcode de la identificacion del bovino</returns>
        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }
    }
}
