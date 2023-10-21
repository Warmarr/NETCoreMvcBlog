using Blog.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Article:EntityBase
    {
        public Article() 
        {

        }
        public Article(string title,string content,Guid userId,Guid categoryId,Guid imageId)
        {
            Title = title;
            Content = content;
            UserId = userId;
            CategoryId = categoryId;
            ImageId = imageId;
        }
        
        public string Title { get; set; }
        public string Content { get; set; }
        public int WievCount { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Guid? ImageId { get; set; }
        public virtual Image Image { get; set; }

       
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
