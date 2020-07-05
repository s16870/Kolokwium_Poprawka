﻿// <auto-generated />
using System;
using KolokwiumPoprawka.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KolokwiumPoprawka.Migrations
{
    [DbContext(typeof(FireFightersDBContext))]
    partial class FireFightersDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KolokwiumPoprawka.Models.Action", b =>
                {
                    b.Property<int>("IdAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NeedSpecialEquipment")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAction");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("KolokwiumPoprawka.Models.FireTruck", b =>
                {
                    b.Property<int>("IdFireTruck")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OperationalNumber")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("SpecialEquipment")
                        .HasColumnType("bit");

                    b.HasKey("IdFireTruck");

                    b.ToTable("FireTrucks");
                });

            modelBuilder.Entity("KolokwiumPoprawka.Models.FireTruck_Action", b =>
                {
                    b.Property<int>("IdFireTruckAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssigmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.Property<int>("IdFireTruck")
                        .HasColumnType("int");

                    b.HasKey("IdFireTruckAction");

                    b.HasIndex("IdAction");

                    b.HasIndex("IdFireTruck");

                    b.ToTable("FireTruck_Actions");
                });

            modelBuilder.Entity("KolokwiumPoprawka.Models.Firefighter", b =>
                {
                    b.Property<int>("IdFirefighter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdFirefighter");

                    b.ToTable("Firefighters");
                });

            modelBuilder.Entity("KolokwiumPoprawka.Models.Firefighter_Action", b =>
                {
                    b.Property<int>("IdFirefighter")
                        .HasColumnType("int");

                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.HasKey("IdFirefighter", "IdAction");

                    b.HasIndex("IdAction");

                    b.ToTable("Firefighter_Actions");
                });

            modelBuilder.Entity("KolokwiumPoprawka.Models.FireTruck_Action", b =>
                {
                    b.HasOne("KolokwiumPoprawka.Models.Action", "Action")
                        .WithMany("FireTruck_Actions")
                        .HasForeignKey("IdAction")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KolokwiumPoprawka.Models.FireTruck", "FireTruck")
                        .WithMany("FireTruck_Actions")
                        .HasForeignKey("IdFireTruck")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KolokwiumPoprawka.Models.Firefighter_Action", b =>
                {
                    b.HasOne("KolokwiumPoprawka.Models.Action", "Action")
                        .WithMany("Firefighter_Actions")
                        .HasForeignKey("IdAction")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KolokwiumPoprawka.Models.Firefighter", "Firefighter")
                        .WithMany("Firefighter_Actions")
                        .HasForeignKey("IdFirefighter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
