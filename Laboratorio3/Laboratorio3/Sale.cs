using System;
using System.Collections.Generic;

namespace BuildTheWall_mart
{
    public class Sale
    {
        protected Customer Customer;
        protected Employee Cashier;
        protected double Total;
        protected List<Product> ListOfProducts;
        protected DateTime DateAndTime;
        protected int NdeBoleta;


        public Sale(Customer customer, Employee cashier)
        {
            Customer = customer;
            Cashier = cashier;
            ListOfProducts = Customer.GetCart();
            DateAndTime = DateTime.Now;
            double total = 0;
            foreach (Product item in ListOfProducts)
            {
                total += item.GetPrice();
            }

            Total = total;
            Customer.EmptyCart();
            int ndeBoleta = 0;
            NdeBoleta = ndeBoleta;
        }

        public void PrintReciept(int x)
        {

            string a = "Producto";
            string b = "Precio";
            NdeBoleta = x + 1;
            Console.WriteLine("Boleta N˚ {0}", NdeBoleta);
            Console.WriteLine("Cliente: {0}", Customer.GetFullName());
            Console.WriteLine("Cajero: {0}\n", Cashier.GetFullName());
            Console.WriteLine("Fecha: {0}\n", DateAndTime);
            Console.WriteLine("{0,-20} {1,10}", a, b);

            foreach (Product item in ListOfProducts)
            {
                Console.WriteLine("{0,-20} {1,10}", (item.GetName() + " " + item.GetBrand()), item.GetPrice());

            }
            Console.WriteLine("Total: {0,10}", Total);
        }

        public void PrintReciepts()
        {

            string a = "Producto";
            string b = "Precio";
            Console.WriteLine("Boleta N˚ {0}", NdeBoleta);
            Console.WriteLine("Cliente: {0}", Customer.GetFullName());
            Console.WriteLine("Cajero: {0}\n", Cashier.GetFullName());
            Console.WriteLine("Fecha: {0}\n", DateAndTime);
            Console.WriteLine("{0,-20} {1,10}", a, b);

            foreach (Product item in ListOfProducts)
            {
                Console.WriteLine("{0,-20} {1,10}", (item.GetName() + " " + item.GetBrand()), item.GetPrice());

            }
            Console.WriteLine("Total: {0,10}\n", Total);
        }


    }
}
