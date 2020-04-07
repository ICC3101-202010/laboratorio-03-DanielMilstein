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
                            string actsku = Console.ReadLine();
                            foreach (var item in uandes.GetInventory())
                            {
                                if (item.GetSKU() == actsku)
                                {
                                    Product newstock = item;
                                    uandes.ShipmentArrived(newstock);
                                }

                            }


                        }
                        else if (input == "3")
                        {
                            List<Product> listado = uandes.GetInventory();
                            string a = "SKU"; string b = "Nombre"; string c = "Marca"; string d = "Precio"; string e = "Stock";
                            Console.WriteLine("{0,-30} {1,-20} {2,-10} {3,0} {4,10}", a, b, c, d, e);
                            foreach (var item in listado)
                            {
                                Console.WriteLine("{0,-30} {1,-20} {2,-10} {3,0} {4,10}",
                                item.GetSKU(), item.GetName(), item.GetBrand(), item.GetPrice(), item.GetStock());

                            }

                        }
                    }
                }

                else if (input == "2")
                {
                    int submenu = 1;
                    while (submenu != 0)
                    {
                        Console.WriteLine("2.1.- Agregar empleado nuevo.");
                        Console.WriteLine("2.2.- Cambiar sueldo empleado.");
                        Console.WriteLine("2.3.- Cambiar puesto empleado.");
                        Console.WriteLine("2.4.- Cambiar horario empleado.");
                        Console.WriteLine("2.5.- Ver empleados.");
                        Console.WriteLine("0.- Retroceder");
                        Console.WriteLine("Ingrese una opcion:");
                        input = Console.ReadLine();


                        if (input == "0") { submenu = 0; }

                        else if (input == "1")
                        {
                            Console.WriteLine("Nombre del empleado:");
                            string empname = Console.ReadLine();
                            Console.WriteLine("Apellido:");
                            string emplast = Console.ReadLine();
                            Console.WriteLine("Nacionalidad:");
                            string empnat = Console.ReadLine();
                            Console.WriteLine("Rut:");
                            string emprut = Console.ReadLine();
                            Console.WriteLine("Fecha de nacimiento:");
                            string empdob = Console.ReadLine();
                            Console.WriteLine("Cargo:");
                            string empjob = Console.ReadLine();
                            Console.WriteLine("Sueldo:");
                            string empsalary = Console.ReadLine();
                            Console.WriteLine("Horario:");
                            string empworkh = Console.ReadLine();

                            Employee empl = new Employee(empname, emplast, empnat, emprut, empdob, empjob, empsalary, empworkh);
                            uandes.Hire(empl);
                        }

                        else if (input == "5")
                        {
                            List<Employee> listado = uandes.GetEmployees();
                            string a = "Nombre"; string b = "Apellido"; string c = "Nacionalidad"; string d = "Rut";
                            string e = "Fecha de nacimiento"; string f = "Cargo"; string g = "Sueldo"; string h = "Horario";
                            Console.WriteLine("{0,-30} {1,-20} {2,-10} {3,0} {4,10} {5,15} {6,20} {7,25}", a, b, c, d, e, f, g, h);
                            foreach (var item in listado)
                            {
                                Console.WriteLine("{0,-30} {1,-20} {2,-10} {3,0} {4,10} {5,15} {6,20} {7,25}",
                                item.GetName(), item.GetLast(), item.GetNationality(), item.GetRut(), item.GetDoB(), item.GetJob(),
                                item.GetSalary(), item.GetWHours());

                            }
                        }
                    }
                }
            }
        }
    }
}
