using System;
namespace BuildTheWall_mart
{
    public class Employee : Person
    {
        protected string Job;
        protected double Salary;
        protected string WorkingHours; 


        public Employee(string name, string lastName, string nationality, string rut, string dateOfBirth,
            string job, string salary, string workingHours) : base(name, lastName, nationality, rut, dateOfBirth)
        {
            Job = job;
            double salary1 = 0;
            int a = 1;

            while (a == 1)
            {
                try
                {
                    Convert.ToDouble(salary);
                    a = 2;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Salario debe ser un numero.");
                    salary = Console.ReadLine();
                }
            }

            Salary = salary1;
            WorkingHours = workingHours;

        }


        public string GetJob() { return Job; }
        public double GetSalary() { return Salary; }
        public string GetWHours() { return WorkingHours; }

        public void ChangeJob(string newjob)
        {
            Job = newjob;
        }

        public void ChangeSalary(string newsal)
        {
            double newsal1 = Convert.ToDouble(newsal);
            Salary = newsal1;
        }

        public void ChangeWHours(string newwh)
        {
            WorkingHours = newwh;
        }
    }
}
