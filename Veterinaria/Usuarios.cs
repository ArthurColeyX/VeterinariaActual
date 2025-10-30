using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Veterinaria
{
    public class Usuarios
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("nombreUsuario")]
        public string NombreUsuario { get; set; }

        [BsonElement("apellidoUsuario")]
        public string ApellidoUsuario { get; set; }

        [BsonElement("correo")]
        public string Correo { get; set; }

        [BsonElement("numeroDocumento")]
        public string NumeroDocumento { get; set; }

        [BsonElement("contraseña")]
        public string Contraseña { get; set; }

        [BsonElement("rolUsuario")]
        public string RolUsuario { get; set; }

        [BsonElement("telefonoUsuario")]
        public string TelefonoUsuario { get; set; }
    }
}


