﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tema_VLADULESCU_GABRIEL.Data;

#nullable disable

namespace TemaVLADULESCUGABRIEL.Migrations
{
    [DbContext(typeof(Tema_VLADULESCU_GABRIELContext))]
    partial class TemaVLADULESCUGABRIELContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.Cinema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CountyID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CountyID");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.CinemaLocation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CinemaID")
                        .HasColumnType("int");

                    b.Property<int>("CountyID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CinemaID");

                    b.HasIndex("CountyID");

                    b.ToTable("CinemaLocation");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.County", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("County");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("MovieGenreID")
                        .HasColumnType("int");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MovieGenreID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.MovieGenre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CinemaID")
                        .HasColumnType("int");

                    b.Property<int?>("CinemaLocationID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CinemaID");

                    b.HasIndex("CinemaLocationID");

                    b.HasIndex("MovieID");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.Cinema", b =>
                {
                    b.HasOne("Tema_VLADULESCU_GABRIEL.Models.County", null)
                        .WithMany("Cinemas")
                        .HasForeignKey("CountyID");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.CinemaLocation", b =>
                {
                    b.HasOne("Tema_VLADULESCU_GABRIEL.Models.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("CinemaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tema_VLADULESCU_GABRIEL.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("County");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.Movie", b =>
                {
                    b.HasOne("Tema_VLADULESCU_GABRIEL.Models.MovieGenre", "MovieGenre")
                        .WithMany("Movies")
                        .HasForeignKey("MovieGenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieGenre");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.Ticket", b =>
                {
                    b.HasOne("Tema_VLADULESCU_GABRIEL.Models.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("CinemaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tema_VLADULESCU_GABRIEL.Models.CinemaLocation", null)
                        .WithMany("Tickets")
                        .HasForeignKey("CinemaLocationID");

                    b.HasOne("Tema_VLADULESCU_GABRIEL.Models.Movie", "Movie")
                        .WithMany("Tickets")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.CinemaLocation", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.County", b =>
                {
                    b.Navigation("Cinemas");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.Movie", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Tema_VLADULESCU_GABRIEL.Models.MovieGenre", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
