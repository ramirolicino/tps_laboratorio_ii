using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Entidades.Jugador;

namespace Entidades
{

    /// <summary>
    /// Clase utilizada para la conexion a la Base de datos.
    /// </summary>
    public static class JugadorDAO
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        /// <summary>
        /// Estableze la conexion a la db
        /// </summary>
        static JugadorDAO()
        {
            connectionString = @"Data Source=.\MSSQLSERVER04; Initial Catalog=ClubFutbol_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }


        //METODOS

        /// <summary>
        /// Carga un jugador de la db pasado por id
        /// </summary>
        /// <param name="idJugador"></param>
        /// <returns></returns>
        public static Jugador CargarJugadorXid(int IDjugador)
        {
            Jugador jugador = null;

            try
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Jugadores      WHERE ID = @id;";

                command.Parameters.AddWithValue("@id", IDjugador);

                connection.Open();
                command.ExecuteNonQuery();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID"].ToString());
                    string dni = dataReader["DNI"].ToString();
                    string nombre = dataReader["NOMBRE"].ToString();
                    string apellido = dataReader["APELLIDO"].ToString();
                    DateTime fecha = Convert.ToDateTime(dataReader["FECHA_INGRESO"].ToString());
                    TipoPosiciones posicion = (TipoPosiciones)Enum.Parse(typeof(Jugador.TipoPosiciones), dataReader["POSICION"].ToString());
                    bool estaActivo = bool.Parse(dataReader["ESTA_ACTIVO"].ToString());

                    jugador = new Jugador(id, fecha, dni, nombre, apellido, ClubBernaleza.CargaPuestoString(posicion), estaActivo);
                }

                if (jugador is not null)
                {
                    return jugador;
                }
                else
                {
                    throw new JugadorExcepcion("No se encuentra el jugador elegido");
                }
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



        /// <summary>
        /// Muestra todos los jugadores de la db indicando su estado (activo/inactivo)
        /// </summary>
        /// <param name="indicar"></param>
        /// <returns></returns>
        public static List<Jugador> CargaJugadores(int indicar)
        {
            List<Jugador> jugadores = new List<Jugador>();
            try
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Jugadores      WHERE ESTA_ACTIVO = @activo;";
                command.Parameters.AddWithValue("@activo", indicar);

                connection.Open();
                command.ExecuteNonQuery();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID"].ToString());
                    string dni = dataReader["DNI"].ToString();
                    string nombre = dataReader["NOMBRE"].ToString();
                    string apellido = dataReader["APELLIDO"].ToString();
                    DateTime fecha = Convert.ToDateTime(dataReader["FECHA_INGRESO"].ToString());
                    string posicion = dataReader["POSICION"].ToString();
                    bool estaActivo = bool.Parse(dataReader["ESTA_ACTIVO"].ToString());

                    jugadores.Add(new Jugador(id, fecha, dni, nombre, apellido, posicion, estaActivo));
                }

                return jugadores;
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


        /// <summary>
        /// Crea un registro en la db, segun el jugador pasado por id
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="JugadorExcepcion"></exception>
        public static bool Agregar(Jugador jugador)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO Jugadores (DNI, NOMBRE, APELLIDO, FECHA_INGRESO, POSICION, ESTA_ACTIVO)  VALUES (@dni, @nombre, @apellido, @fecha, @posicion, @activo)";
                command.Parameters.AddWithValue("@dni", jugador.Dni);
                command.Parameters.AddWithValue("@nombre", jugador.Nombre);
                command.Parameters.AddWithValue("@apellido", jugador.Apellido);
                command.Parameters.AddWithValue("@fecha", jugador.FechaIngreso);
                command.Parameters.AddWithValue("@posicion", jugador.Posision);
                command.Parameters.AddWithValue("@activo", jugador.Estado);

                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Debe ingresar un Jugador válido");
            }
            catch (SqlException e) when (e.Number == 2627)
            {
                throw new JugadorExcepcion("Jugador ya pertenece a la lista");
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

        /// <summary>
        /// Modifica el registro de un jugador de la db con el id pasado por parámetro
        /// </summary>
        /// <param name="codigoBovino"></param>
        /// <returns>Objeto bovino con datos de la base de datos</returns>
        public static bool Modificar(Jugador jugador)
        {
            try
            {
                if (CargarJugadorXid(jugador.ID) is not null)
                {
                    command.Parameters.Clear();

                    command.CommandText = $"UPDATE Jugadores SET DNI = @dni, NOMBRE = @nombre, APELLIDO = @apellido, POSICION = @posicion " +
                                          $"WHERE ID = @id";

                    command.Parameters.AddWithValue("@id", jugador.ID);
                    command.Parameters.AddWithValue("@dni", jugador.Dni);
                    command.Parameters.AddWithValue("@nombre", jugador.Nombre);
                    command.Parameters.AddWithValue("@apellido", jugador.Apellido);
                    command.Parameters.AddWithValue("@posicion", jugador.Posision);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }

                return false;
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



        /// <summary>
        /// Establece el estado de un jugador (activo/inactivo)
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static bool EstadoJugador(Jugador jugador)
        {
            try
            {
                if (CargarJugadorXid(jugador.ID) is not null)
                {
                    command.Parameters.Clear();
                    command.CommandText = $"UPDATE Jugadores SET ESTA_ACTIVO = @activo   WHERE ID = @id";
                    command.Parameters.AddWithValue("@id", jugador.ID);
                    command.Parameters.AddWithValue("@activo", jugador.Estado);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }

                return false;
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


        /// <summary>
        /// Elimina un registro de un jugador de la db, según el id identificado por parámetro
        /// </summary>
        /// <param name="idJugador"></param>
        public static bool Eliminar(int idJugador)
        {
            try
            {
                if (CargarJugadorXid(idJugador) is not null)
                {
                    command.Parameters.Clear();
                    command.CommandText = $"DELETE FROM Jugadores WHERE ID=@id";
                    command.Parameters.AddWithValue("@id", idJugador);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }

                return false;
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
