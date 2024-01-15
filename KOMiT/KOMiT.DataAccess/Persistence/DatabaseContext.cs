using KOMiT.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace KOMiT.DataAccess.Persistence;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public DbSet<Project> Projects { get; set; }
    public DbSet<CurrentPhase> CurrentPhases { get; set; }
    public DbSet<CurrentSubGoal> CurrentSubGoals { get; set; }
    public DbSet<CurrentTask> CurrentTasks { get; set; }
    public DbSet<StandardPhase> StandardPhases { get; set; }
    public DbSet<StandardSubGoal> StandardSubGoals { get; set; }
    public DbSet<StandardTask> StandardTasks { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Competence> Competences { get; set; }
    public DbSet<ProjectMember> ProjectMembers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>().HasData(
            new Project
            {
                Id = 1,
                Name = "Skema og tid",
                Description = "Projektet 'Skema og tid' fokuserer på udviklingen af et avanceret planlægningsværktøj skræddersyet til skolemiljøer. Dette værktøj vil muliggøre nem tilføjelse og administration af skemaer, hvilket gør det lettere for skolepersonale at oprette og vedligeholde skemalægning for undervisning og aktiviteter. Med en prioritet på 'Høj' og planlagt start den 9. november 2023 og forventet afslutning den 9. december 2024, sigter projektet mod at levere en brugervenlig og effektiv løsning, der imødekommer skolernes behov for struktureret tidsstyring.",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Høj,
                EstimatedStartDate = new DateTime(2023, 11, 09),
                EstimatedEndDate = new DateTime(2024, 12, 09),
                Status = Core.Model.Enum.Status.Aktiv
            },
            new Project
            {
                Id = 2,
                Name = "ElevDataPro",
                Description = "Dette projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Drift,
                Priority = Core.Model.Enum.Priority.Mellem,
                EstimatedStartDate = new DateTime(2024, 01, 01),
                EstimatedEndDate = new DateTime(2025, 01, 01),
                Status = Core.Model.Enum.Status.Aktiv
            },
            new Project
            {
                Id = 3,
                Name = "ØkonomiskolePro",
                Description = "Dette er et nyt projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Lav,
                EstimatedStartDate = new DateTime(2023, 12, 01),
                EstimatedEndDate = new DateTime(2024, 01, 01),
                Status = Core.Model.Enum.Status.Aktiv
            },
            new Project
            {
                Id = 4,
                Name = "ElevTilmeldingPro",
                Description = "Dette er et nyt projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Integration,
                EstimatedStartDate = new DateTime(2024, 02, 01),
                Priority = Core.Model.Enum.Priority.Mellem,
                EstimatedEndDate = new DateTime(2024, 03, 01),
                Status = Core.Model.Enum.Status.Inaktiv
            },
            new Project
            {
                Id = 5,
                Name = "BibliotekMesteren",
                Description = "Dette er et nyt projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Lav,
                EstimatedStartDate = new DateTime(2024, 03, 01),
                EstimatedEndDate = new DateTime(2024, 06, 01),
                Status = Core.Model.Enum.Status.Aktiv
            },
            new Project
            {
                Id = 6,
                Name = "KantineKlar",
                Description = "Dette er et nyt projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Drift,
                Priority = Core.Model.Enum.Priority.Mellem,
                EstimatedStartDate = new DateTime(2024, 04, 01),
                EstimatedEndDate = new DateTime(2024, 07, 01),
                Status = Core.Model.Enum.Status.Aktiv
            },
            new Project
            {
                Id = 7,
                Name = "LæringsplatformPro",
                Description = "Dette projekt fokuserer på udviklingen af en avanceret læringsplatform, der integrerer diverse undervisningsressourcer og muliggør effektiv kommunikation mellem elever og lærere. Med en prioritet på 'Høj' og planlagt start den 1. februar 2024 og forventet afslutning den 1. august 2025, sigter projektet mod at forbedre undervisningsoplevelsen og styrke samarbejdet i skolemiljøet.",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Høj,
                EstimatedStartDate = new DateTime(2024, 02, 01),
                EstimatedEndDate = new DateTime(2025, 08, 01),
                Status = Core.Model.Enum.Status.Aktiv
            },
            new Project
            {
                Id = 8,
                Name = "IT-SikkerhedPro",
                Description = "Dette projekt fokuserer på at styrke IT-sikkerheden i skolemiljøet ved implementering af avancerede sikkerhedsforanstaltninger og trusselsbeskyttelse. Med en prioritet på 'Mellem' og planlagt start den 1. april 2024 og forventet afslutning den 1. juni 2024, sigter projektet mod at skabe en tryggere digital læringsmiljø.",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Mellem,
                EstimatedStartDate = new DateTime(2024, 04, 01),
                EstimatedEndDate = new DateTime(2024, 06, 01),
                Status = Core.Model.Enum.Status.Aktiv
            },
             new Project
             {
                 Id = 9,
                 Name = "EksamensadministrationPro",
                 Description = "Dette projekt fokuserer på at udvikle en omfattende eksamensadministrationssystem til skoler. Målet er at gøre processen med at planlægge og administrere eksamener mere effektiv og strømlinet. Med en prioritet på 'Mellem' og planlagt start den 1. september 2024 og forventet afslutning den 1. januar 2025, sigter projektet mod at lette byrden for skoleledere og eksamensansvarlige.",
                 ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                 Priority = Core.Model.Enum.Priority.Mellem,
                 EstimatedStartDate = new DateTime(2024, 09, 01),
                 EstimatedEndDate = new DateTime(2025, 01, 01),
                 Status = Core.Model.Enum.Status.Aktiv
             },
            new Project
            {
                Id = 10,
                Name = "Digitalt Klasseværelse",
                Description = "Dette projekt fokuserer på at integrere avancerede digitale værktøjer i klasseværelset for at forbedre undervisningsmetoderne. Med en prioritet på 'Høj' og planlagt start den 1. januar 2025 og forventet afslutning den 1. juni 2025, sigter projektet mod at skabe en innovativ læringsoplevelse for eleverne.",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Høj,
                EstimatedStartDate = new DateTime(2025, 01, 01),
                EstimatedEndDate = new DateTime(2025, 06, 01),
                Status = Core.Model.Enum.Status.Inaktiv
            },
            new Project
            {
                Id = 13,
                Name = "ForældreportalOptimering",
                Description = "Projektet 'ForældreportalOptimering' har til formål at optimere og forbedre skolens forældreportal. Med en prioritet på 'Mellem' og planlagt start den 1. september 2022 og forventet afslutning den 1. december 2022, sigter projektet mod at styrke kommunikationen mellem skole og forældre.",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Mellem,
                EstimatedStartDate = new DateTime(2022, 09, 01),
                EstimatedEndDate = new DateTime(2022, 12, 01),
                Status = Core.Model.Enum.Status.Færdiggjort
            },
            new Project
            {
                Id = 14,
                Name = "SkolebiblioteksIntegration",
                Description = "Projektet 'SkolebiblioteksIntegration' fokuserer på integration af et avanceret bibliotekssystem direkte i skolens digitale infrastruktur. Med en prioritet på 'Høj' og planlagt start den 1. maj 2022 og forventet afslutning den 1. november 2022, sigter projektet mod at gøre det lettere for elever og lærere at få adgang til læringsressourcer.",
                ProjectType = Core.Model.Enum.ProjectType.Integration,
                Priority = Core.Model.Enum.Priority.Høj,
                EstimatedStartDate = new DateTime(2022, 05, 01),
                EstimatedEndDate = new DateTime(2022, 11, 01),
                Status = Core.Model.Enum.Status.Færdiggjort
            },
            new Project
            {
                Id = 15,
                Name = "Digital Evaluering",
                Description = "Projektet 'Digital Evaluering' sigter mod at implementere et digitalt evalueringssystem for lærere og elever. Med en prioritet på 'Mellem' og planlagt start den 1. oktober 2022 og forventet afslutning den 1. februar 2023, vil projektet gøre det lettere at indsamle og analysere feedback for at forbedre undervisningen.",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Mellem,
                EstimatedStartDate = new DateTime(2022, 10, 01),
                EstimatedEndDate = new DateTime(2023, 02, 01),
                Status = Core.Model.Enum.Status.Færdiggjort
            },
            new Project
            {
                Id = 16,
                Name = "KlasserumsstyringPro",
                Description = "Projektet 'KlasserumsstyringPro' fokuserer på udviklingen af avancerede værktøjer til effektiv styring af klasseværelser. Med en prioritet på 'Høj' og planlagt start den 1. august 2022 og forventet afslutning den 1. maj 2023, sigter projektet mod at optimere læringsmiljøet.",
                ProjectType = Core.Model.Enum.ProjectType.Migration,
                Priority = Core.Model.Enum.Priority.Høj,
                EstimatedStartDate = new DateTime(2022, 08, 01),
                EstimatedEndDate = new DateTime(2023, 05, 01),
                Status = Core.Model.Enum.Status.Færdiggjort
            }
            );

        modelBuilder.Entity<CurrentPhase>().HasData(
            new CurrentPhase
            {
                ProjectId = 1,
                Id = 1,
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedStartDate = new DateTime(2023, 11, 09),
                EstimatedEndDate = new DateTime(2023, 12, 24),
                StandardPhaseId = 1,
                RealizedDate = new DateTime(2023, 12, 10),
                Comment = "Dette er en realiseret kommentar"
            },
            new CurrentPhase
            {
                ProjectId = 2,
                Id = 2,
                Status = Core.Model.Enum.Status.Inaktiv,
                EstimatedStartDate = new DateTime(2024, 11, 09),
                EstimatedEndDate = new DateTime(2024, 12, 24),
                StandardPhaseId = 2,
            },
            new CurrentPhase
            {
                ProjectId = 3,
                Id = 3,
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedStartDate = new DateTime(2023, 12, 01),
                EstimatedEndDate = new DateTime(2023, 12, 15),
                StandardPhaseId = 1,
            },
            new CurrentPhase
            {
                ProjectId = 4,
                Id = 4,
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedStartDate = new DateTime(2024, 02, 01),
                EstimatedEndDate = new DateTime(2024, 02, 15),
                StandardPhaseId = 2,
            },
            new CurrentPhase
            {
                ProjectId = 5,
                Id = 5,
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedStartDate = new DateTime(2024, 03, 01),
                EstimatedEndDate = new DateTime(2024, 04, 15),
                StandardPhaseId = 1,
            },
            new CurrentPhase
            {
                ProjectId = 6,
                Id = 6,
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedStartDate = new DateTime(2024, 04, 01),
                EstimatedEndDate = new DateTime(2024, 05, 15),
                StandardPhaseId = 3,
            },
              new CurrentPhase
              {
                  ProjectId = 7,
                  Id = 7,
                  Status = Core.Model.Enum.Status.Aktiv,
                  EstimatedStartDate = new DateTime(2024, 02, 01),
                  EstimatedEndDate = new DateTime(2024, 05, 15),
                  StandardPhaseId = 2,
              },
              new CurrentPhase
              {
                  ProjectId = 8,
                  Id = 8,
                  Status = Core.Model.Enum.Status.Aktiv,
                  EstimatedStartDate = new DateTime(2024, 04, 01),
                  EstimatedEndDate = new DateTime(2024, 05, 15),
                  StandardPhaseId = 2,
              },
            new CurrentPhase
            {
                ProjectId = 9,
                Id = 9,
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedStartDate = new DateTime(2024, 09, 01),
                EstimatedEndDate = new DateTime(2024, 12, 15),
                StandardPhaseId = 3,
            },
            new CurrentPhase
            {
                ProjectId = 10,
                Id = 10,
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedStartDate = new DateTime(2025, 01, 01),
                EstimatedEndDate = new DateTime(2025, 04, 15),
                StandardPhaseId = 2,
            },
            new CurrentPhase
            {
                ProjectId = 13,
                Id = 13,
                Status = Core.Model.Enum.Status.Færdiggjort,
                EstimatedStartDate = new DateTime(2022, 09, 01),
                EstimatedEndDate = new DateTime(2022, 12, 01),
                StandardPhaseId = 1,
            },
            new CurrentPhase
            {
                ProjectId = 14,
                Id = 14,
                Status = Core.Model.Enum.Status.Færdiggjort,
                EstimatedStartDate = new DateTime(2022, 05, 01),
                EstimatedEndDate = new DateTime(2022, 11, 01),
                StandardPhaseId = 4,
            },
            new CurrentPhase
            {
                ProjectId = 15,
                Id = 15,
                Status = Core.Model.Enum.Status.Færdiggjort,
                EstimatedStartDate = new DateTime(2022, 10, 01),
                EstimatedEndDate = new DateTime(2023, 02, 01),
                StandardPhaseId = 4,
            },
            new CurrentPhase
            {
                ProjectId = 16,
                Id = 16,
                Status = Core.Model.Enum.Status.Færdiggjort,
                EstimatedStartDate = new DateTime(2022, 08, 01),
                EstimatedEndDate = new DateTime(2023, 05, 01),
                StandardPhaseId = 4,
            }
            );


        modelBuilder.Entity<StandardPhase>().HasData(
           new StandardPhase
           {
               Id = 1,
               Name = "Testning",
               Description = "Denne fase..."

           },
           new StandardPhase
           {
               Id = 2,
               Name = "Opstartsfase",
               Description = "Denne fase..."
           },
            new StandardPhase
            {
                Id = 3,
                Name = "Implementering",
                Description = "Denne fase..."
            },
            new StandardPhase
            {
                Id = 4,
                Name = "Afrapportering",
                Description = "Denne fase..."
            }
            );

        modelBuilder.Entity<StandardSubGoal>().HasData(
            new StandardSubGoal
            {
                Id = 1,
                Name = "E2E test",
                Description = "Dette delmål...",
                StandardPhaseId = 1
            },
            new StandardSubGoal
            {
                Id = 2,
                Name = "Unit Testing",
                Description = "Dette delmål...",
                StandardPhaseId = 1
            },
            new StandardSubGoal
            {
                Id = 3,
                Name = "Integration",
                Description = "Dette delmål...",
                StandardPhaseId = 1
            }
           );

        modelBuilder.Entity<StandardTask>().HasData(
           new StandardTask
           {
               Id = 1,
               Title = "Implementer test fixture for E2E",
               Description = "Denne opgave...",
               StandardSubGoalId = 1
           },
           new StandardTask
           {
               Id = 2,
               Title = "Unit Testing",
               Description = "Denne opgave...",
               StandardSubGoalId = 2
           },
           new StandardTask
           {
               Id = 3,
               Title = "Implementere test fixture for integration",
               Description = "Denne opgave...",
               StandardSubGoalId = 3
           },
             new StandardTask
             {
                 Id = 4,
                 Title = "Test database",
                 Description = "Denne opgave...",
                 StandardSubGoalId = 3
             }
           );

        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Name = "Pia Olsen",
                JobPosition = "Udvikler",
                Email = "pia@komit.dk",
            },
            new Employee
            {
                Id = 2,
                Name = "Per Hansen",
                JobPosition = "Konsulent",
                Email = "per@komit.dk",
            },
            new Employee
            {
                Id = 3,
                Name = "Henrik Sørensen",
                JobPosition = "Udvikler",
                Email = "henrik@komit.dk",
            },
            new Employee
            {
                Id = 4,
                Name = "Janni Iversen",
                JobPosition = "Konsulent",
                Email = "janni@komit.dk",
            },
            new Employee
            {
                Id = 5,
                Name = "Kristian Kristensen",
                JobPosition = "Projektleder",
                Email = "kristian@komit.dk",
            },
            new Employee
            {
                Id = 6,
                Name = "Sofie Pedersen",
                JobPosition = "Marketing Specialist",
                Email = "sofie@komit.dk",
            },
            new Employee
            {
                Id = 7,
                Name = "Mikkel Andersen",
                JobPosition = "Systemadministrator",
                Email = "mikkel@komit.dk",
            },
            new Employee
            {
                Id = 8,
                Name = "Kurt Jakobsen",
                JobPosition = "Udvikler",
                Email = "kurt@komit.dk",
            },
            new Employee
            {
                Id = 9,
                Name = "Kevin Poulsen",
                JobPosition = "Udvikler",
                Email = "kevin@komit.dk",
            },
            new Employee
            {
                Id = 10,
                Name = "Signe Sørensen",
                JobPosition = "Udvikler",
                Email = "signe@komit.dk",
            },
            new Employee
            {
                Id = 11,
                Name = "Julie M. Frederiksen",
                JobPosition = "Udvikler",
                Email = "julie@komit.dk",
            }
            );

        modelBuilder.Entity<Competence>().HasData(
            new Competence
            {
                Id = 1,
                Title = "SQL",
                Description = "Jeg føler mig stærk i...",
                Experience = "5 år",
                EmployeeId = 2
            },
            new Competence
            {
                Id = 2,
                Title = "C#",
                Description = "Jeg føler mig stærk i...",
                Experience = "4 år",
                EmployeeId = 2
            },
            new Competence
            {
                Id = 3,
                Title = "Blazor",
                Description = "Jeg føler mig stærk i...",
                Experience = "6 år",
                EmployeeId = 1
            },
            new Competence
            {
                Id = 4,
                Title = "Testning",
                Description = "Jeg føler mig stærk i...",
                Experience = "4 år",
                EmployeeId = 1
            },
            new Competence
            {
                Id = 5,
                Title = "UX",
                Description = "Jeg føler mig stærk i...",
                Experience = "4 år",
                EmployeeId = 3
            },
            new Competence
            {
                Id = 6,
                Title = "HTML",
                Description = "Jeg føler mig stærk i...",
                Experience = "5 år",
                EmployeeId = 3
            },
            new Competence
            {
                Id = 7,
                Title = "Kunderådgivning",
                Description = "Jeg føler mig stærk i...",
                Experience = "1 år",
                EmployeeId = 4
            },
            new Competence
            {
                Id = 8,
                Title = "Salg",
                Description = "Jeg føler mig stærk i...",
                Experience = "3 år",
                EmployeeId = 4
            },
            new Competence
            {
                Id = 9,
                Title = "Ledelse",
                Description = "Jeg føler mig stærk i...",
                Experience = "9 år",
                EmployeeId = 5
            },
            new Competence
            {
                Id = 10,
                Title = "Drift",
                Description = "Jeg føler mig stærk i...",
                Experience = "9 år",
                EmployeeId = 5
            },
            new Competence
            {
                Id = 11,
                Title = "Marketing",
                Description = "Jeg føler mig stærk i...",
                Experience = "4 år",
                EmployeeId = 6
            },
            new Competence
            {
                Id = 12,
                Title = "Strategier",
                Description = "Jeg føler mig stærk i...",
                Experience = "4 år",
                EmployeeId = 6
            },
            new Competence
            {
                Id = 13,
                Title = "Systemadministration",
                Description = "Jeg føler mig stærk i...",
                Experience = "10 år",
                EmployeeId = 7
            },
            new Competence
            {
                Id = 14,
                Title = "Scripting",
                Description = "Jeg føler mig stærk i...",
                Experience = "10 år",
                EmployeeId = 7
            },
            new Competence
            {
                Id = 15,
                Title = "C#",
                Description = "Jeg føler mig stærk i...",
                Experience = "7 år",
                EmployeeId = 8
            },
            new Competence
            {
                Id = 16,
                Title = "Blazor",
                Description = "Jeg føler mig stærk i...",
                Experience = "2 år",
                EmployeeId = 8
            },
            new Competence
            {
                Id = 17,
                Title = "HTML",
                Description = "Jeg føler mig stærk i...",
                Experience = "2 år",
                EmployeeId = 9
            },
            new Competence
            {
                Id = 18,
                Title = "CSS",
                Description = "Jeg føler mig stærk i...",
                Experience = "2 år",
                EmployeeId = 9
            },
            new Competence
            {
                Id = 19,
                Title = "JavaScript",
                Description = "Jeg føler mig stærk i...",
                Experience = "5 år",
                EmployeeId = 10
            },
            new Competence
            {
                Id = 20,
                Title = "Python",
                Description = "Jeg føler mig stærk i...",
                Experience = "8 år",
                EmployeeId = 11
            }
            );

        modelBuilder.Entity<ProjectMember>().HasData(
            new ProjectMember
            {
                Id = 1,
                ProjectRole = Core.Model.Enum.ProjectRole.Udvikler,
                ProjectMemberStatus = Core.Model.Enum.ProjectMemberStatus.Aktiv,
            },
            new ProjectMember
            {
                Id = 2,
                ProjectRole = Core.Model.Enum.ProjectRole.Projektleder,
                ProjectMemberStatus = Core.Model.Enum.ProjectMemberStatus.Aktiv,
            }
            );

        modelBuilder.Entity("CurrentPhaseProjectMember").HasData(
             new { CurrentPhasesId = 1, ProjectMembersId = 1 },
             new { CurrentPhasesId = 1, ProjectMembersId = 2 }
             );



        modelBuilder.Entity("CurrentTaskProjectMember").HasData(
            new { CurrentTasksId = 1, ProjectMembersId = 1 },
            new { CurrentTasksId = 2, ProjectMembersId = 2 }
            );


        modelBuilder.Entity("EmployeeProjectMember").HasData(
            new { EmployeesId = 1, ProjectMembersId = 1 },
            new { EmployeesId = 2, ProjectMembersId = 2 }
            );


        modelBuilder.Entity<CurrentSubGoal>().HasData(
           new CurrentSubGoal
           {
               Id = 1,
               Name = "E2E",
               Description = "Dette delmål...",
               Status = Core.Model.Enum.Status.Aktiv,
               EstimatedEndDate = new DateTime(2024, 11, 09),
               CurrentPhaseId = 1
           },
           new CurrentSubGoal
           {
               Id = 2,
               Name = "Test Integration",
               Description = "Dette er en testintegration",
               Status = Core.Model.Enum.Status.Aktiv,
               EstimatedEndDate = new DateTime(2023, 12, 31),
               CurrentPhaseId = 1
           }
           );

        modelBuilder.Entity<CurrentTask>().HasData(
            new CurrentTask
            {
                Id = 1,
                Title = "Implementere textfixture for E2E",
                Description = "Denne opgave...",
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedNumberOfDays = new DateTime(2023, 11, 10),
                CurrentSubGoalId = 1
            },
            new CurrentTask
            {
                Id = 2,
                Title = "Udfør enhedstest",
                Description = "Skriv og udfør enhedstest for integrationen",
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedNumberOfDays = new DateTime(2023, 11, 20),
                CurrentSubGoalId = 2,
            }
            );

    }

}

