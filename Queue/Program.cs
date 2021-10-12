using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListQueue queue = new LinkListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.display();
            Console.WriteLine("\n");
            queue.Dequeue();
            queue.display();
            Console.ReadLine();
        }
    }
}
