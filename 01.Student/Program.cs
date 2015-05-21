//01.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, 
//   university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), 
//   ToString(), GetHashCode() and operators == and !=.

//02.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

//03.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number 
//   (as second criteria, in increasing order).


namespace _01.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Student student = new Student("Pesho", "Peshev", "Peshev", "415125122", "Atanas Donchev st. No32", "0891235512", "peshoto@abv.bg",
                                          "OOP", University.SU, Speciality.ComputerScience, Faculty.InformaticsAndMathematics);
            Console.WriteLine(student);

            Student copy = student.Clone() as Student;

            Console.WriteLine(new string('-', 25));
            Console.WriteLine(copy);

            Console.WriteLine(new string('-', 25));
            Console.WriteLine(student.CompareTo(copy)); //They are absolutely the same => must return 0
        }
    }
}
