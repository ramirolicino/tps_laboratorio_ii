using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Biblioteca
{

    /// <summary>
    /// Clase utilizada para los archivos, ya sea guardar, leer  
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Archivos<T> where T : class
    {
        /// <summary>
        /// Leer datos desde un archivo json
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>Devuelve el archivo serialiazado al tipo de dato pasado como tipo genérico
        /// Si algo sale mal devuelve una excepción</returns>
        public static T CargarDatosJson(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return JsonSerializer.Deserialize<T>(streamReader.ReadToEnd());
                }
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("Directorio no encontrado", e);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("Archivo no encontrado", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error", e);
            }
        }

        /// <summary>
        /// Guarda datos de referencia a un archivo Json.
        /// Se manejan posibles excepciones.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        public static void GuardarDatosJson(string ruta, T datos)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
                    jsonOptions.WriteIndented = true;

                    string contenidoJson = JsonSerializer.Serialize(datos, jsonOptions);
                    streamWriter.Write(contenidoJson);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("Directorio no encontrado", e);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("Archivo no encontrado", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error", e);
            }
        }

        /// <summary>
        /// Guarda datos de referencia a un archivo Xml.
        /// Se manejan posibles excepciones.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        public static void GuardarDatosXml(string ruta, T datos)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("Directorio no encontrado", e);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("Archivo no encontrado", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error", e);
            }
        }

        /// <summary>
        /// Carga los datos de un archivo XML
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public static T CargarDatosXML(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    T objeto = xmlSerializer.Deserialize(streamReader) as T;
                    return objeto;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("Directorio no encontrado", e);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("Archivo no encontrado", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error", e);
            }
        }


        /// <summary>
        /// Guardar datos e referencia a un archivo Txt como string.
        /// Se manejan posibles excepciones.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        public static void GuardarDatosTxt(string ruta, string datos)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    streamWriter.Write(datos);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("Directorio no encontrado", e);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("Archivo no encontrado", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error", e);
            }
        }

        /// <summary>
        /// Valida que el archivo existe
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>Devuelve true si existe y lanza una excepcion sino existe</returns>
        public static bool ValidarSiExisteElArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                return true;
            }

            throw new FileNotFoundException();
        }
    }
}
