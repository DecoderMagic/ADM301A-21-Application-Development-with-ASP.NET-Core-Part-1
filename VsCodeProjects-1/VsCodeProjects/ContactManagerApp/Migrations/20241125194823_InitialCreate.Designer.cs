﻿// <auto-generated />
using System;
using ContactManagerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactManagerApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241125194823_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContactManagerApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Friends"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Work"
                        });
                });

            modelBuilder.Entity("ContactManagerApp.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = 2,
                            DateAdded = new DateTime(2024, 9, 27, 13, 24, 0, 0, DateTimeKind.Unspecified),
                            Email = "delores@hotmail.com",
                            Firstname = "Delores",
                            Lastname = "Del Rio",
                            Phone = "555-987-6543"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = 3,
                            DateAdded = new DateTime(2024, 8, 12, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            Email = "efren@aol.com",
                            Firstname = "Efren",
                            Lastname = "Herrera",
                            Phone = "555-456-7890"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryId = 1,
                            DateAdded = new DateTime(2024, 11, 1, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "MaryEllen@yahoo.com",
                            Firstname = "Mary Ellen",
                            Lastname = "Walton",
                            Phone = "555-123-4567"
                        });
                });

            modelBuilder.Entity("ContactManagerApp.Models.Contact", b =>
                {
                    b.HasOne("ContactManagerApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
