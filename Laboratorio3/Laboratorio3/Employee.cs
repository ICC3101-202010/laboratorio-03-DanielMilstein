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
            double salary1 = Convert.ToDouble(salary);
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
