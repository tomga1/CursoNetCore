using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaLibrosContext())
            {
                var libros = db.libro?.Include(x => x.PrecioPromocion).AsNoTracking();

                if(libros != null)
                {
                    foreach(var libro in libros)
                {
                    Console.WriteLine(libro.Titulo + " ---- " + libro.PrecioPromocion?.PrecioActual);
                }
                }

                else
                {
                    Console.WriteLine("No hay libros disponibles !");
                }

                

            }
        }
    }
}