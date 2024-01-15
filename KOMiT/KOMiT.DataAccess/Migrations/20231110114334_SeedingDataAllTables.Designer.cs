﻿// <auto-generated />
using System;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231110114334_SeedingDataAllTables")]
    partial class SeedingDataAllTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CurrentSubGoalProjectMember", b =>
                {
                    b.Property<int>("CurrentSubGoalsId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectMembersId")
                        .HasColumnType("int");

                    b.HasKey("CurrentSubGoalsId", "ProjectMembersId");

                    b.HasIndex("ProjectMembersId");

                    b.ToTable("CurrentSubGoalProjectMember");
                });

            modelBuilder.Entity("CurrentTaskProjectMember", b =>
                {
                    b.Property<int>("CurrentTasksId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectMembersId")
                        .HasColumnType("int");

                    b.HasKey("CurrentTasksId", "ProjectMembersId");

                    b.HasIndex("ProjectMembersId");

                    b.ToTable("CurrentTaskProjectMember");
                });

            modelBuilder.Entity("KOMiT.Core.Model.Competence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Competence");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Jeg føler mig stærk i...",
                            Experience = "5 år",
                            Title = "SQL"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Jeg føler mig stærk i...",
                            Experience = "4 år",
                            Title = "C#"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Jeg føler mig stærk i...",
                            Experience = "6 år",
                            Title = "Blazor"
                        });
                });

            modelBuilder.Entity("KOMiT.Core.Model.CurrentSubGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstimatedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RealizedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("SubProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubProjectId");

                    b.ToTable("CurrentSubGoals");
                });

            modelBuilder.Entity("KOMiT.Core.Model.CurrentTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CurrentSubGoalId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstimatedNumberOfDays")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RealizedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurrentSubGoalId");

                    b.ToTable("CurrentTasks");
                });

            modelBuilder.Entity("KOMiT.Core.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectMemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectMemberId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "pia@komit.dk",
                            JobPosition = "Udvikler",
                            Name = "Pia Olsen"
                        },
                        new
                        {
                            Id = 2,
                            Email = "per@komit.dk",
                            JobPosition = "Konsulent",
                            Name = "Per Hansen"
                        });
                });

            modelBuilder.Entity("KOMiT.Core.Model.Phase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Phase");
                });

            modelBuilder.Entity("KOMiT.Core.Model.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstimatedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EstimatedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("ProjectType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RealizedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Dette projekt...",
                            EstimatedEndDate = new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EstimatedStartDate = new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Skema og tid",
                            Priority = 0,
                            ProjectType = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dette projekt...",
                            EstimatedEndDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EstimatedStartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ElevDataPro",
                            Priority = 0,
                            ProjectType = 0,
                            Status = 0
                        });
                });

            modelBuilder.Entity("KOMiT.Core.Model.ProjectMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProjectMemberStatus")
                        .HasColumnType("int");

                    b.Property<string>("ProjectRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectMembers");
                });

            modelBuilder.Entity("KOMiT.Core.Model.StandardSubGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhaseId");

                    b.ToTable("StandardSubGoals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Dette delmål...",
                            Name = "E2E test"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dette delmål...",
                            Name = "Unit Testing"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dette delmål...",
                            Name = "Integration"
                        });
                });

            modelBuilder.Entity("KOMiT.Core.Model.StandardTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StandardSubGoalId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StandardSubGoalId");

                    b.ToTable("StandardTasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Denne opgave...",
                            Title = "Implementer test fixture for E2E"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Denne opgave...",
                            Title = "Unit Testing"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Denne opgave...",
                            Title = "Tilføj API til projekt"
                        });
                });

            modelBuilder.Entity("KOMiT.Core.Model.SubProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstimatedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EstimatedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RealizedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("SubProjects");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            EstimatedEndDate = new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EstimatedStartDate = new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            EstimatedEndDate = new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EstimatedStartDate = new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 2,
                            Status = 1
                        });
                });

            modelBuilder.Entity("PhaseSubProject", b =>
                {
                    b.Property<int>("PhasesId")
                        .HasColumnType("int");

                    b.Property<int>("SubProjectsId")
                        .HasColumnType("int");

                    b.HasKey("PhasesId", "SubProjectsId");

                    b.HasIndex("SubProjectsId");

                    b.ToTable("PhaseSubProject");
                });

            modelBuilder.Entity("CurrentSubGoalProjectMember", b =>
                {
                    b.HasOne("KOMiT.Core.Model.CurrentSubGoal", null)
                        .WithMany()
                        .HasForeignKey("CurrentSubGoalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KOMiT.Core.Model.ProjectMember", null)
                        .WithMany()
                        .HasForeignKey("ProjectMembersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CurrentTaskProjectMember", b =>
                {
                    b.HasOne("KOMiT.Core.Model.CurrentTask", null)
                        .WithMany()
                        .HasForeignKey("CurrentTasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KOMiT.Core.Model.ProjectMember", null)
                        .WithMany()
                        .HasForeignKey("ProjectMembersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KOMiT.Core.Model.Competence", b =>
                {
                    b.HasOne("KOMiT.Core.Model.Employee", "Employee")
                        .WithMany("Competences")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("KOMiT.Core.Model.CurrentSubGoal", b =>
                {
                    b.HasOne("KOMiT.Core.Model.SubProject", "SubProject")
                        .WithMany("CurrentSubGoals")
                        .HasForeignKey("SubProjectId");

                    b.Navigation("SubProject");
                });

            modelBuilder.Entity("KOMiT.Core.Model.CurrentTask", b =>
                {
                    b.HasOne("KOMiT.Core.Model.CurrentSubGoal", "CurrentSubGoal")
                        .WithMany("CurrentTasks")
                        .HasForeignKey("CurrentSubGoalId");

                    b.Navigation("CurrentSubGoal");
                });

            modelBuilder.Entity("KOMiT.Core.Model.Employee", b =>
                {
                    b.HasOne("KOMiT.Core.Model.ProjectMember", "ProjectMember")
                        .WithMany("Employees")
                        .HasForeignKey("ProjectMemberId");

                    b.Navigation("ProjectMember");
                });

            modelBuilder.Entity("KOMiT.Core.Model.StandardSubGoal", b =>
                {
                    b.HasOne("KOMiT.Core.Model.Phase", "Phase")
                        .WithMany("StandardSubGoals")
                        .HasForeignKey("PhaseId");

                    b.Navigation("Phase");
                });

            modelBuilder.Entity("KOMiT.Core.Model.StandardTask", b =>
                {
                    b.HasOne("KOMiT.Core.Model.StandardSubGoal", "StandardSubGoal")
                        .WithMany("StandardTasks")
                        .HasForeignKey("StandardSubGoalId");

                    b.Navigation("StandardSubGoal");
                });

            modelBuilder.Entity("KOMiT.Core.Model.SubProject", b =>
                {
                    b.HasOne("KOMiT.Core.Model.Project", "Project")
                        .WithMany("SubProjects")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("PhaseSubProject", b =>
                {
                    b.HasOne("KOMiT.Core.Model.Phase", null)
                        .WithMany()
                        .HasForeignKey("PhasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KOMiT.Core.Model.SubProject", null)
                        .WithMany()
                        .HasForeignKey("SubProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KOMiT.Core.Model.CurrentSubGoal", b =>
                {
                    b.Navigation("CurrentTasks");
                });

            modelBuilder.Entity("KOMiT.Core.Model.Employee", b =>
                {
                    b.Navigation("Competences");
                });

            modelBuilder.Entity("KOMiT.Core.Model.Phase", b =>
                {
                    b.Navigation("StandardSubGoals");
                });

            modelBuilder.Entity("KOMiT.Core.Model.Project", b =>
                {
                    b.Navigation("SubProjects");
                });

            modelBuilder.Entity("KOMiT.Core.Model.ProjectMember", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("KOMiT.Core.Model.StandardSubGoal", b =>
                {
                    b.Navigation("StandardTasks");
                });

            modelBuilder.Entity("KOMiT.Core.Model.SubProject", b =>
                {
                    b.Navigation("CurrentSubGoals");
                });
#pragma warning restore 612, 618
        }
    }
}
