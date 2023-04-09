using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Servicio.api.Vehicle.Core.Entities.Generic;

public class Document : IDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public DateTime CreatedDated => DateTime.Now;
}


public interface IDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    string Id { get; set; }

    DateTime CreatedDated { get; }
}