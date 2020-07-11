using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new GenericQueue<string>();

            q.Add("a");
            q.Add("b");
            q.Add("c");
            q.Add("d");
            q.Add("e");
            q.Add("f");
            q.Add("g");
            q.Add("h");
            q.Add("i");
            q.Add("j");
            q.Add("k");
            q.Add("l");
        }
    }

    public class GenericQueue<T> : Queue<T> where T : class
    {
        private void BalanceQueue()
        {
            while (Count > 10)
            {
                Dequeue();
            }

            Console.WriteLine($"Current no of item in queue is {Count}.");
        }
        public void Add(T item)
        {
            Enqueue(item);
            BalanceQueue();
            PrintQ();
        }

        public T Remove()
        {
            Dequeue();
            T item = Dequeue();

            return item;
        }

        public void PrintQ()
        {
            
            foreach (Object obj in this)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }
    }

}
