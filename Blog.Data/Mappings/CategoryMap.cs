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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {

                Id = Guid.Parse("87881E74-D118-48E4-8E1E-F05441ED12C2"),
                Name = "Asp.NET",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Category
            {

                Id = Guid.Parse("FCFA880C-367E-46AF-9388-025C90C6AC71"),
                Name = "C#",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            }
            );

        }
    }
}
