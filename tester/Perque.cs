using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
    class Perque
    {
        private int max = 10;
        private  Person[] persons;
        private int tail = 0;
        private int head = 0;
        private int countPerson = 0;

        public Perque()
        {
            persons = new Person[max];
        }

        public Perque(int size)
        {
            max = size;
            persons = new Person[max];
        }

        public void Enq(string name, int age, float amount)
        {
            Person create_person = new Person(name, age, amount);
            persons[tail] = create_person;
            tail = tail + 1;
            countPerson++;
            if (tail == max)
            {
                tail = 0;
            }
        }

        public Person deq()
        {
            Person remove_person = persons[head];
            head = head + 1;
            countPerson--;

            return remove_person;
        }

        public int Count()
        {
            return countPerson;
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            for (int i=head; i<=tail-1; i++)
            {
                output.Append(persons[i].GetInfo());
            }
            return output.ToString();
        }

    }
}
