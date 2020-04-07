using System;
namespace BuildTheWall_mart
{
    public abstract class Person
    {
        protected string Name;
        protected string LastName;
        protected string Nationality;
        protected string Rut;
        protected string DateOfBirth;


        public Person(string name, string lastName, string nationality, string rut, string dateOfBirth)
        {
            Name = name;
            LastName = lastName;
            Nationality = nationality;
            Rut = rut;
            DateOfBirth = dateOfBirth;

        }

        public string GetFullName()
        {
            string a = Name + LastName;
            return a;
        }

        public string GetName() { return Name; }
        public string GetLast() { return LastName; }
        public string GetNationality() { return Nationality; }
        public string GetRut() { return Rut; }
        public string GetDoB() { return DateOfBirth; }
    }
}
