﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySolution.Module.BusinessObjects;

#nullable disable

namespace MySolution.Module.Migrations
{
    [DbContext(typeof(MySolutionEFCoreDbContext))]
    [Migration("20231120133032_TenthMigration")]
    partial class TenthMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Proxies:ChangeTracking", true)
                .HasAnnotation("Proxies:CheckEquality", true)
                .HasAnnotation("Proxies:LazyLoading", false)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoTaskEmployee", b =>
                {
                    b.Property<Guid>("DemoTasksID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeesID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DemoTasksID", "EmployeesID");

                    b.HasIndex("EmployeesID");

                    b.ToTable("DemoTaskEmployee");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Address", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipPostal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.DemoTask", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PercentCompleted")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DemoTasks");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Department", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AddressID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PositionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TitleOfCourtesy_Int")
                        .HasColumnType("int");

                    b.Property<string>("WebPageAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("PositionID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.PhoneNumber", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Position", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("DemoTaskEmployee", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.DemoTask", null)
                        .WithMany()
                        .HasForeignKey("DemoTasksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySolution.Module.BusinessObjects.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Employee", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("MySolution.Module.BusinessObjects.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID");

                    b.HasOne("MySolution.Module.BusinessObjects.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID");

                    b.Navigation("Address");

                    b.Navigation("Department");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.PhoneNumber", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.Employee", "Employee")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Employee", b =>
                {
                    b.Navigation("PhoneNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
