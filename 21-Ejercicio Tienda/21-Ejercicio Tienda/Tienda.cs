using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Ejercicio_Tienda
{
    public class Tienda
    {
        private List<Producto> inventario;

        public Tienda()
        {
         //crea la lista vacia para q puedan guardar el producto en inventario
            inventario = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            inventario.Add(producto);
        }

        public void MostrarInventario()
        {
            foreach(Producto p in inventario)
            {
                p.MostrarFichaTecnica();
            }
        }
    }
}
