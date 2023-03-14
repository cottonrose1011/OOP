using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0313
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("라인 수 입력: ");
            String l = Console.ReadLine();
            int line = int.Parse(l);
            
            int i, j, k;

            for(i=1; i<= line; i++) {
                for (k = line * 2 - 1; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (j=0; j < i*2 - 1; j++)
                {
                    Console.Write("*");
                }
                for (k=line*2 - 1; k > i; k--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (i = line-1; i >= 0; i--)
            {
                for (k = line * 2 - 1; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (j = i * 2 - 1; j > 0 ; j--)
                {
                    Console.Write("*");
                }
                for (k = line * 2 - 1; k > i; k--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }


        }
    }
}
