﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiWoander.Models;

namespace WebApiWoander.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiWoander.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebApiWoander.Models.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arrival_time_to_point");

                    b.Property<long>("Description");

                    b.Property<string>("Duration_at_point");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longtitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Picture");

                    b.Property<int>("Sequence_no");

                    b.Property<string>("Time_to_next_point");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Points");
                });
#pragma warning restore 612, 618
        }
    }
}
