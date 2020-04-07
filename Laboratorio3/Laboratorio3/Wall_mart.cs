using System;
using System.Collections.Generic;
namespace BuildTheWall_mart
{
    public class Wall_mart
    {
        protected List<Employee> Employees;
        protected List<Product> Inventory;
        protected List<Sale> Sales;




        public Wall_mart()
        {

            List<Employee> employees = new List<Employee>();
            Employees = employees;
            List<Product> inventory = new List<Product>();
            Inventory = inventory;
            List<Sale> sales = new List<Sale>();
            Sales = sales;
        }

        public void AddProduct(Product x)
        {
            Inventory.Add(x);

        }

        public void Hire(Employee y)
        {
            Employees.Add(y);
        }

        public void Fire(Employee z)
        {
            Employees.Remove(z);
        }

        public void Sell(Sale a)
        {
            Sales.Add(a);
        }

        public void ShipmentArrived(Product x)
        {
            x.ChangeStock("incoming shipment");
        }

        public List<Product> GetInventory()
        {
            return Inventory;
        }
    }
}
