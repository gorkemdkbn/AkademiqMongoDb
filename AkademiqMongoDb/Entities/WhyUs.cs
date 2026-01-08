using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using AkademiqMongoDb.Entites.Common;

namespace AkademiqMongoDb.Entites
{
    public class WhyUs : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3{ get; set; }
        

    }
}
