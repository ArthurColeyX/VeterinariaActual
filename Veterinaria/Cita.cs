using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Veterinaria
{
    public class Cita
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string _id { get; set; }

        [BsonElement("usuario_id")]
        public string UsuarioId { get; set; }

        [BsonElement("mascota_id")]
        public string mascotaId { get; set; }

        [BsonElement("motivo")]
        public string Motivo { get; set; }

        [BsonElement("fecha")]
        public string Fecha { get; set; }

        [BsonElement("hora")]
        public string Hora { get; set; }

        [BsonElement("estado")]
        public string Estado { get; set; }

        [BsonElement("creadoEn")]
        public DateTime CreadoEn { get; set; }
    }
}
