using AkademiqMongoDb.Entites.Common;

namespace AkademiqMongoDb.Entites
{
    public class Service : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
