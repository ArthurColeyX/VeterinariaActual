using MongoDB.Driver;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public class QueryUsuario
    {
        private IMongoDatabase _database;
        private IMongoCollection<Usuarios> _usuariosCollection;

        public QueryUsuario()
        {
            _database = ConexionMongo.ObtenerConexion();
            _usuariosCollection = _database.GetCollection<Usuarios>("Usuarios");
        }

        // MÉTODO PARA BUSCAR POR NÚMERO DE DOCUMENTO (Login)
        public Usuarios ObtenerUsuario(string numeroDocumento)
        {
            try
            {
                var filter = Builders<Usuarios>.Filter.Eq(u => u.NumeroDocumento, numeroDocumento);
                return _usuariosCollection.Find(filter).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Task.Run(() =>
                    MessageBox.Show($"Error al obtener usuario: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                );
                return null;
            }
        }

        // MÉTODO PARA BUSCAR POR EMAIL (Recuperación de contraseña)
      

        public bool ActualizarContraseña(string email, string nuevaContraseña)
        {
            try
            {
                var filter = Builders<Usuarios>.Filter.Eq(u => u.Correo, email);
                var update = Builders<Usuarios>.Update
                    .Set(u => u.Contraseña, nuevaContraseña);

                var result = _usuariosCollection.UpdateOne(filter, update);
                return result.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                Task.Run(() =>
                    MessageBox.Show($"Error al actualizar contraseña: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                );
                return false;
            }
        }

        // MÉTODO PARA VERIFICAR CREDENCIALES (alternativa)
       
    }
}