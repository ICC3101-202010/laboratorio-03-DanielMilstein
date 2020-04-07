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
            double price1 = Convert.ToDouble(price);
            Price = price1;
            int stock1 = Convert.ToInt32(stock);
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
                int y = Convert.ToInt32(x);
                Stock += y;
                
            }
        }
    }




}
