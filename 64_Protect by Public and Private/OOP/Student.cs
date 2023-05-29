using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        private int Age;
        private string Name;
        private float Grade;

        public Student(int Age, string Name, float Grade)
        {
            this.Age = Age;
            this.Name = Name;
            this.Grade = Grade;
        }

        public Student(int Age, string Name) : this(Age, Name, 0)
        {

        }

        public void sayHello() //Method
        {
            Console.WriteLine("Hello! {0}", Name);
        }

        public string getName()
        {
            if (Age >= 18)
            {
                return Name;
            }
            else
            {
                return "No Access!";
            }
        }

        public void setName(string newName)
        {
            if (Name != "")
            {
                Name = newName;
            }
        }

        public int getAge()
        {
            if (Age >= 18)
            {
                return Age;
            }
            else
            {
                return -1;
            }

        }

        public void setAge(int newAge)
        {
            if (newAge != 0)
            {
                Age = newAge;
            }
        }

        public float getGrade()
        {
            return Grade;
        }

        public void setGrade(float newGrade)
        {
            if (newGrade < 65)
            {
                newGrade = 65;
            }
            else if(newGrade > 100)
                    {
                newGrade = 100;
            }
            Grade = newGrade;
            
        }


    }
}
