using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class RoleConfiguration : BaseConfiguration<Role, int>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            var data = new Role[]
            {
                new Role { Id = 1, Name="Admin", IsAdmin=true, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Role { Id = 2, Name="Employee", IsAdmin=false, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Role { Id = 3, Name="Manager", IsAdmin=false, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Role { Id = 4, Name="Cleaner", IsAdmin=false, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Role { Id = 5, Name="Security", IsAdmin=false, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
            };
            builder.HasData(data);
        }
    }
}
