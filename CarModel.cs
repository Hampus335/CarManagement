using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace CarManagement;

public class CarModel
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }
    Car car { get; set; }
}
