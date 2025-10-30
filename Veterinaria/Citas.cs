using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using System.Threading.Tasks;

namespace Veterinaria
{
    // Compatibility type: Citas inherits from Cita so both names can be used interchangeably in the project.
    public class Citas
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("usuarioDocumento")]
        public string UsuarioDocumento { get; set; }

        [BsonElement("mascotaNombre")]
        public string MascotaNombre { get; set; }

        [BsonElement("servicioCita")]
        public string ServicioCita { get; set; }

        [BsonElement("fechaCita")]
        public string FechaCita { get; set; }

        [BsonElement("horaCita")]
        public string HoraCita { get; set; }

        [BsonElement("estadoCita")]
        public string EstadoCita { get; set; }

        [BsonElement("notasCita")]
        public string NotasCita { get; set; }

        [BsonElement("fechaCreacion")]
        public DateTime FechaCreacion { get; set; }
    }
}

