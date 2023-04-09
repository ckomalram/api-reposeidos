using MongoDB.Bson.Serialization.Attributes;
using Servicio.api.Vehicle.Core.Entities.Generic;

namespace Servicio.api.Vehicle.Core.Entities;


[BsonCollectionAttributes("Oferta")]
public class OffertEntity : Document
{

    [BsonElement("value")]
    public int Value { get; set; }

    [BsonElement("personId")]
    public string PersonId { get; set; }

    [BsonElement("vehicle")]
    public VehicleEntity Vehicle { get; set; }

    [BsonElement("status")]
    public bool Status { get; set; }

    [BsonElement("dateOffer")]
    public DateTime DateOffer { get; set; }




}
