﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Upgrade.TraineeAdmin.Infrastructure.Contexts;

namespace Upgrade.TraineeAdmin.Infrastructure.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20220427153320_PrepareDB")]
    partial class PrepareDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Upgrade.TraineeAdmin.Domain.Models.JobProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int?>("TechnologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("PositionId");

                    b.HasIndex("TechnologyId");

                    b.ToTable("JobProfile");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LevelId = 1,
                            PositionId = 1,
                            TechnologyId = 1
                        },
                        new
                        {
                            Id = 2,
                            LevelId = 2,
                            PositionId = 1,
                            TechnologyId = 1
                        },
                        new
                        {
                            Id = 3,
                            LevelId = 2,
                            PositionId = 1,
                            TechnologyId = 2
                        },
                        new
                        {
                            Id = 4,
                            LevelId = 3,
                            PositionId = 1,
                            TechnologyId = 2
                        },
                        new
                        {
                            Id = 5,
                            LevelId = 1,
                            PositionId = 2,
                            TechnologyId = 3
                        },
                        new
                        {
                            Id = 6,
                            LevelId = 3,
                            PositionId = 2,
                            TechnologyId = 3
                        },
                        new
                        {
                            Id = 7,
                            LevelId = 3,
                            PositionId = 3,
                            TechnologyId = 2
                        });
                });

            modelBuilder.Entity("Upgrade.TraineeAdmin.Domain.Models.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Levels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 597, DateTimeKind.Local).AddTicks(2467),
                            Name = "Basic",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(409)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2209),
                            Name = "Intermediate",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2226)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2231),
                            Name = "Advanced",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2234)
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2238),
                            Name = "Super saiyan ultra hyper god green hair ",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2241)
                        });
                });

            modelBuilder.Entity("Upgrade.TraineeAdmin.Domain.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8803),
                            Name = "Front-end",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8840)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8845),
                            Name = "Back-end",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8849)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8852),
                            Name = "QA Automation",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8855)
                        });
                });

            modelBuilder.Entity("Upgrade.TraineeAdmin.Domain.Models.Technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Technologies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2039),
                            Name = ".NET",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2067)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2073),
                            Name = "Java",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2076)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2080),
                            Name = "Angular 2",
                            UpdatedBy = 1,
                            UpdatedOn = new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2083)
                        });
                });

            modelBuilder.Entity("Upgrade.TraineeAdmin.Domain.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("JobProfileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobProfileId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            JobProfileId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            JobProfileId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            JobProfileId = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            JobProfileId = 4,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Upgrade.TraineeAdmin.Domain.Models.JobProfile", b =>
                {
                    b.HasOne("Upgrade.TraineeAdmin.Domain.Models.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Upgrade.TraineeAdmin.Domain.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Upgrade.TraineeAdmin.Domain.Models.Technology", "Technology")
                        .WithMany()
                        .HasForeignKey("TechnologyId");

                    b.Navigation("Level");

                    b.Navigation("Position");

                    b.Navigation("Technology");
                });

            modelBuilder.Entity("Upgrade.TraineeAdmin.Domain.Models.UserProfile", b =>
                {
                    b.HasOne("Upgrade.TraineeAdmin.Domain.Models.JobProfile", "JobProfile")
                        .WithMany()
                        .HasForeignKey("JobProfileId");

                    b.Navigation("JobProfile");
                });
#pragma warning restore 612, 618
        }
    }
}
