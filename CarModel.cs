using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace CarManagement;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string RegistrationNumber { get; set; }
    public string OwnerName { get; set; }
}