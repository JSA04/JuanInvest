﻿// <auto-generated />
using Api;
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
    [Migration("20240118214128_mudandoPraIngles")]
    partial class mudandoPraIngles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api.Stock", b =>
                {
                    b.Property<string>("StockId")
                        .HasColumnType("text");

                    b.Property<double>("CagrIncome")
                        .HasColumnType("double precision");

                    b.Property<double>("CagrProfit")
                        .HasColumnType("double precision");

                    b.Property<double>("DividendYield")
                        .HasColumnType("double precision");

                    b.Property<string>("EnterpriseName")
                        .HasColumnType("text");

                    b.Property<double>("NetDebtEbtida")
                        .HasColumnType("double precision");

                    b.Property<double>("NetMargin")
                        .HasColumnType("double precision");

                    b.Property<double>("Pl")
                        .HasColumnType("double precision");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<double>("Pvl")
                        .HasColumnType("double precision");

                    b.Property<double>("Roe")
                        .HasColumnType("double precision");

                    b.HasKey("StockId");

                    b.ToTable("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
