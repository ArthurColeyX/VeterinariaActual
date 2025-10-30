using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Servicios
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("nombreServicio")]
        public string NombreServicio { get; set; }

        [BsonElement("descripcionServicio")]
        public string DescripcionServicio { get; set; }

        [BsonElement("precioServicio")]
        public double PrecioServicio { get; set; }
    }
}

