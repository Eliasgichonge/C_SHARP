using System;
namespace PersonExample
{
    // Define the Person class
    class Person
    {
        // Properties
        public string Name {get; set;}
        public int Age {get; set;}

        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine("$Name: {Name}, Age: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // creation of an instance of te person class
            Person person = new Person();

            // set properties
            person.Name = "Alice";
            person.Age = 30;


            // call the method to display
            person.DisplayDetails();
        }
    }
}