using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildTheWall_mart
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Build the Wall_mart!");
            Wall_mart uandes = new Wall_mart();
            string getback = "0.- Retroceder";
            int menu = 1;

            while (menu != 0)
            {
                Console.WriteLine("1.- Productos");
                Console.WriteLine("2.- Empleados");
                Console.WriteLine("3.- Clientes");
                Console.WriteLine("4.- Ventas");
                Console.WriteLine("5.- Simulacion");
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
                        Console.WriteLine(getback);
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
                        Console.WriteLine("2.2.- Cambiar datos de empleado.");
                        Console.WriteLine("2.3.- Ver empleados.");
                        Console.WriteLine(getback);
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

                        else if (input == "3")
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

                        else if (input == "2")
                        {
                            Console.WriteLine("Ingrese el rut del empleado.");
                            string actrut = Console.ReadLine();
                            foreach (var item in uandes.GetEmployees())
                            {
                                if (item.GetRut() == actrut)
                                {
                                    int subsubmenu = 1;
                                    while (subsubmenu != 0)
                                    {
                                        Console.WriteLine("2.2.1.- Cambiar cargo");
                                        Console.WriteLine("2.2.2.- Cambiar sueldo");
                                        Console.WriteLine("2.2.3.- Cambiar horario.");
                                        Console.WriteLine(getback);
                                        Console.WriteLine("Ingrese una opcion:");
                                        input = Console.ReadLine();


                                        if (input == "0") { subsubmenu = 0; }

                                        else if (input == "1")
                                        {
                                            Console.WriteLine("Ingrese nuevo cargo.");
                                            string nwjob = Console.ReadLine();
                                            item.ChangeJob(nwjob);
                                        }

                                        else if (input == "2")
                                        {
                                            Console.WriteLine("Ingrese nuevo sueldo.");
                                            string nwsal = Console.ReadLine();
                                            item.ChangeSalary(nwsal);
                                        }

                                        else if (input == "3")
                                        {
                                            Console.WriteLine("Ingrese nuevo horario.");
                                            string nwwh = Console.ReadLine();
                                            item.ChangeWHours(nwwh);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Empleado no encontrado.");
                                }
                            }
                        }
                    }
                }

                else if (input == "3")
                {
                    int submenu = 1;
                    while (submenu != 0)
                    {

                        Console.WriteLine("3.1.- Agregar cliente nuevo.");
                        Console.WriteLine("3.2.- Ver lista de clientes.");
                        Console.WriteLine("3.3.- Usar cliente.");
                        Console.WriteLine(getback);
                        Console.WriteLine("Ingrese una opcion:");
                        input = Console.ReadLine();

                        if (input == "0") { submenu = 0; }
                        else if (input == "1")
                        {
                            Console.WriteLine("Nombre del cliente:");
                            string cusname = Console.ReadLine();
                            Console.WriteLine("Apellido:");
                            string cuslast = Console.ReadLine();
                            Console.WriteLine("Nacionalidad:");
                            string cusnat = Console.ReadLine();
                            Console.WriteLine("Rut:");
                            string cusrut = Console.ReadLine();
                            Console.WriteLine("Fecha de nacimiento:");
                            string cusdob = Console.ReadLine();

                            Customer cust = new Customer(cusname, cuslast, cusnat, cusrut, cusdob);
                            uandes.AddCustomer(cust);
                        }

                        else if (input == "2")
                        {
                            List<Customer> listado = uandes.GetCustomers();
                            string a = "Nombre"; string b = "Apellido"; string c = "Nacionalidad"; string d = "Rut";
                            string e = "Fecha de nacimiento"; string f = "Cantidad de productos en el carro";
                            Console.WriteLine("{0,-30} {1,-20} {2,-10} {3,0} {4,10} {5,15}", a, b, c, d, e, f);
                            foreach (var item in listado)
                            {
                                Console.WriteLine("{0,-30} {1,-20} {2,-10} {3,0} {4,10} {5,15}",
                                item.GetName(), item.GetLast(), item.GetNationality(), item.GetRut(), item.GetDoB(), item.GetCart().Count());

                            }

                        }

                        else if (input == "3")
                        {

                            
                            string actrut = null;
                            int submenu3 = 1;
                            Customer actcust = null;
                            while (actrut == null)
                            {
                                try
                                {
                                    Console.WriteLine("Ingrese el rut del cliente:");
                                    actrut = Console.ReadLine();
                                    actcust = uandes.GetCustomers().Find(x => x.GetRut() == actrut);
                                    actcust.GetFullName(); //Trigger de la excepcion.

                                }

                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("Este cliente no existe.");
                                    Console.WriteLine("Para crear un nuevo cliente regrese al menu cliente ingresando 0.");
                                    Console.WriteLine("Si desea ingresar otro rut presione 1.");
                                    string exinp = Console.ReadLine();
                                    if (exinp == "0") { actrut = "asd"; submenu3 = 2; }

                                    else if (exinp == "1")
                                    {
                                        actrut = null;
                                    }
                                }
                            }

                            
                            while (submenu3 == 1)
                            {

                                Console.WriteLine("3.3.1.- Agregar producto al carro.");
                                Console.WriteLine("3.3.2.- Sacar producto del carro.");
                                Console.WriteLine("3.3.3.- Finalizar compra.");
                                Console.WriteLine(getback);

                                input = Console.ReadLine();

                                if (input == "0") { submenu3 = 0; }
                                else if (input == "1")
                                {
                                    Console.WriteLine("Ingrese SKU del producto");
                                    string actsku = Console.ReadLine();
                                    Product wanted = uandes.GetInventory().Find(x => x.GetSKU() == actsku);
                                    actcust.AddToCart(wanted);
                                }

                                else if (input == "2")
                                {
                                    Console.WriteLine("Ingrese SKU del producto");
                                    string actsku = Console.ReadLine();
                                    Product wanted = uandes.GetInventory().Find(x => x.GetSKU() == actsku);
                                    actcust.RemoveFromCart(wanted);
                                }

                                else if (input == "3")
                                {
                                    if (actcust.GetCart().Count() == 0)
                                    {
                                        Console.WriteLine("Carro vacio!");
                                    }
                                    else
                                    {
                                        Employee cajero = null;
                                        List<Employee> cajeros = null;
                                        
                                        cajeros= uandes.GetEmployees().FindAll(x => x.GetJob() == "cajero");
                                        if (cajeros.Count() == 0)
                                        {
                                            Console.WriteLine("No hay cajeros disponibles, debe contratar a uno.");
                                            break;
                                        }
                                        else
                                        {
                                            Random randgen = new Random();
                                            int rand = randgen.Next(cajeros.Count());
                                            cajero = cajeros[rand];
                                            Sale compra = new Sale(actcust, cajero);
                                            uandes.Sell(compra);
                                            int r = uandes.GetSales().FindIndex(x => x == compra);
                                            compra.PrintReciept(r);
                                            submenu3 = 0;
                                        }
                                    }

                                }

                            }

                        }
                    }
                }
            

        
                else if (input == "4")
                {

                    int submenu = 1;
                    while (submenu == 1)
                    {
                        Console.WriteLine("4.1.- Ver ventas");
                        Console.WriteLine(getback);
                        input = Console.ReadLine();

                        if (input == "0") { submenu = 0; }

                        else if (input == "1")
                        {
                            foreach (Sale item in uandes.GetSales())
                            {
                                item.PrintReciepts();

                            }
                        }
                    }

                }

                else if (input == "5")
                {
                    Customer a = new Customer("Daniel", "Milstein", "Chile", "1", "05/10/1993");

                    Customer b = new Customer("Andres", "Howard", "Chile", "2", "05/10/1993");

                    Customer c = new Customer("Carlos", "Diaz", "Chile", "3", "05/10/1993");

                    Customer d = new Customer("Alvaro", "Cespedes", "Chile", "4", "05/10/1993");

                    Customer e = new Customer("Antonia", "Carrizo", "Chile", "5", "05/10/1993");

                    Customer f = new Customer("Benjamin", "Morgan", "Chile", "6", "05/10/1993");

                    Customer g = new Customer("Camila", "Villalobos", "Chile", "7", "05/10/1993");

                    Customer h = new Customer("Carlo", "Vitali", "Chile", "8", "05/10/1993");

                    Customer i = new Customer("Carlos", "Akel", "Chile", "9", "05/10/1993");

                    Customer j = new Customer("Carmen", "Benavente", "Chile", "10", "05/10/1993");

                    Customer k = new Customer("Cristian", "Vera", "Chile", "11", "05/10/1993");

                    Customer l = new Customer("Cristobal", "Neira", "Chile", "12", "05/10/1993");

                    Customer m = new Customer("Daniel", "Saavedra", "Chile", "13", "05/10/1993");

                    Customer n = new Customer("Diego", "Riedel", "Chile", "14", "05/10/1993");

                    Customer o = new Customer("Diego", "Pinochet", "Chile", "15", "05/10/1993");

                    Customer p = new Customer("Ernesto", "Camus", "Chile", "16", "05/10/1993");

                    Customer q = new Customer("Francisco", "De la maza", "Chile", "17", "05/10/1993");

                    Customer r = new Customer("Felipe", "Cueto", "Chile", "18", "05/10/1993");

                    Customer s = new Customer("Francisco", "Miranda", "Chile", "19", "05/10/1993");

                    Customer t = new Customer("Franco", "Cruzat", "Chile", "20", "05/10/1993");

                    Customer u = new Customer("Ignacio", "Perrotta", "Chile", "21", "05/10/1993");



                }
            }
        }
    }
}
