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
            var db = new AppVentaLibrosContext();
            
                var link = new LibroAutor{
                    
                };
                var nuevoAutor = new Autor{
                    Nombre = "Alan",
                    Apellidos = "Ursi",
                    Grado = "Hijo",  
                };


                db.Add(nuevoAutor);
                var estadoTransaccion = db.SaveChanges();

                Console.WriteLine("Cantidad de transacciones ===> " + estadoTransaccion);

        }

        }
    }
