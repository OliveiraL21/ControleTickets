﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(TicketContext))]
    [Migration("20220224024417_adicionando-campo-descricao")]
    partial class adicionandocampodescricao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Ticket", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("HorarioDeInicio")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("HoririoFinal")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("TotalHorasGasto")
                        .HasColumnType("time");

                    b.HasKey("Codigo");

                    b.ToTable("Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}
