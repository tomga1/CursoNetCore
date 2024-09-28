using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;


namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AppVentaLibrosContext();
            
                var autor = db.Autor?.Single(x => x.AutorId == 8);

                if(autor != null)
                {
                    db.Remove(autor); 
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("Cantidad de registros eliminados ----> " + estadoTransaccion);
                }
        }
        }
    }
