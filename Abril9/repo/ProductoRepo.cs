using Abril9.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abril9.repo
{
    // clase de servicio que hace operaciones en la base de datos
    public class ProductoRepo
    {
        public static List<Producto> ListarTodo()
        {
            var resultado=new List<Producto>();
            // 1) conectar a la base de datos <-- ok
            // 2) leer los productos
            // 3) cerrar la conexion <-- ok
            using(var contexto=new Base9JunioContext())
            { 
                resultado=contexto
                    .Productos // Lista de productos
                    .Include( p => p.IdCategoriaNavigation) // incluir los datos de la categoria
                    .OrderBy( producto => producto.Nombre) // p correspode a una fila (p corresponde a un producto)
                    .ToList(); // devuelvo los resultados como una lista
                   // select * from productos order by nombre
            } // cierra la conexion

            // p=>p.Nombre es una operacion LAMBDA  
            // p entonces p.nombre
            // p es un alias?.

            return resultado;

        }
    }
}
