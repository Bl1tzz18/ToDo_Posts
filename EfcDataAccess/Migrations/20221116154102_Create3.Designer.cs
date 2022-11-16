﻿// <auto-generated />
using EfcDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfcDataAccess.Migrations
{
    [DbContext(typeof(PostContext))]
    [Migration("20221116154102_Create3")]
    partial class Create3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Shared.Models.Post", b =>
                {
                    b.Property<int>("postId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("postId");

                    b.HasIndex("userName");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Shared.Models.User", b =>
                {
                    b.Property<string>("userName")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.HasKey("userName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Shared.Models.Post", b =>
                {
                    b.HasOne("Shared.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
