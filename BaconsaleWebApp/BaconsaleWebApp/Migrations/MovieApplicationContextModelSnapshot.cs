﻿// <auto-generated />
using BaconsaleWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaconsaleWebApp.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    partial class MovieApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("BaconsaleWebApp.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("AppID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            AppID = 1,
                            Category = "Action/Adventure",
                            Director = "Joss Whedon",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Avengers, The",
                            Year = 2012
                        },
                        new
                        {
                            AppID = 2,
                            Category = "Action/Adventure",
                            Director = "Tim Burton",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Batman",
                            Year = 1989
                        },
                        new
                        {
                            AppID = 3,
                            Category = "Action/Adventure",
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Dark Knight, The",
                            Year = 2008
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
