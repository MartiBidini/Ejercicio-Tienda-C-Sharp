using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Ejercicio_Tienda
{
    public abstract class Producto
    {
        public string Nombre {  get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public CategoriaProducto Categoria { get; set; }

        public Producto(string nombre, int stock, double precio, 
            CategoriaProducto categoria)
        {
            this.Nombre = nombre;
            this.Stock = stock;
            this.Precio = precio;
            Categoria = categoria;
        }
        public abstract void MostrarFichaTecnica();
    }
}
