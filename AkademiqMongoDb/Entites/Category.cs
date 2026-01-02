using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AkademiqMongoDb.Entites
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }



    }
}
