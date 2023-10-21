using Blog.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Image : EntityBase
    {
        public Image() { }
        public Image(string filename, string type)
        {
            FileName = filename;
            Type = type;
        }
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public ICollection<Article> Articles { get; set; }

        public ICollection<AppUser> AppUsers { get; set; }
    }
}
