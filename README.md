# 📦 Proyecto C# Sistema de Inventario Avanzado

Aplicación de consola que simula la gestión de inventario de una tienda, utilizando principios de diseño de software y Programación Orientada a Objetos (POO). El foco está en la creación de objetos especializados y la composición de clases.

---

## 🛠️ Conceptos Clave Demostrados

| Concepto | Explicación | Archivos Clave |
| :---: | :--- | :--- |
| **Composición (Has-A)** | La clase `Tienda` es la propietaria exclusiva del inventario (`private List<Producto> inventario`), ocultando su estructura interna del programa principal (`Main`). | `Tienda.cs`, `Program.cs` |
| **Constructores Sobrecargados 🍕** | Implementación de constructores especializados para clases derivadas (`Ropa` necesita un Talle, `Comida` necesita una Fecha de Vencimiento), manteniendo la obligación del constructor `base`. | `Ropa.cs`, `Comida.cs` |
| **Enumeraciones (`Enums`) 🪐** | Uso de un tipo de dato fijo (`CategoriaProducto`) para clasificar de forma segura los productos de la tienda. | `CategoriaProducto.cs` |
| **Herencia y Polimorfismo** | Uso de la clase `abstract Producto` para forzar a todos los productos a implementar un método `MostrarFichaTecnica()` que exhibe sus datos únicos. | `Producto.cs`, `Ropa.cs`, `Comida.cs` |
| **Propiedades Get/Set** | Uso de propiedades autoimplementadas para garantizar la encapsulación de datos. | `Producto.cs`, `Ropa.cs`, `Comida.cs` |

---

## 💻 Instrucciones de Ejecución

Este proyecto corre en la consola de .NET.

1.  Clonar el repositorio:
    ```bash
    git clone [https://docs.github.com/es/repositories/creating-and-managing-repositories/quickstart-for-repositories](https://docs.github.com/es/repositories/creating-and-managing-repositories/quickstart-for-repositories)
    ```
2.  Abrir el archivo `.sln` en Visual Studio.
3.  Ejecutar la aplicación (F5). El programa crea instancias de `Ropa`, `Comida` y `Electronica` y muestra sus detalles, confirmando el uso correcto del **Polimorfismo**.

---

## 📸 Captura de pantalla

<img width="1470" height="747" alt="image" src="https://github.com/user-attachments/assets/d07ef504-646e-44ed-9220-13103f2990ad" />

