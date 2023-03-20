using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4];
            int value = 1;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array[i, k] = value;
                    value += 2;
                }
            }
            Console.WriteLine("array[2,3] 부터 array[0, 0]까지 출력");
            for (int i = array.GetLength(0) -1 ; i >= 0; i--)
            {
                for (int k = array.GetLength(1) -  1; k >= 0; k--)
                {
                    Console.Write("{0, 3:D}", array[i,k]);
                }
                Console.WriteLine();
            }
        }
    }
}
