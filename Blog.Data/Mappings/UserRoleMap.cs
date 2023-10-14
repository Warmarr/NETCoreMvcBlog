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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("CFD93DA1-4C4F-48C6-8E8E-CD9094A22E3A"),
                RoleId = Guid.Parse("FB8FD6AE-372C-47C8-8C82-FF7273136FC6")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("238F4A04-8F30-4AE0-BD6C-D0140988C617"),
                RoleId = Guid.Parse("29724D8D-EF6A-4DE5-99AF-725084A1CB17")
            }
            );
        }
    }
}
