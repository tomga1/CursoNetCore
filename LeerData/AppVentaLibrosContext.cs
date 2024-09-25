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

        public DbSet<Libro>? Libro {get;set;}
        public DbSet<Precio>? Precio {get;set;} 
        public DbSet<Comentario>? Comentario{get;set;}
    }
}  