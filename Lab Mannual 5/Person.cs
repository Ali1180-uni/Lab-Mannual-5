using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Mannual_5
{
    internal class Person
    {
        private string name;
        private int age;
        private bool check;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            check = false;
        }
        public Person(Person data)
        {
            this.name = data.name;
            this.age = data.age;
            check = false;
        }

        public void displaydetails()
        {
            Console.WriteLine($"The Name is: {name}");
            Console.WriteLine($"The Age is: {age}");
        }

        public void setname(string name)
        {
            this.name=name;
        }
        public void setage(int age)
        {
            this.age = age;
        } 

        public string getname()
        {
            return this.name;
        }

        public int getage()
        {
            return this.age;
        }

        public void IsAdult()
        {
            if (this.age >= 18)
            {
                this.check = true;
            }
            else
            {
                this.check = false;
            }
        }
        public void CelebrateBirthday()
        {
            this.age++;
        }
    }
}
