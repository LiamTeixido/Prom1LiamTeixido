using Promedio1LiamTeixido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            List<Product> availableproducts = new List<Product>
        {
            new ProductCloth("Bufanda", 15, "Verde", 200, "Algodón", 30),
            new ProductClay("Jarrón", 29, "Rojo", 300, "Barro", 50),
        };


            while (true)
            {
                Console.WriteLine("Bienvenido a la tienda");
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Agregar producto al carrito");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar la compra");
                Console.WriteLine("4. Salir");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.WriteLine("Lista de productos disponibles:");
                        for (int i = 0; i < availableproducts.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {availableproducts[i].GetName()}");
                        }

                        Console.Write("Seleccione el número del producto que desea agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int selection))
                        {
                            if (selection >= 1 && selection <= availableproducts.Count)
                            {
                                Product sProduct = availableproducts[selection - 1];
                                shop.AddProduct(sProduct);
                                Console.WriteLine($"Producto '{sProduct.GetName()}' agregado al carrito.");
                            }
                            else
                            {
                                Console.WriteLine("Número de producto no válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Ingrese un número.");
                        }
                        break;


                    case "2":
                        shop.ShowProducts();
                        break;

                    case "3":
                        Console.WriteLine("Compra finalizada. Detalles de la compra:");
                        shop.ShowProducts();
                        Console.WriteLine("¿Desea crear un nuevo carrito de compras? (Si/No)");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "Si")
                        {
                            shop.ClearShoppingCar();
                        }
                        else if (answer.ToLower() == "No")
                        {
                            Console.WriteLine("Gracias por comprar. Hasta luego.");
                            return;
                        }
                        break;

                    case "4":
                        Console.WriteLine("Gracias por usar nuestro sistema. Hasta luego.");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
}
