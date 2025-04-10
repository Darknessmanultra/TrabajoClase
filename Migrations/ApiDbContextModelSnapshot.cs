﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrabajoClases.Src.Data;

#nullable disable

namespace TrabajoClases.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("TrabajoClases.Src.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Precio")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TiendaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TiendaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("TrabajoClases.Src.Models.Tienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tiendas");
                });

            modelBuilder.Entity("TrabajoClases.Src.Models.Producto", b =>
                {
                    b.HasOne("TrabajoClases.Src.Models.Tienda", null)
                        .WithMany("productos")
                        .HasForeignKey("TiendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrabajoClases.Src.Models.Tienda", b =>
                {
                    b.Navigation("productos");
                });
#pragma warning restore 612, 618
        }
    }
}
