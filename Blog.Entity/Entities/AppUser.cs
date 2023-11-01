using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entity.Entities;

namespace Blog.Entity.Entities
{
    public class AppUser:IdentityUser<Guid>,IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid? ImageId { get; set; } = Guid.Parse("F5083E18-2CB7-46F9-B7E0-89A11CACDCEA");
        public Image Image { get; set; }    

        public ICollection<Article> Articles { get; set;}

    }
}
