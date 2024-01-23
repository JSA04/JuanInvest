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
    [Migration("20240118200725_addPrecoToTableAcoes2")]
    partial class addPrecoToTableAcoes2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api.Acao", b =>
                {
                    b.Property<string>("AcaoId")
                        .HasColumnType("text");

                    b.Property<double>("CagrLucro")
                        .HasColumnType("double precision");

                    b.Property<double>("CagrReceitas")
                        .HasColumnType("double precision");

                    b.Property<double>("DividaLiquidaEbtida")
                        .HasColumnType("double precision");

                    b.Property<double>("DividendYield")
                        .HasColumnType("double precision");

                    b.Property<double>("MargemLiquida")
                        .HasColumnType("double precision");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("text");

                    b.Property<double>("Preco")
                        .HasColumnType("double precision");

                    b.Property<double>("PrecoLucro")
                        .HasColumnType("double precision");

                    b.Property<double>("PrecoValorPatrimonial")
                        .HasColumnType("double precision");

                    b.Property<double>("Roe")
                        .HasColumnType("double precision");

                    b.HasKey("AcaoId");

                    b.ToTable("Acoes");
                });
#pragma warning restore 612, 618
        }
    }
}
