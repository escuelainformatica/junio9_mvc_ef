using System;
using System.Collections.Generic;

#nullable disable

namespace Abril9.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }


        // categoria se asocia a producto con la relacion uno es a muchos.
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
