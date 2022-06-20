using System;

namespace Biblioteca
{
    public interface IJugador
    {
        public DateTime FechaIngreso { get; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PermanenciaEnElClub { get; }
        public int PartidosJugados { get; }
        public int AsistenciasTotales { get; }
        public int GolesTotales { get; }
        public float PromedioGolesxPartido { get; }
        public int CalcularPermanencia();
        public int CalcularPartidosJugados();
        public int CalcularAsistenciasTotales();
        public int CalcularGolesTotales();
        public float CalcularPromedioGolesxPartido();
    }
}
