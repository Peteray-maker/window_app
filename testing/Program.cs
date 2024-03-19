using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            IntQueue mine = new IntQueue();

            mine.Enqueue(30);
            mine.Enqueue(40);
            mine.Enqueue(50);
            mine.Enqueue(60);
            mine.Enqueue(70);
            mine.Enqueue(80);

            Console.WriteLine(mine.display());

            mine.Dequeue();
            mine.Dequeue();

            Console.WriteLine(mine.Dequeue());
            Console.WriteLine(mine.Dequeue());
            Console.WriteLine(mine.Dequeue());

            Console.WriteLine(mine.Peek());

            Console.ReadKey();
        }

        

    }
}
