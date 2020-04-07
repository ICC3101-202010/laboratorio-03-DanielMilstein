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
        }
    }
}
