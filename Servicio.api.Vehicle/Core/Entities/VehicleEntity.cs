using MongoDB.Bson.Serialization.Attributes;
using Servicio.api.Vehicle.Core.Entities.Generic;

namespace Servicio.api.Vehicle.Core.Entities;

[BsonCollectionAttributes("Vehiculo")]
public class VehicleEntity : Document
{

    [BsonElement("plate")]
    public string Plate { get; set; }

    [BsonElement("year")]
    public int Year { get; set; }

    [BsonElement("kilometer")]
    public int Kilometer { get; set; }

    [BsonElement("status")]
    public bool Status { get; set; }




}
