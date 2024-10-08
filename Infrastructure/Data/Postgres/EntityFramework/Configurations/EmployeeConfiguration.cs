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
    public class EmployeeConfiguration : BaseConfiguration<Employee, int>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
            var data = new Employee[]
            {
                new Employee { Id = 1, FirstName="Barış", LastName="CEYLAN", FullName="Barış CEYLAN", Email="baris@gmail.com", Phone="5305137988", DepartmentId=1, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 2, FirstName="Aydın", LastName="KOCAMAN", FullName="Aydın KOCAMAN", Email="aydin1@gmail.com", Phone="1961703544", DepartmentId=2, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 4, FirstName="Gonca Nur", LastName="KÖPRÜLÜ", FullName="Gonca Nur KÖPRÜLÜ", Email="goncannk@gmail.com", Phone="3183915766", DepartmentId=3, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 3, FirstName="Emre", LastName="AYDIN", FullName="Emre AYDIN", Email="emrea@gmail.com", Phone="0850682433", DepartmentId=4, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 5, FirstName="Fuat", LastName="CEBESOY", FullName="Fuat CEBESOY", Email="fuatcebe@gmail.com", Phone="3183915761", DepartmentId=5, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 6, FirstName="Ali", LastName="NAZİK", FullName="Ali Nazik", Email="alik@gmail.com", Phone="3183915762", DepartmentId=4, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 7, FirstName="Mert", LastName="KAZIK", FullName="Mert KAZIK", Email="mertk@gmail.com", Phone="3183915769", DepartmentId=5, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 8, FirstName="Mustafa", LastName="LALELİ", FullName="Mustafa LALELİ", Email="muslak@gmail.com", Phone="018915768", DepartmentId=3, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 9, FirstName="Ahmet", LastName="ELMA", FullName="Ahmet ELMA", Email="ahmetel@gmail.com", Phone="3183915700", DepartmentId=1, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
                new Employee { Id = 10, FirstName="Abdullah", LastName="SAKİN", FullName="Abdullah SAKİN", Email="abudllahsak@gmail.com", Phone="3183915711", DepartmentId=2, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false },
            };
            builder.HasData(data);

        }
    }
}
