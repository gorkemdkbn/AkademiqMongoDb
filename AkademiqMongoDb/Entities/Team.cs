using AkademiqMongoDb.Entites.Common;
using MongoDB.Bson.Serialization.Attributes;

namespace AkademiqMongoDb.Entites
{
    public class Team : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }

        [BsonIgnore]
        public List<TeamSocialLink> teamSocialLinks { get; set; }
    }
}
