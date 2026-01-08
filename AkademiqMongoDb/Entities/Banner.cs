using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using AkademiqMongoDb.Entites.Common;

namespace AkademiqMongoDb.Entites
{
    public class Banner : BaseEntity
    {
      
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }


    }
}
