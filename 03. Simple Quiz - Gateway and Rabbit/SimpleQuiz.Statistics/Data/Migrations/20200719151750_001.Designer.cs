﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleQuiz.Statistics.Data;

namespace SimpleQuiz.Statistics.Data.Migrations
{
    [DbContext(typeof(StatisticsDbContext))]
    [Migration("20200719151750_001")]
    partial class _001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpleQuiz.Statistics.Data.Models.Statistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TotalPeople")
                        .HasColumnType("int");

                    b.Property<int>("TotalQuizzes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });
#pragma warning restore 612, 618
        }
    }
}