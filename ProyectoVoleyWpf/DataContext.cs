using Microsoft.EntityFrameworkCore;
using ProyectoVoleyWpf.Modelo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProyectoVoleyWpf
{
    class DataContext : DbContext
    {

        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Cuota> Cuotas { get; set; }

        public DbSet<Jugador> Jugadores { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(connectionString: "Filename= DbProyectoVoley.db", sqliteOptionsAction:
               op =>
               {
                   op.MigrationsAssembly(

                      Assembly.GetExecutingAssembly().FullName);


               });

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Administrador>().ToTable("Administradores");
            modelBuilder.Entity<Cuota>().ToTable("Cuotas");
            modelBuilder.Entity<Jugador>().ToTable("Jugadores");


            modelBuilder.Entity<Cuota>().HasOne(x => x.Jugador).WithMany(z => z.Cuotas).HasForeignKey(c => c.IdJugador);


            base.OnModelCreating(modelBuilder);


        }
    }

}
