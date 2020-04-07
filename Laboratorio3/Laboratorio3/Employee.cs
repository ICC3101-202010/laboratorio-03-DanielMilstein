using System;
namespace BuildTheWall_mart
{
    public class Employee : Person
    {
        protected string Job;
        protected float Salary;
        protected string WorkingHours; 


        public Employee(string name, string lastName, string nationality, string rut, string dateOfBirth,
            string job, float salary, string workingHours) : base(name, lastName, nationality, rut, dateOfBirth)
        {
            Job = job;
            Salary = salary;
            WorkingHours = workingHours;

        }

    }
}
