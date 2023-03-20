using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[2,3,4];
            int num, value = 1;

            for(int i=0; i < array.GetLength(0); i++)
            {
                for (int k =0;  k < array.GetLength(1); k++)
                {
                    for (int j =0; j < array.GetLength(2); j++)
                    {
                        array[i,k,j] = value;
                        value++;
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    for (int j = 0; j < array.GetLength(2); j++)
                    {
                        Console.Write("{0, 3:D}", array[i,k,j]);

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
