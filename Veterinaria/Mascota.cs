using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Mascota
    {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string _id { get; set; }

    [BsonElement("numeroDocumentoDueño")]
    public string NumeroDocumentoDueño { get; set; }

    [BsonElement("nombreMascota")]
    public string NombreMascota { get; set; }

    [BsonElement("especie")]
    public string Especie { get; set; }

    [BsonElement("raza")]
    public string Raza { get; set; }

    [BsonElement("edad")]
    public int Edad { get; set; }

    [BsonElement("sexo")]
    public string Sexo { get; set; }

    [BsonElement("peso")]
    public double Peso { get; set; }

    }
}


