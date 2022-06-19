using System;
using System.Text;
using static Biblioteca.Jugador;

namespace Biblioteca
{
    public class Estadisticas
    {
        //ATRIBUTOS 
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


        //CTO
        public Estadisticas()
        {

        }


        //PROPIEDADES
        public DateTime Fecha { get => fecha; set => fecha = value; }

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
            get { return CalcularPorcentajePorPosicion(TipoPosiciones.Arquero); }
            set { porcentajeArqueros = value; }
        }


        public float PorcentajeDefensores
        {
            get { return CalcularPorcentajePorPosicion(TipoPosiciones.Defensor); }
            set { porcentajeDefensores = value; }
        }


        public float PorcentajeMediocampistas
        {
            get { return CalcularPorcentajePorPosicion(TipoPosiciones.Mediocampista); }
            set { porcentajeMediocampistas = value; }
        }


        public float PorcentajeDelanteros
        {
            get { return CalcularPorcentajePorPosicion(TipoPosiciones.Delantero); }
            set { porcentajeDelanteros = value; }
        }




        //METODOS

        /// <summary>
        /// Lista de jugadores
        /// </summary>
        /// <returns></returns>
        private int Jugadores()
        {
            return ClubBernaleza.ListaJugadores.Count;
        }

        private int TotalPartidos()
        {
            Jugador jugador = new Jugador();
            int total = 0;

            foreach (Jugador j in ClubBernaleza.ListaJugadores)
            {
                total += jugador.PartidosJugados;
            }

            return total;
        }

        private int TotalGoles()
        {
            Jugador jugador = new Jugador();
            int total = 0;

            foreach (Jugador j in ClubBernaleza.ListaJugadores)
            {
                total += jugador.GolesTotales;
            }

            return total;
        }

        private int TotalAsistencias()
        {
            Jugador jugador = new Jugador();
            int total = 0;

            foreach (Jugador j in ClubBernaleza.ListaJugadores)
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


        private float CalcularPorcentajePorPosicion(Jugador.TipoPosiciones tipo)
        {
            int total = ClubBernaleza.ListaJugadores.Count;
            int cant = 0;

            foreach (Jugador j in ClubBernaleza.ListaJugadores)
            {
                if (j.Posicion == tipo)
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
