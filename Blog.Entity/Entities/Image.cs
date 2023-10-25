using Blog.Core.Entities;
using Blog.Entity.Enums;

namespace Blog.Entity.Entities
{
    public class Image : EntityBase
    {
        public Image() { }
        public Image(string filename, string type, string createdBy)
        {
            FileName = filename;
            Type = type;
            CreatedBy = createdBy;
        }
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public ICollection<Article> Articles { get; set; }

        public ICollection<AppUser> AppUsers { get; set; }
    }
}
