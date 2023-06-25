using System;

namespace concole_1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }

        public Person(string name,  string surname, int age, decimal weight, decimal height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }

    }
    public override string ToString()
    { 
        return $"name : {name}, Surname : {surname},  Age : {age}, Weight : {weight}, Height : {height}"
    } 
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person=new Person("Sophie", "Neveu", 30, 1.70m, 65m);
            Console.WriteLine(person);
        }
    }
}