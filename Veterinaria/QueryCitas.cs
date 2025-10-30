using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Veterinaria
{
    class QueryCitas
    {
        private readonly IMongoCollection<Citas> _citasCollection;

        public QueryCitas()
        {
            var db = ConexionMongo.ObtenerConexion();
            _citasCollection = db.GetCollection<Citas>("Citas");
        }

        // Obtener todas las citas
        public List<Citas> ObtenerTodasLasCitas()
        {
            return _citasCollection.Find(_ => true).ToList();
        }

        // Obtener citas por número de documento del usuario
       
    }

}

