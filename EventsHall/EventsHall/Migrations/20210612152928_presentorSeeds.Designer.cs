﻿// <auto-generated />
using EventsHall.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventsHall.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210612152928_presentorSeeds")]
    partial class presentorSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventsHall.Models.AttendeeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("EventsHall.Models.EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PresentorId")
                        .HasColumnType("int");

                    b.Property<string>("PresentorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("PresentorId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventsHall.Models.HallModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Avaliability")
                        .HasColumnType("bit");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Halls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avaliability = true,
                            Capacity = 50,
                            Name = "First Venue"
                        },
                        new
                        {
                            Id = 2,
                            Avaliability = false,
                            Capacity = 200,
                            Name = "Main Hall"
                        },
                        new
                        {
                            Id = 3,
                            Avaliability = true,
                            Capacity = 1000,
                            Name = "Conference Hall "
                        });
                });

            modelBuilder.Entity("EventsHall.Models.PresentorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Presentors");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            Email = "spurofthemoment@gmail.com",
                            Field = "IT",
                            Name = "Sameera Alhussainy",
                            Phone = 556110112
                        },
                        new
                        {
                            Id = 2,
                            Email = "ceo@tesla.com",
                            Field = "Business",
                            Name = "Elon Musk",
                            Phone = 556123123
                        },
                        new
                        {
                            Id = 665,
                            Email = "mj@gmail.com",
                            Field = "Health",
                            Name = "Michael Jackson",
                            Phone = 522666987
                        },
                        new
                        {
                            Id = 1,
                            Email = "steven@galaxybrain.com",
                            Field = "Science",
                            Name = "Steven Hawking",
                            Phone = 598644222
                        },
                        new
                        {
                            Id = 100,
                            Email = "hala@galaxybrain.com",
                            Field = "Bullshit",
                            Name = "Hala Alyousef",
                            Phone = 522441234
                        },
                        new
                        {
                            Id = 333,
                            Email = "reema@galaxybrain.com",
                            Field = "Divine Philosophy",
                            Name = "Reema Alyousef",
                            Phone = 547722199
                        });
                });

            modelBuilder.Entity("EventsHall.Models.AttendeeModel", b =>
                {
                    b.HasOne("EventsHall.Models.EventModel", "Event")
                        .WithMany("Attendees")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventsHall.Models.EventModel", b =>
                {
                    b.HasOne("EventsHall.Models.HallModel", "Hall")
                        .WithMany("Event")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventsHall.Models.PresentorModel", "Presentor")
                        .WithMany("Events")
                        .HasForeignKey("PresentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("Presentor");
                });

            modelBuilder.Entity("EventsHall.Models.EventModel", b =>
                {
                    b.Navigation("Attendees");
                });

            modelBuilder.Entity("EventsHall.Models.HallModel", b =>
                {
                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventsHall.Models.PresentorModel", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
