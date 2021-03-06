﻿// <auto-generated />
using System;
using AnimeAddicts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimeAddicts.Migrations
{
    [DbContext(typeof(AnimeContext))]
    [Migration("20190505193426_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnimeAddicts.Models.Anime", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Duration");

                    b.Property<string>("Genres");

                    b.Property<string>("Premiere");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.Property<string>("URLs");

                    b.HasKey("ID");

                    b.ToTable("Animes");
                });
#pragma warning restore 612, 618
        }
    }
}
