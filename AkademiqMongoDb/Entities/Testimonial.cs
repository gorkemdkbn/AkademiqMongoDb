using AkademiqMongoDb.Entites.Common;

namespace AkademiqMongoDb.Entites
{
    public class Testimonial : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
    }
}
