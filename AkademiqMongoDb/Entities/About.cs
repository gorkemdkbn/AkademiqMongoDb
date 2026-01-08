using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using AkademiqMongoDb.Entites.Common;

namespace AkademiqMongoDb.Entites
{
    public class About : BaseEntity
    {
      
        public int StartYear { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string SideImage1 { get; set; }
        public string SideImage2 { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }



    }
}
