using System;

namespace LoopIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 0; x < 15; x++)
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}\t{i}\t{i}\t{i}\t{i}");
                }
            }
            /*Is this the most matrix thing you ever seen.
             * To perform the marix just change the outer
             * loop variable to the inner loop variable and
             * delete the inner int data type.*/

        }
    }
}
