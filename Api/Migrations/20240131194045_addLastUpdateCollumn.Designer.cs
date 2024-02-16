﻿// <auto-generated />
using Api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240131194045_addLastUpdateCollumn")]
    partial class addLastUpdateCollumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api.Domain.Entities.Stock", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)");

                    b.Property<double>("CagrLucro")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.Property<double>("CagrReceitas")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.Property<double>("DividaLiquidaEbitda")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.Property<double>("DividendYield")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<double>("MargemLiquida")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.Property<double>("Preco")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.Property<double>("PrecoLucro")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.Property<double>("PrecoValorPatrimonial")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.Property<double>("Roe")
                        .HasPrecision(10, 2)
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
