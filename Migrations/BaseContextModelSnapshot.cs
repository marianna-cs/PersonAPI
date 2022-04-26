﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonAPI.Repo;

#nullable disable

namespace PersonAPI.Migrations
{
    [DbContext(typeof(BaseContext))]
    partial class BaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.2.22153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PersonAPI.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Oleg",
                            GID = new Guid("3d207976-991e-433a-9bdc-470bf0c3271f"),
                            LastName = "Drodov"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Masha",
                            GID = new Guid("0935c799-5ea8-4f79-938b-53c1a9e43eb9"),
                            LastName = "Ivanova"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Ivan",
                            GID = new Guid("29b27e97-a471-414c-b248-fbe85ca18c00"),
                            LastName = "Ivanov"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
