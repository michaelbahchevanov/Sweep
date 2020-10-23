using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sweepi.ImageServiceAPI.Models
{
    public class Image : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public string ImageUrl { get; set; }
    }
}