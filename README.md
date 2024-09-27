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