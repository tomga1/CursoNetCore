# CursoNetCore

leer datos de distintas tablas , en este caso tabla Autores de cada libro 


*** SELECT *** 
var libros = db.Libro?
                    .Include(x => x.AutoresLink!)
                    .ThenInclude(xi => xi.Autor);

                if (libros != null)
                {
                    foreach (var libro in libros)
                    {
                        Console.WriteLine(libro.Titulo); 
                        if (libro.AutoresLink != null)
                        {
                            foreach (var autlink in libro.AutoresLink)
                            {
                                Console.WriteLine("----" + autlink.Autor?.Nombre);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No hay libros disponibles!");
                }



*** INSERT *** 
                static void Main(string[] args)
        {
            var db = new AppVentaLibrosContext();
            
                var link = new LibroAutor{
                    
                }
                var nuevoAutor = new Autor{
                    Nombre = "Alan",
                    Apellidos = "Ursi",
                    Grado = "Hijo",
                    LibroLink = 
                };


                db.Add(nuevoAutor);
                var estadoTransaccion = db.SaveChanges();

                Console.WriteLine("Cantidad de transacciones ===> " + estadoTransaccion);

        }


***ACTUALIZAR DATA CON ENTITYFRAMEWORK***

using System.Linq;  (importamos la libreria Linq para hcer uso de la propiedad Single)
db.Autor?.Single(x=> x.nombre == "Pedro")  -- 


        static void Main(string[] args)
        {
            var db = new AppVentaLibrosContext();
            
                var autor = db.Autor?.Single(x => x.Nombre == "Pedro");   ---> El metodo Single hace la busqueda enla tabla y nos devuelve el objeto si lo encuentra 

                if(autor != null)
                {
                    autor.Apellidos = "Mendez";
                    autor.Grado = "Biologo";
                    var estadoTransaccion = db.SaveChanges();

                    Console.WriteLine("Cantidad de registros actualizados  -----> " + estadoTransaccion ); 
                }

        }

*** DELETE a la base de datos *** 

se utiliza db.Remove(OBJETO)



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


***    ***