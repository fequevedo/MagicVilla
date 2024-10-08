﻿using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDBcontext: DbContext
    {

        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) :base(options) 
        {
            
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(

                new Villa()
                {

                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la villa...",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 50,
                    Tarifa = 200,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now
                },
                new Villa()
                {

                    Id = 2,
                    Nombre = "Premium Vista a la piscina",
                    Detalle = "Detalle de la villa...",
                    ImagenUrl = "",
                    Ocupantes = 4,
                    MetrosCuadrados = 40,
                    Tarifa = 150,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now
                }

            );
        }
    }
}
