﻿// <auto-generated />
using Dojodachi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dojodachi.Migrations
{
    [DbContext(typeof(DojodachiContext))]
    [Migration("20190906033738_newMigration")]
    partial class newMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dojodachi.Models.Pet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Energy");

                    b.Property<int>("Fullness");

                    b.Property<int>("Happiness");

                    b.Property<int>("Meals");

                    b.HasKey("id");

                    b.ToTable("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
