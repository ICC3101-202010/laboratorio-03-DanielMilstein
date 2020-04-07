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



        public Sale(Customer customer)
        {
            Customer = customer;




            Employee cashier = null; //Pendiente
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
        }

        public void PrintReciept()
        {

            string a = "Producto";
            string b = "Precio";
            Console.WriteLine("Cliente: {0}", Customer);
            Console.WriteLine("Cajero: {0}\n", Cashier);
            Console.WriteLine("Fecha: {0}\n", DateAndTime);
            Console.WriteLine("{0,-10} {1,0}", a, b);

            foreach (Product item in ListOfProducts)
            {
                Console.WriteLine("{0,-10} {1,0}", (item.GetName() + " " + item.GetBrand()), item.GetPrice());

            }
        }
    }
}
