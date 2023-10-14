using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {

                Id = Guid.Parse("F5083E18-2CB7-46F9-B7E0-89A11CACDCEA"),
                FileName = "images/testimage",
                Type = "jpg",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            },
             new Image
             {
                 Id = Guid.Parse("EED85427-CA26-4CF3-8932-1FC664B72DFE"),
                 FileName = "images/.netimage",
                 Type = "png",
                 CreatedBy = "Admin",
                 CreatedDate = DateTime.Now,
                 IsDeleted = false,

             });
        }
    }
}
