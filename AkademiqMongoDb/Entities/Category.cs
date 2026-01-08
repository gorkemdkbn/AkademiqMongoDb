using AkademiqMongoDb.Entites.Common;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AkademiqMongoDb.Entites
{
    public class Category : BaseEntity
    {
      
        public string Name { get; set; }



    }
}
