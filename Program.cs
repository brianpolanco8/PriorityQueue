using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            PriorityQueue<string> priorityQueue = new PriorityQueue<string>();
            int option;
            string input;

            priorityQueue.Enqueue("brian");
            priorityQueue.Enqueue("adam");
            priorityQueue.Dequeue();
            Console.WriteLine("Priority Queue\n");
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Que desea hacer ?\n");
                Console.WriteLine("1: Insertar proceso en la cola");
                Console.WriteLine("2: Desplegar listado");
                Console.WriteLine("----------------------------------------------\n");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Inserte el proceso: \n");
                        input = Console.ReadLine();
                        Console.WriteLine("\n");
                        priorityQueue.Enqueue(input);
                        break;

                    case 2:
                        Console.WriteLine("Listado\n");
                        priorityQueue.ToString();
                        break;

                    default:
                        Console.WriteLine("Opcion invalida\n");
                        break;

                }
            }
            while (true);

        }
    }
}
