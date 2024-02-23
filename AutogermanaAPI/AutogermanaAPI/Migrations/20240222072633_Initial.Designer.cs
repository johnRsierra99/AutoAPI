﻿// <auto-generated />
using System;
using AutogermanaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutogermanaAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240222072633_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutogermanaAPI.Transaccion", b =>
                {
                    b.Property<int>("TransaccionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransaccionID"));

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrecioVenta")
                        .HasColumnType("int");

                    b.HasKey("TransaccionID");

                    b.ToTable("Transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}
