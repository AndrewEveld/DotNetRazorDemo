﻿// <auto-generated />
using System;
using DotNetRazorDemo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetRazorDemo.Services.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200921193157_createtable")]
    partial class createtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("DotNetRazorDemo.Models.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
