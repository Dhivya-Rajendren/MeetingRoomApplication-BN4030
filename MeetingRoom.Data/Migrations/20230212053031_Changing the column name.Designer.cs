﻿// <auto-generated />
using System;
using MeetingRoom.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeetingRoom.Data.Migrations
{
    [DbContext(typeof(MeetingRoomDbContext))]
    [Migration("20230212053031_Changing the column name")]
    partial class Changingthecolumnname
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MeetingRoom.Domain.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeetingId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("char(100)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("Status")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("MeetingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MeetingRoomId")
                        .HasColumnType("int");

                    b.HasKey("MeetingId");

                    b.HasIndex("MeetingRoomId");

                    b.ToTable("tbl_Meetings");
                });

            modelBuilder.Entity("MeetingRoom.Domain.MeetingRoom", b =>
                {
                    b.Property<int>("MeetingRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeetingRoomId"), 1L, 1);

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MeetingRoomName")
                        .HasColumnType("char(30)");

                    b.Property<string>("MeetingRoomType")
                        .IsRequired()
                        .HasColumnType("char(30)");

                    b.HasKey("MeetingRoomId");

                    b.ToTable("tbl_MeetingRooms");
                });

            modelBuilder.Entity("MeetingRoom.Domain.Meeting", b =>
                {
                    b.HasOne("MeetingRoom.Domain.MeetingRoom", "MeetingRoom")
                        .WithMany()
                        .HasForeignKey("MeetingRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeetingRoom");
                });
#pragma warning restore 612, 618
        }
    }
}
