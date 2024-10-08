﻿// <auto-generated />
using System;
using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20241008122228_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(744),
                            IsDeleted = false,
                            Name = "Software",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(750),
                            IsDeleted = false,
                            Name = "Accounting",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(754),
                            IsDeleted = false,
                            Name = "Human Resources",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(758),
                            IsDeleted = false,
                            Name = "Consulting",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(762),
                            IsDeleted = false,
                            Name = "Administration",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1370),
                            DepartmentId = 1,
                            Email = "baris@gmail.com",
                            FirstName = "Barış",
                            FullName = "Barış CEYLAN",
                            IsDeleted = false,
                            LastName = "CEYLAN",
                            Phone = "5305137988",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1375),
                            DepartmentId = 2,
                            Email = "aydin1@gmail.com",
                            FirstName = "Aydın",
                            FullName = "Aydın KOCAMAN",
                            IsDeleted = false,
                            LastName = "KOCAMAN",
                            Phone = "1961703544",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1380),
                            DepartmentId = 3,
                            Email = "goncannk@gmail.com",
                            FirstName = "Gonca Nur",
                            FullName = "Gonca Nur KÖPRÜLÜ",
                            IsDeleted = false,
                            LastName = "KÖPRÜLÜ",
                            Phone = "3183915766",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1385),
                            DepartmentId = 4,
                            Email = "emrea@gmail.com",
                            FirstName = "Emre",
                            FullName = "Emre AYDIN",
                            IsDeleted = false,
                            LastName = "AYDIN",
                            Phone = "0850682433",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1389),
                            DepartmentId = 5,
                            Email = "fuatcebe@gmail.com",
                            FirstName = "Fuat",
                            FullName = "Fuat CEBESOY",
                            IsDeleted = false,
                            LastName = "CEBESOY",
                            Phone = "3183915761",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1394),
                            DepartmentId = 4,
                            Email = "alik@gmail.com",
                            FirstName = "Ali",
                            FullName = "Ali Nazik",
                            IsDeleted = false,
                            LastName = "NAZİK",
                            Phone = "3183915762",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1398),
                            DepartmentId = 5,
                            Email = "mertk@gmail.com",
                            FirstName = "Mert",
                            FullName = "Mert KAZIK",
                            IsDeleted = false,
                            LastName = "KAZIK",
                            Phone = "3183915769",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1402),
                            DepartmentId = 3,
                            Email = "muslak@gmail.com",
                            FirstName = "Mustafa",
                            FullName = "Mustafa LALELİ",
                            IsDeleted = false,
                            LastName = "LALELİ",
                            Phone = "018915768",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1407),
                            DepartmentId = 1,
                            Email = "ahmetel@gmail.com",
                            FirstName = "Ahmet",
                            FullName = "Ahmet ELMA",
                            IsDeleted = false,
                            LastName = "ELMA",
                            Phone = "3183915700",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1412),
                            DepartmentId = 2,
                            Email = "abudllahsak@gmail.com",
                            FirstName = "Abdullah",
                            FullName = "Abdullah SAKİN",
                            IsDeleted = false,
                            LastName = "SAKİN",
                            Phone = "3183915711",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.EmployeeRole", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("EmployeeId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("EmployeeRole");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1992),
                            IsAdmin = true,
                            IsDeleted = false,
                            Name = "Admin",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(1997),
                            IsAdmin = false,
                            IsDeleted = false,
                            Name = "Employee",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(2001),
                            IsAdmin = false,
                            IsDeleted = false,
                            Name = "Manager",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(2005),
                            IsAdmin = false,
                            IsDeleted = false,
                            Name = "Cleaner",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 10, 8, 15, 22, 27, 528, DateTimeKind.Utc).AddTicks(2009),
                            IsAdmin = false,
                            IsDeleted = false,
                            Name = "Security",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Employee", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.EmployeeRole", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Employee", "Employee")
                        .WithMany("EmployeeRoles")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Role", "Role")
                        .WithMany("EmployeeRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeRoles");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Role", b =>
                {
                    b.Navigation("EmployeeRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
