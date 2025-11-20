namespace _21_Ejercicio_Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Tienda");
            Tienda mitienda = new Tienda();

          Ropa remera = new Ropa("Remera Nike", 5, 79.99, CategoriaProducto.Ropa, "L");
          Comida manzana = new Comida("Manzana Roja", 200, 2.50, CategoriaProducto.Comida, new DateTime(2025, 12, 31));
          Electronica tele = new Electronica("Smart TV 55", 10, 500.00, CategoriaProducto.Electronica, 12);
          Ropa pantalon = new Ropa("Pantalon Jordan", 12, 49.99, CategoriaProducto.Ropa, "M");


            mitienda.AgregarProducto(remera);
            mitienda.AgregarProducto(manzana);
            mitienda.AgregarProducto(tele);
            mitienda.AgregarProducto(pantalon);

            mitienda.MostrarInventario();

        }
    }
}
