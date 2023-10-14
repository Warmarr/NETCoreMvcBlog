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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article()
            {
                Id = Guid.NewGuid(),
                Title = "C# Windows Forms",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                WievCount = 15,
                CategoryId = Guid.Parse("FCFA880C-367E-46AF-9388-025C90C6AC71"),
                ImageId = Guid.Parse("EED85427-CA26-4CF3-8932-1FC664B72DFE"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("CFD93DA1-4C4F-48C6-8E8E-CD9094A22E3A"),

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.NET Deneme",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                WievCount = 10,
                CategoryId = Guid.Parse("87881E74-D118-48E4-8E1E-F05441ED12C2"),
                ImageId = Guid.Parse("F5083E18-2CB7-46F9-B7E0-89A11CACDCEA"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("238F4A04-8F30-4AE0-BD6C-D0140988C617"),
                
            }


            ); 
        }
    }
}
