using System;
using System.Collections.Generic;

namespace BuildTheWall_mart
{
    public class Customer : Person
    {
        protected List<Product> Cart;




        public Customer(string name, string lastName, string nationality, string rut, string dateOfBirth) : base(name, lastName, nationality, rut, dateOfBirth)
        {
            Cart = new List<Product>();
        }

        public void AddToCart(Product x)
        {
            int y = x.GetStock();
            if (y > 0)
            {
                Cart.Add(x);
                x.ChangeStock("add to cart");
                Console.WriteLine("Producto {0} agregado al carro!", x.GetName());
            }
            else
            {
                Console.WriteLine("Producto sin stock.");
            }
        }

        public void RemoveFromCart(Product z)
        {
            if (Cart.Contains(z))
            {
                Cart.Remove(z);
                z.ChangeStock("remove from cart");
                Console.WriteLine("Producto removido del carro.");
            }

            else
            {
                Console.WriteLine("Producto no se encentra en el carro.");
            }
        }

        public List<Product> GetCart()
        {
            return Cart;
        }

        //public Sale Buy()
    }
}
