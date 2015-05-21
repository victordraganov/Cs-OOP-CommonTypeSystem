//04.Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of 
//   a person and if age is not specified – to say so. Write a program to test this functionality.

namespace _04Person
{
    using System;

    class Program
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 18);
            Person sasho = new Person("Sasho");

            Console.WriteLine(pesho);

            Console.WriteLine(new string('-', 25));
            Console.WriteLine(sasho);
           
            Console.WriteLine(new string('-', 25));
        }
    }
}
