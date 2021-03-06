﻿// <auto-generated />
using System;
using MealPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MealPlanner.Migrations
{
  [DbContext(typeof(MealPlannerContext))]
  partial class MealPlannerContextModelSnapshot : ModelSnapshot
  {
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .UseIdentityByDefaultColumns()
          .HasAnnotation("Relational:MaxIdentifierLength", 63)
          .HasAnnotation("ProductVersion", "5.0.2");

      modelBuilder.Entity("MealPlanner.Models.Meal", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("integer")
                      .UseIdentityByDefaultColumn();

            b.Property<string>("Image")
                      .IsRequired()
                      .HasColumnType("text");

            b.Property<string[]>("Ingredients")
                      .IsRequired()
                      .HasColumnType("text[]");

            b.Property<string[]>("Instructions")
                      .IsRequired()
                      .HasColumnType("text[]");

            b.Property<string>("Name")
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasColumnType("character varying(100)");

            b.HasKey("Id");

            b.ToTable("Meals");
          });
#pragma warning restore 612, 618
    }
  }
}
