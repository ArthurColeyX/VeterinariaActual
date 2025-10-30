using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Veterinaria
{
    public static class ConexionMongo
    {
        // 🔗 Cadena de conexión local (Compass)
        private static readonly string Puerto = "mongodb+srv://arthur:634990@patitas.skegh3j.mongodb.net/?appName=Patitas";

        // 🐾 Nombre de la base de datos
        private static readonly string BasedeDatos = "Veterinaria";

        private static IMongoDatabase _database;

        /// <summary>
        /// Obtiene la conexión a la base de datos de MongoDB (modo local).
        /// </summary>
        public static IMongoDatabase ObtenerConexion()
        {
            try
            {
                if (_database != null) return _database;

                var client = new MongoClient(Puerto);
                _database = client.GetDatabase(BasedeDatos);

                // Verificar conexión (opcional)
                var collections = _database.ListCollectionNames().ToList();

                return _database;
            }
            catch (Exception ex)
            {
                string mensajeError =
                    $"Error conectando a MongoDB:\n{ex.Message}\n\n" +
                    "Verifica:\n" +
                    "1. Que MongoDB esté instalado\n" +
                    "2. Que el servicio esté ejecutándose\n" +
                    "3. Que la base de datos exista";

                MessageBox.Show(mensajeError, "Error de Conexión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Comprueba si la conexión está activa.
        /// </summary>
        public static bool EstaConectado()
        {
            try
            {
                return ObtenerConexion() != null;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Devuelve un resumen del estado de la conexión.
        /// </summary>
        public static string ObtenerInfoConexion()
        {
            string estado = EstaConectado() ? "✅ Conectado" : "Desconectado";
            return $"Modo: Local (Compass)\nEstado: {estado}\nBase de datos: {BasedeDatos}";
        }
    }
}
