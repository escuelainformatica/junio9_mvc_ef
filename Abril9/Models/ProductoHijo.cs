using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abril9.Models
{
    public class ProductoHijo  : Producto
    {
        public override Categoria IdCategoriaNavigation { get; set; }
    }
}
