
namespace Servicio.api.Vehicle.Core.Entities.Generic;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class BsonCollectionAttributes : Attribute
{
    public string CollectionName { get; }

    public BsonCollectionAttributes(string collectionName)
    {
        CollectionName = collectionName;
    }
}