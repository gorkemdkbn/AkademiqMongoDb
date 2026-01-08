using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using AkademiqMongoDb.Entites.Common;

namespace AkademiqMongoDb.Entites
{
    public class Product : BaseEntity
    {
       

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public string CategoryName { get; set; }


    }
}
