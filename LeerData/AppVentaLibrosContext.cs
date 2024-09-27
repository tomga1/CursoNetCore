using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace LeerData
{
    public class AppVentaLibrosContext : DbContext
    {
        private const string connectionString = @"Data Source=sis-05\sqlexpress; Initial Catalog=LibrosWeb; Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<LibroAutor>().HasKey(xi => new{xi.AutorId, xi.LibroId});
        } 

        public DbSet<Libro>? Libro {get;set;}
        public DbSet<Precio>? Precio {get;set;} 
        public DbSet<Comentario>? Comentario{get;set;}
        public DbSet<Autor>? Autor{get;set;}
        public DbSet<LibroAutor>? LibroAutor{get;set;}
    }
}  