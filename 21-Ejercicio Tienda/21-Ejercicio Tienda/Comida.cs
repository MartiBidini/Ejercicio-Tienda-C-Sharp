using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Ejercicio_Tienda
{
    internal class Comida:Producto
    {
        public DateTime FechaVencimiento { get; set; }

        public Comida(string nombre, int stock, double precio,
            CategoriaProducto categoria,DateTime fechavencimiento)
            :base(nombre, stock, precio, categoria)
        {
            this.FechaVencimiento = fechavencimiento;
        }
        public override void MostrarFichaTecnica()
        {
            Console.WriteLine($"--- [{Categoria}] ---");
            Console.WriteLine($"Producto: {Nombre} (Fecha de Vencimiento: {FechaVencimiento})");
            Console.WriteLine($"Precio: ${Precio}");
            Console.WriteLine($"Stock: {Stock} unidades");

        }
    }
}
