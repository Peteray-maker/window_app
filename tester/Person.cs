using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
    class Person
    {
        //members
        private string name;
        private string add;
        private float amount;
        private int age;

        public Person(string name, int age, float amount)
        {
            this.name = name;
            this.amount = amount;
            this.age = age;
        }


        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public float Amount
        {
            get { return amount; }
            set { this.amount = value; }
        }

        public string GetInfo()
        {
            return ("name:" + this.Name + "Age: " + this.Age + "amount: " + this.Amount);
        }
    }
}
