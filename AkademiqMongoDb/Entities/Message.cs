using AkademiqMongoDb.Entites.Common;

namespace AkademiqMongoDb.Entites
{
    public class Message : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public bool IsRead { get; set; }
    }
}
