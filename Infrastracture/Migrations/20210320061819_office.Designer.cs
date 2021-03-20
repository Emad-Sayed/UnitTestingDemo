﻿// <auto-generated />
using System;
using Infrastracture.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastracture.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210320061819_office")]
    partial class office
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Core.Infrastructure.Repository.Entities.Departement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Depts");
                });

            modelBuilder.Entity("Core.Infrastructure.Repository.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("OfficeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Core.Infrastructure.Repository.Entities.Office", b =>
                {
                    b.HasOne("Core.Infrastructure.Repository.Entities.Departement", "Dept")
                        .WithMany("Offices")
                        .HasForeignKey("DeptId");

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("Core.Infrastructure.Repository.Entities.Departement", b =>
                {
                    b.Navigation("Offices");
                });
#pragma warning restore 612, 618
        }
    }
}
