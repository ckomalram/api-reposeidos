using MongoDB.Bson.Serialization.Attributes;
using Servicio.api.Vehicle.Core.Entities.Generic;

namespace Servicio.api.Vehicle.Core.Entities;


[BsonCollectionAttributes("Visita")]
public class VisitEntity : Document
{


    [BsonElement("personId")]
    public string PersonId { get; set; }

    [BsonElement("vehicle")]
    public VehicleEntity Vehicle { get; set; }

    [BsonElement("status")]
    public bool Status { get; set; }

    [BsonElement("dateVisit")]
    public DateTime DateVisit { get; set; }




}
