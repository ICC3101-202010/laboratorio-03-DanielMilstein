using System;
namespace BuildTheWall_mart
{
    public class Product
    {
        protected string Name;
        protected string Brand;
        protected double Price;
        protected int Stock;
        protected string SKU;

        public Product(string name, string brand, string price, string stock, string sku)
        {
            Name = name;
            Brand = brand;
            int a = 1;
            double price1 = 0;
            int stock1 = 0;
            while (a == 1)
            {
                try
                {
                    price1 = Convert.ToDouble(price);
                    a = 2;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Precio debe ser un numero.");
                    price = Console.ReadLine();
                }
            }

            Price = price1;
            while (a == 2)
            {
                try
                {
                    stock1 = Convert.ToInt32(stock);
                    a = 3;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Stock debe ser un numero entero.");
                    stock = Console.ReadLine();
                }


            }

            
            Stock = stock1;
            SKU = sku;
        }


        public int GetStock()
        {
            return Stock;
        }


        public string GetName()
        {
            return Name;
        }

        public string GetBrand()
        {
            return Brand;
        }

        public double GetPrice()
        {
            return Price;
        }

        public string GetSKU()
        {
            return SKU;
        }

        public void ChangeStock(string act)
        {
            if (act == "add to cart")
            {
                Stock -= 1;
            }
                
            else if (act == "remove from cart")
            {
                Stock += 1;
            }

            else if (act == "incoming shipment")
            {
                Console.WriteLine("Cuantas unidades quieres agregar?");
                string x = Console.ReadLine();
                int j = 1;
                while (j == 1)
                {
                    try
                    {
                        int y = Convert.ToInt32(x);
                        Stock += y;
                        j = 2;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Stock debe ser un entero");
                        x = Console.ReadLine();
                    }
                }
            }
        }
    }




}
