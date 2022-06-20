using System;
using System.Text;

namespace Entidades
{
    public class Estadisticas
    {
        private DateTime fecha;
        private int cantidadJugadores;
        private int cantidadPartidos;
        private int cantidadGolesClub;
        private int cantidadAsistenciasClub;
        private float promediosGolesTotales;
        private float promedioAsistenciasTotales;
        private float porcentajeArqueros;
        private float porcentajeDefensores;
        private float porcentajeMediocampistas;
        private float porcentajeDelanteros;


        //CONSTRUCTORES
        public Estadisticas()
        {
        }


        public Estadisticas(DateTime fecha, int cantidadJugadores, int cantidadPartidos, int cantidadGolesClub, int cantidadAsistenciasClub,
                            float promediosGolesTotales, float promedioAsistenciasTotales,
                            float porcentajeArqueros, float porcentajeDefensores, float porcentajeMediocampistas, float porcentajeDelanteros)
            : this()
        {
            this.fecha = DateTime.Today;
            this.cantidadJugadores = cantidadJugadores;
            this.cantidadPartidos = cantidadPartidos;
            this.cantidadGolesClub = cantidadGolesClub;
            this.cantidadAsistenciasClub = cantidadAsistenciasClub;
            this.promediosGolesTotales = promediosGolesTotales;
            this.promedioAsistenciasTotales = promedioAsistenciasTotales;
            this.porcentajeArqueros = porcentajeArqueros;
            this.porcentajeDefensores = porcentajeDefensores;
            this.porcentajeMediocampistas = porcentajeMediocampistas;
            this.porcentajeDelanteros = porcentajeDelanteros;
        }



        //PROPIEDADES
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int CantidadJugadores
        {
            get { return Jugadores(); }
            set { cantidadJugadores = value; }
        }


        public int PartidosTotales
        {
            get { return TotalPartidos(); }
            set { this.cantidadPartidos = value; }
        }

        public int GolesTotales
        {
            get { return TotalGoles(); }
            set { this.cantidadGolesClub = value; }
        }


        public int AsistenciasTotales
        {
            get { return TotalAsistencias(); }
            set { this.cantidadAsistenciasClub = value; }
        }

        public float PromediosGolesTotales
        {
            get { return PromedioGolesClub(); }
            set { this.promediosGolesTotales = value; }
        }

        public float PromediosAsistenciasTotales
        {
            get { return PromedioAsistenciasClub(); }
            set { this.promedioAsistenciasTotales = value; }
        }


        public float PorcentajeArqueros
        {
            get { return CalcularPorcentajePorPosicion(ClubBernaleza.CargaPuestoString(Jugador.TipoPosiciones.Arquero)); }
            set { porcentajeArqueros = value; }
        }


        public float PorcentajeDefensores
        {
            get { return CalcularPorcentajePorPosicion(ClubBernaleza.CargaPuestoString(Jugador.TipoPosiciones.Defensor)); }
            set { porcentajeDefensores = value; }
        }


        public float PorcentajeMediocampistas
        {
            get { return CalcularPorcentajePorPosicion(ClubBernaleza.CargaPuestoString(Jugador.TipoPosiciones.Mediocampista)); }
            set { porcentajeMediocampistas = value; }
        }


        public float PorcentajeDelanteros
        {
            get { return CalcularPorcentajePorPosicion(ClubBernaleza.CargaPuestoString(Jugador.TipoPosiciones.Delantero)); }
            set { porcentajeDelanteros = value; }
        }




        //METODOS



        /// <summary>
        /// Retorna la cantidad de jugadores
        /// </summary>
        /// <returns></returns>
        private int Jugadores()
        {
            return ClubBernaleza.ListaJugadoresActivos.Count;
        }

        private int TotalPartidos()
        {
            Jugador jugador = new Jugador();
            int total = 0;

            foreach (Jugador j in ClubBernaleza.ListaJugadoresActivos)
            {
                total += jugador.PartidosJugados;
            }

            return total;
        }

        private int TotalGoles()
        {
            Jugador jugador = new Jugador();
            int total = 0;

            foreach (Jugador j in ClubBernaleza.ListaJugadoresActivos)
            {
                total += jugador.GolesTotales;
            }

            return total;
        }

        private int TotalAsistencias()
        {
            Jugador jugador = new Jugador();
            int total = 0;

            foreach (Jugador j in ClubBernaleza.ListaJugadoresActivos)
            {
                total += jugador.AsistenciasTotales;
            }

            return total;
        }

        private float PromedioGolesClub()
        {
            float prom = 0;

            if (PartidosTotales > 0)
            {
                prom = (float)GolesTotales / PartidosTotales;
            }

            return prom;
        }

        private float PromedioAsistenciasClub()
        {
            float prom = 0;

            if (PartidosTotales > 0)
            {
                prom = (float)AsistenciasTotales / PartidosTotales;
            }

            return prom;
        }


        private float CalcularPorcentajePorPosicion(string tipo)
        {
            int total = ClubBernaleza.ListaJugadoresActivos.Count;
            int cant = 0;

            foreach (Jugador j in ClubBernaleza.ListaJugadoresActivos)
            {
                if (j.Posision == tipo)
                {
                    cant++;
                }
            }
            return (float)cant * 100 / total;
        }



        public override string ToString()
        {
            return this.MostrarEstadisticas();
        }

        public string MostrarEstadisticas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Fecha.ToShortDateString()}");
            sb.AppendLine($"----------");
            sb.AppendLine($"\nTotalJugadores: {CantidadJugadores} \n");
            sb.AppendLine($"******************************\n");
            sb.AppendLine($"TotalPartidos: {PartidosTotales}");
            sb.AppendLine($"TotalGolesClub: {GolesTotales}");
            sb.AppendLine($"TotalAsistenciasClub: {AsistenciasTotales} \n");
            sb.AppendLine($"TotalPromediosGolesClub: {PromediosGolesTotales:N2}");
            sb.AppendLine($"TotalPromediosAsistenciasClub: {PromediosAsistenciasTotales:N2} \n");
            sb.AppendLine($"******************************\n");
            sb.AppendLine($"PorcentajeArqueros: {PorcentajeArqueros:N2}%");
            sb.AppendLine($"PorcentajeDefensores: {PorcentajeDefensores:N2}%");
            sb.AppendLine($"PorcentajeMediocampista: {PorcentajeMediocampistas:N2}%");
            sb.AppendLine($"PorcentajeDelantero: {PorcentajeDelanteros:N2}%");

            return sb.ToString();
        }
    }
}
