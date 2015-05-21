namespace _04Person
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age = -1;

        public Person(string name, int age) : this (name)
        {
            if (age <= 0 || age >=100)
            {
                throw new ArgumentException("Age must be  between 0 and 100(including)f.");
            }

            this.age = age;
        }

        public Person(string name)
        {
            if (name == string.Empty)
            {
                throw new ArgumentException("Invalid name input!");
            }

            this.name = name;
            this.age = -1;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(String.Format("Name: {0}",this.name));
            string ageInfo;
            if (this.age != -1 )
	        {
		        ageInfo = this.age.ToString();
	        }
            else
	        {
                ageInfo = "not specified";
           	}

            info.AppendLine(String.Format("Age: {0}", ageInfo));
            return info.ToString();
        }
    }
}
