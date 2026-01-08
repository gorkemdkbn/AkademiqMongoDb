using AkademiqMongoDb.Entites.Common;

namespace AkademiqMongoDb.Entites
{
    public class TeamSocialLink : BaseEntity
    {
        public string TeamId { get; set; }
        public string Platform { get; set; }
        public string Url { get; set; }

        public string Icon { get; set; }
    }
}
