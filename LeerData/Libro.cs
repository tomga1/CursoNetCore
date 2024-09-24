using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace LeerData
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string ?Titulo { get; set;}
        public string ?Descripcion { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
        public byte[] ?FotoPortada { get; set; }
        public Precio ?PrecioPromocion { get; set; }  
    }
}

