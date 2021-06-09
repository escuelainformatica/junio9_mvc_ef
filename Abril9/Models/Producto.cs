using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Abril9.Models
{
    // Productos -> Producto
    // [Table("Productos")]
    // Que es una clase partial? es una clase que puede definirse en diferentes archivos.
    public partial class Producto
    {
        
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int? PrecioUnitario { get; set; }
        public int? Cantidad { get; set; }
        public int? IdCategoria { get; set; }

        // llave foranea (esto es una relacion muchos es a uno)

        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
