namespace _01.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum University
    {
        SU, TU, UNSS, NBU
    }

    public enum Speciality
    {
        Informatics, ComputerScience, InformaticSystems, Mathematics,  SoftwareEngeneering, Physics, Chemistry
    }

    public enum Faculty
    {
        InformaticsAndMathematics, PhysicsAndChemistry
    }

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string sSN;
        private string adress;
        private string phone;
        private string email;
        private string course;
        private University university;
        private Speciality speciality;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, string sSN, string adress, string phone, string email, string course,
                        University university, Speciality speciality, Faculty faculty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.sSN = sSN;
            this.adress = adress;
            this.phone = phone;
            this.email = email;
            this.course = course;
            this.university = university;
            this.speciality = speciality;
            this.faculty = faculty;
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() ^ lastName.GetHashCode() ^ sSN.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (this.sSN == (obj as Student).sSN);
        }

        public static bool operator ==(Student stud1, Student stud2)
        {
            return (stud1.sSN == stud2.sSN);
        }

        public static bool operator !=(Student stud1, Student stud2)
        {
            return (stud1.sSN == stud2.sSN);
        }

        public override string ToString()
        {
            string info = String.Format("Student: {0} {1} {2} \nSSN: {3}\nPhone: {4}\nAdress: {5}",
                                         this.firstName,this.middleName,this.lastName,this.sSN,this.phone,this.adress);
            return info;
        }

        public object Clone()
        {
            return new Student(this.firstName, this.middleName, this.lastName, this.sSN, this.adress, this.phone,this.email, this.course, this.university, this.speciality, this.faculty) as object;
           
        }


        public int CompareTo(Student other)
        {
            if (this.firstName != other.firstName)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            else if (this.middleName != other.middleName)
            {
                return this.middleName.CompareTo(other.middleName);
            }
            else if (this.lastName != other.lastName)
            {
                return this.lastName.CompareTo(other.lastName);
            }
            else return this.sSN.CompareTo(other.sSN);
        }
    }
}
