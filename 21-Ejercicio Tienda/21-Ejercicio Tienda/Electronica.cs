using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Ejercicio_Tienda
{
    internal class Electronica : Producto
    {
       public int MesesGarantia {  get; set; }

        public Electronica(string nombre, int stock, double precio,
            CategoriaProducto categoria,int mesesgarantia) 
            :base(nombre,stock,precio,categoria)
        { 
            this.MesesGarantia = mesesgarantia;
        }
        public override void MostrarFichaTecnica()
        {
            Console.WriteLine($"--- [{Categoria}] ---");
            Console.WriteLine($"Producto: {Nombre} (Garantia de: {MesesGarantia} Meses)");
            Console.WriteLine($"Precio: ${Precio}");
            Console.WriteLine($"Stock: {Stock} unidades");
        }
    }
}
