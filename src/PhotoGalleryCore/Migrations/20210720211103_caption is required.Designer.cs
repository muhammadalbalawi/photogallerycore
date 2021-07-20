﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhotoGalleryCore.Models;

namespace PhotoGalleryCore.Migrations
{
    [DbContext(typeof(PhotoGalleryDbContext))]
    [Migration("20210720211103_caption is required")]
    partial class captionisrequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("PhotoGalleryCore.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PhotoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PhotoGalleryCore.Models.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Rating")
                        .HasColumnType("INTEGER");

                    b.HasKey("PhotoId");

                    b.ToTable("Photos");

                    b.HasData(
                        new
                        {
                            PhotoId = 1,
                            Caption = "صورة 1",
                            Date = new DateTime(2021, 7, 21, 0, 11, 2, 752, DateTimeKind.Local).AddTicks(2309),
                            Description = "أبنية",
                            Path = "gallery/1.png",
                            Rating = 5
                        },
                        new
                        {
                            PhotoId = 2,
                            Caption = "صورة 2",
                            Date = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "مصورة تحمل الكاميرة",
                            Path = "gallery/2.png",
                            Rating = 5
                        },
                        new
                        {
                            PhotoId = 3,
                            Caption = "مدينة",
                            Date = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "صورة 3",
                            Path = "gallery/3.png",
                            Rating = 5
                        },
                        new
                        {
                            PhotoId = 4,
                            Caption = "شقة",
                            Date = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "صورة 4",
                            Path = "gallery/4.png",
                            Rating = 5
                        });
                });

            modelBuilder.Entity("PhotoGalleryCore.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PhotoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TagId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PhotoGalleryCore.Models.Comment", b =>
                {
                    b.HasOne("PhotoGalleryCore.Models.Photo", "Photo")
                        .WithMany("Comments")
                        .HasForeignKey("PhotoId");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("PhotoGalleryCore.Models.Tag", b =>
                {
                    b.HasOne("PhotoGalleryCore.Models.Photo", null)
                        .WithMany("Tags")
                        .HasForeignKey("PhotoId");
                });

            modelBuilder.Entity("PhotoGalleryCore.Models.Photo", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}