using System;
using System.Text;

namespace Entidades
{
    public class Jugador : IJugador
    {
        //ENUMERADO
        public enum TipoPosiciones
        {
            Arquero = 1, Defensor = 2, Mediocampista = 3, Delantero = 4
        }


        //ATRIBUTOS
        private int id;
        private bool estado;
        private string dni;
        private string nombre;
        private string apellido;
        private DateTime fechaIngreso;
        private string posicion;


        //CONSTRUCTORES
        public Jugador()
        {

        }

        public Jugador(DateTime fechaIngreso, string dni, string nombre, string apellido, string posicion, bool estaActivo)
            : this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaIngreso = fechaIngreso;
            this.posicion = posicion;
            this.estado = estaActivo;
        }

        public Jugador(int id, DateTime fechaIngreso, string dni, string nombre, string apellido, string posicion, bool estaActivo)
            : this(fechaIngreso, dni, nombre, apellido, posicion, estaActivo)
        {
            this.id = id;
        }




        //PROPIEDADES

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

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

        public string Posision
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
        public int CalcularPermanencia()
        {
            TimeSpan ts = DateTime.Today.Subtract(FechaIngreso);
            return (int)ts.TotalDays + 1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Estado)
            {
                sb.AppendLine("JUGADOR ACTIVO");
            }
            else
            {
                sb.AppendLine("JUGADOR INACTIVO");
            }
            sb.AppendLine($"ID: {ID}");
            sb.AppendLine($"JUGADOR: {Nombre} {Apellido}");
            sb.AppendLine($"FechaIngreso: {FechaIngreso.ToShortDateString()}");
            sb.AppendLine($"PermanenciaEnElClub: {PermanenciaEnElClub}");
            sb.AppendLine($"Posicion: {Posision}");
            sb.AppendLine($"PartidosJugados: {PartidosJugados}");
            sb.AppendLine($"GolesXPartido: {GolesTotales}");
            sb.AppendLine($"AsistenciasXPartido: {AsistenciasTotales}");
            sb.AppendLine($"PromedioGolesXPartido: {PromedioGolesxPartido:N2}");
            sb.AppendLine("**************************");

            return sb.ToString();
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
        /// determina si dos jugadores son iguales por su ID
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
