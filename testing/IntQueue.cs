using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class IntQueue
    {
        private int maxsize = 30;
        private int[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems = 0;

        // Default constructor
        public IntQueue()
        {
            store = new int[maxsize];
        }

        // Constructor with a specified maximum size
        public IntQueue(int size)
        {
            maxsize = size;
            store = new int[maxsize];
        }

        public void Enqueue(int value)
        {
            store[tail] = value;
            tail = tail + 1;
            numItems++;
        }

        public int Dequeue()
        {
            int value = store[head];
            head = head + 1;
            numItems--;
            return value;
        }

        public int Peek()
        {
            return store[head];
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }

        public bool IsFull()
        {
            return numItems == maxsize;
        }

        public string display()
        {
            StringBuilder output = new StringBuilder();
            for(int i=0; i<=tail-1; i++)
            {
                output.Append(store[i] + ","); 
            }
            return output.ToString();
        }


    }
}
