﻿// <auto-generated />
using Blockwoche;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blockwoche.Migrations
{
    [DbContext(typeof(BlockwocheContext))]
    [Migration("20231106133813_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blockwoche.Buch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buch");
                });

            modelBuilder.Entity("Blockwoche.Lehrer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lehrer");
                });

            modelBuilder.Entity("Blockwoche.Schueler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schueler");
                });

            modelBuilder.Entity("Blockwoche.SchuelerBuch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuchId")
                        .HasColumnType("int");

                    b.Property<int>("SchuelerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuchId");

                    b.HasIndex("SchuelerId");

                    b.ToTable("SchuelerBuch");
                });

            modelBuilder.Entity("BuchLehrer", b =>
                {
                    b.Property<int>("BuecherId")
                        .HasColumnType("int");

                    b.Property<int>("LehrerId")
                        .HasColumnType("int");

                    b.HasKey("BuecherId", "LehrerId");

                    b.HasIndex("LehrerId");

                    b.ToTable("BuchLehrer");
                });

            modelBuilder.Entity("BuchSchueler", b =>
                {
                    b.Property<int>("BuchId")
                        .HasColumnType("int");

                    b.Property<int>("SchuelerId")
                        .HasColumnType("int");

                    b.HasKey("BuchId", "SchuelerId");

                    b.HasIndex("SchuelerId");

                    b.ToTable("BuchSchueler");
                });

            modelBuilder.Entity("Blockwoche.SchuelerBuch", b =>
                {
                    b.HasOne("Blockwoche.Buch", "Buch")
                        .WithMany()
                        .HasForeignKey("BuchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blockwoche.Schueler", "Schueler")
                        .WithMany()
                        .HasForeignKey("SchuelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buch");

                    b.Navigation("Schueler");
                });

            modelBuilder.Entity("BuchLehrer", b =>
                {
                    b.HasOne("Blockwoche.Buch", null)
                        .WithMany()
                        .HasForeignKey("BuecherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blockwoche.Lehrer", null)
                        .WithMany()
                        .HasForeignKey("LehrerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuchSchueler", b =>
                {
                    b.HasOne("Blockwoche.Buch", null)
                        .WithMany()
                        .HasForeignKey("BuchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blockwoche.Schueler", null)
                        .WithMany()
                        .HasForeignKey("SchuelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
