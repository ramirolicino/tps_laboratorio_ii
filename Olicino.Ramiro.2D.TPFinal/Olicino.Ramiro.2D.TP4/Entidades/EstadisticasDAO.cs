using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{

    /// <summary>
    /// Clase utilizada para la conexion a la Base de datos.
    /// </summary>
    public static class EstadisticasDAO
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;


        static EstadisticasDAO()
        {
            connectionString = @"Data Source=.\MSSQLSERVER04; Initial Catalog=ClubFutbol_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }



        //METODOS


        /// <summary>
        /// crea un registro de las estadisticas en la db 
        /// Si la estadística de la fecha ya está cargada, la actualiza.
        /// </summary>
        /// <param name="estadistica"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static bool AgregarEstadisticas(Estadisticas estadistica)
        {
            try
            {
                command.Parameters.Clear();

                command.CommandText = $"INSERT INTO Estadisticas (FECHA, CANT_JUGADORES, CANT_PARTIDOS, CANT_GOLES, CANT_ASISTENCIAS, PROM_GOLES, PROM_ASISTENCIAS, " +
                                      $"PORCENTAJE_ARQUERO, PORCENTAJE_DEFENSOR, PORCENTAJE_MEDIOCAMPISTA, PORCENTAJE_DELANTERO) " +
                                      $"VALUES (@fecha, @cantJug, @cantPart, @cantGoles, @cantAsis, @promGoles, @promAsis, @porArq, @porDef, @porMed, @porDel)";

                command.Parameters.AddWithValue("@fecha", estadistica.Fecha.ToShortDateString());
                command.Parameters.AddWithValue("@cantJug", estadistica.CantidadJugadores);
                command.Parameters.AddWithValue("@cantPart", estadistica.PartidosTotales);
                command.Parameters.AddWithValue("@cantGoles", estadistica.GolesTotales);
                command.Parameters.AddWithValue("@cantAsis", estadistica.AsistenciasTotales);
                command.Parameters.AddWithValue("@promGoles", estadistica.PromediosGolesTotales);
                command.Parameters.AddWithValue("@promAsis", estadistica.PromediosAsistenciasTotales);
                command.Parameters.AddWithValue("@porArq", estadistica.PorcentajeArqueros);
                command.Parameters.AddWithValue("@porDef", estadistica.PorcentajeDefensores);
                command.Parameters.AddWithValue("@porMed", estadistica.PorcentajeMediocampistas);
                command.Parameters.AddWithValue("@porDel", estadistica.PorcentajeDelanteros);

                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Debe ingresar una estadística válida");
            }
            catch (SqlException)
            {
                Actualizar(estadistica);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return false;
        }


        /// <summary>
        /// Actualiza el registro de estadistica de la base de datos con el id pasado por parámetro. 
        /// </summary>
        /// <param name="estadistica"></param>
        private static void Actualizar(Estadisticas estadistica)
        {

            command.Parameters.Clear();

            command.CommandText = $"UPDATE Estadisticas SET FECHA = @fecha, CANT_JUGADORES = @cantJug, CANT_PARTIDOS = @cantPart, CANT_GOLES = @cantGoles, CANT_ASISTENCIAS = @cantAsis, " +
                                  $"PROM_GOLES = @promGoles, PROM_ASISTENCIAS = @promAsis, " +
                                  $"PORCENTAJE_ARQUERO = @porArq, PORCENTAJE_DEFENSOR = @porDef, PORCENTAJE_MEDIOCAMPISTA = @porMed, PORCENTAJE_DELANTERO = @porDel) " +
                                  $"WHERE FECHA = @fecha";

            command.Parameters.AddWithValue("@fecha", estadistica.Fecha);
            command.Parameters.AddWithValue("@cantJug", estadistica.CantidadJugadores);
            command.Parameters.AddWithValue("@cantPart", estadistica.PartidosTotales);
            command.Parameters.AddWithValue("@cantGoles", estadistica.GolesTotales);
            command.Parameters.AddWithValue("@cantAsis", estadistica.AsistenciasTotales);
            command.Parameters.AddWithValue("@promGoles", estadistica.PromediosGolesTotales);
            command.Parameters.AddWithValue("@promAsis", estadistica.PromediosAsistenciasTotales);
            command.Parameters.AddWithValue("@porArq", estadistica.PorcentajeArqueros);
            command.Parameters.AddWithValue("@porDef", estadistica.PorcentajeDefensores);
            command.Parameters.AddWithValue("@porMed", estadistica.PorcentajeMediocampistas);
            command.Parameters.AddWithValue("@porDel", estadistica.PorcentajeDelanteros);

            connection.Open();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Muestra las estadisticas cargadas en la db
        /// </summary>
        /// <returns>Lista</returns>
        public static List<Estadisticas> CargarEstadisticas()
        {
            List<Estadisticas> estadisticas = new List<Estadisticas>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM Estadisticas";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    DateTime fecha = Convert.ToDateTime(dataReader["FECHA"].ToString());
                    int cantidadJugadores = int.Parse(dataReader["CANT_JUGADORES"].ToString());
                    int cantidadPartidos = int.Parse(dataReader["CANT_PARTIDOS"].ToString());
                    int cantidadGolesClub = int.Parse(dataReader["CANT_GOLES"].ToString());
                    int cantidadAsistenciasClub = int.Parse(dataReader["CANT_ASISTENCIAS"].ToString());
                    float promediosGolesTotales = float.Parse(dataReader["PROM_GOLES"].ToString());
                    float promedioAsistenciasTotales = float.Parse(dataReader["PROM_ASISTENCIAS"].ToString());
                    float porcentajeArq = float.Parse(dataReader["PORCENTAJE_ARQUERO"].ToString());
                    float porcentajeDef = float.Parse(dataReader["PORCENTAJE_DEFENSOR"].ToString());
                    float porcentajeMed = float.Parse(dataReader["PORCENTAJE_MEDIOCAMPISTA"].ToString());
                    float porcentajeDel = float.Parse(dataReader["PORCENTAJE_DELANTERO"].ToString());

                    estadisticas.Add(new Estadisticas(fecha, cantidadJugadores, cantidadPartidos, cantidadGolesClub, cantidadAsistenciasClub, promediosGolesTotales, promedioAsistenciasTotales, porcentajeArq, porcentajeDef, porcentajeMed, porcentajeDel));
                }

                return estadisticas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
