using System;
using System.Collections.Generic;

namespace BuildTheWall_mart
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Build the Wall_mart!");
            Wall_mart uandes = new Wall_mart();

            int menu = 1;

            while (menu != 0)
            {
                Console.WriteLine("1.- Productos");
                Console.WriteLine("2.- Empleados");
                Console.WriteLine("3.- Ventas");
                Console.WriteLine("4.- Clientes");
                Console.WriteLine("0.- Salir");

                Console.WriteLine("Ingrese una opcion:");
                string input = Console.ReadLine();
                if (input == "0") { menu = 0; }

                else if (input == "1")
                {
                    int submenu = 1;
                    while (submenu != 0)
                    {

                        Console.WriteLine("1.1.- Agregar producto nuevo.");
                        Console.WriteLine("1.2.- Agregar stock a producto existente.");
                        Console.WriteLine("1.3.- Ver lista de productos con stock.");
                        Console.WriteLine("0.- Retroceder");
                        Console.WriteLine("Ingrese una opcion:");
                        input = Console.ReadLine();

                        if (input == "0") { submenu = 0; }
                        else if (input == "1")
                        {
                            Console.WriteLine("Nombre del producto:");
                            string prodname = Console.ReadLine();
                            Console.WriteLine("Marca del producto:");
                            string prodbrand = Console.ReadLine();
                            Console.WriteLine("Precio del producto:");
                            string prodprice = Console.ReadLine();
                            Console.WriteLine("Stock inicial del producto:");
                            string prodstock = Console.ReadLine();
                            Console.WriteLine("SKU del producto:");
                            string prodsku = Console.ReadLine();

                            Product x = new Product(prodname, prodbrand, prodprice, prodstock, prodsku);
                            uandes.AddProduct(x);
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("A que producto quieres agregar stock?\nIngrese SKU:");
                        }
                        else if (input == "3")
                        {
                            List<Product> listado = uandes.GetInventory();
                            Console.WriteLine("SKU\t Nombre\t Marca\t Precio\t Stock\n");
                            foreach (var item in listado)
                            {
                                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t",
                                item.GetSKU(), item.GetName(), item.GetBrand(), item.GetPrice(), item.GetStock());

                            }

                        }
                     }
                }
            }
        }
    }
}
