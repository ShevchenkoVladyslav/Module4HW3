﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModuleHW.DataAccess;

namespace ModuleHW.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211117194417_AddEmployeeProjectTableData")]
    partial class AddEmployeeProjectTableData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClientId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Company");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Location");

                    b.HasKey("Id");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Company = "Apple",
                            Email = "client_1@ma.il",
                            FirstName = "Andrew [1]",
                            LastName = "Babashev [1]",
                            Location = "One Apple Park Way, Cupertino, California, U.S."
                        },
                        new
                        {
                            Id = 2,
                            Company = "Google",
                            Email = "client_2@ma.il",
                            FirstName = "Dave [2]",
                            LastName = "Cunningham [2]",
                            Location = "1600 Amphitheatre Parkway, Mountain View, California, U.S."
                        },
                        new
                        {
                            Id = 3,
                            Company = "Microsoft",
                            Email = "client_3@ma.il",
                            FirstName = "Everett [3]",
                            LastName = "Grunz [3]",
                            Location = "One Microsoft Way, Redmond, Washington, U.S."
                        },
                        new
                        {
                            Id = 4,
                            Company = "Panasonic",
                            Email = "client_4@ma.il",
                            FirstName = "Ian [4]",
                            LastName = "Fleming [4]",
                            Location = "Kadoma, Osaka, Japan"
                        },
                        new
                        {
                            Id = 5,
                            Company = "Samsung",
                            Email = "client_5@ma.il",
                            FirstName = "Henry [5]",
                            LastName = "Jones [5]",
                            Location = "40th floor Samsung Electronics Building, 11, Seocho-daero 74-gil, Seocho District, Seoul, South Korea"
                        },
                        new
                        {
                            Id = 6,
                            Company = "VQ",
                            Email = "client_6@ma.il",
                            FirstName = "Volt [6]",
                            LastName = "Querier [6]",
                            Location = "VQ Location"
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<DateTime>("HiredDate")
                        .HasPrecision(7)
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("HiredDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [1]",
                            HiredDate = new DateTime(2011, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [1]",
                            OfficeId = 1,
                            TitleId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1986, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [2]",
                            HiredDate = new DateTime(2013, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [2]",
                            OfficeId = 2,
                            TitleId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1991, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [3]",
                            HiredDate = new DateTime(2015, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [3]",
                            OfficeId = 3,
                            TitleId = 3
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [4]",
                            HiredDate = new DateTime(2017, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [4]",
                            OfficeId = 4,
                            TitleId = 4
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(2001, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [5]",
                            HiredDate = new DateTime(2019, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [5]",
                            OfficeId = 5,
                            TitleId = 5
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(2006, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [6]",
                            HiredDate = new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [6]",
                            OfficeId = 6,
                            TitleId = 6
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(2011, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [7]",
                            HiredDate = new DateTime(2019, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [7]",
                            OfficeId = 4
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(2016, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [8]",
                            HiredDate = new DateTime(2017, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [8]",
                            TitleId = 2
                        },
                        new
                        {
                            Id = 9,
                            DateOfBirth = new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "FName [9]",
                            HiredDate = new DateTime(2015, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "LName [9]"
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.EmployeeProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeProjectId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("money")
                        .HasColumnName("Rate");

                    b.Property<DateTime>("StartedDate")
                        .HasPrecision(7)
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("StartedDate");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProject");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            ProjectId = 5,
                            Rate = 3000m,
                            StartedDate = new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            ProjectId = 4,
                            Rate = 4000m,
                            StartedDate = new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 3,
                            ProjectId = 3,
                            Rate = 5000m,
                            StartedDate = new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 4,
                            ProjectId = 2,
                            Rate = 6000m,
                            StartedDate = new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = 5,
                            ProjectId = 1,
                            Rate = 7000m,
                            StartedDate = new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OfficeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Office");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Office 1 Location",
                            Name = "Office 1",
                            Title = "Title of Office 1"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Office 2 Location",
                            Name = "Office 2",
                            Title = "Title of Office 2"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Office 3 Location",
                            Name = "Office 3",
                            Title = "Title of Office 3"
                        },
                        new
                        {
                            Id = 4,
                            Location = "Office 4 Location",
                            Name = "Office 4",
                            Title = "Title of Office 4"
                        },
                        new
                        {
                            Id = 5,
                            Location = "Office 5 Location",
                            Name = "Office 5",
                            Title = "Title of Office 5"
                        },
                        new
                        {
                            Id = 6,
                            Location = "Office 6 Location",
                            Name = "Office 6",
                            Title = "Title of Office 6"
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProjectId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("money")
                        .HasColumnName("Budget");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("StartedDate")
                        .HasPrecision(7)
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("StartedDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 10000.0m,
                            ClientId = 1,
                            Name = "Anaconda [1]",
                            StartedDate = new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Budget = 20000.0m,
                            ClientId = 2,
                            Name = "Cyclon [2]",
                            StartedDate = new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Budget = 30000.0m,
                            ClientId = 3,
                            Name = "Drager [3]",
                            StartedDate = new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Budget = 40000.0m,
                            ClientId = 4,
                            Name = "Golum [4]",
                            StartedDate = new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Budget = 50000.0m,
                            ClientId = 5,
                            Name = "Oblivion [5]",
                            StartedDate = new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Budget = 60000.0m,
                            ClientId = 5,
                            Name = "Raptor [6]",
                            StartedDate = new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TitleId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Title");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Title 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Title 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Title 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Title 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Title 5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Title 6"
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Employee", b =>
                {
                    b.HasOne("ModuleHW.DataAccess.Models.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ModuleHW.DataAccess.Models.Title", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.EmployeeProject", b =>
                {
                    b.HasOne("ModuleHW.DataAccess.Models.Employee", "Employee")
                        .WithMany("EmployeeProject")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModuleHW.DataAccess.Models.Project", "Project")
                        .WithMany("EmployeeProject")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Project", b =>
                {
                    b.HasOne("ModuleHW.DataAccess.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Employee", b =>
                {
                    b.Navigation("EmployeeProject");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Project", b =>
                {
                    b.Navigation("EmployeeProject");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Title", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
