using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Ejercicio_Tienda
{
    internal class Ropa:Producto
    {
        public string Talle {  get; set; }
        public Ropa(string nombre,int stock,double precio,
            CategoriaProducto categoria,string talle)
           :base(nombre,stock,precio,categoria)
        {
            this.Talle = talle;
        }
        public override void MostrarFichaTecnica()
        {
          Console.WriteLine($"--- [{Categoria}] ---");
          Console.WriteLine($"Producto: {Nombre} (Talle: {Talle})");
          Console.WriteLine($"Precio: ${Precio}");
          Console.WriteLine($"Stock: {Stock} unidades");
        }
    }
}
