using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[100];
            int[] bb = new int[100];
        
            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = (i+1)*3;
            }
            for (int i = 0; i < bb.Length; i++)
            {
                if(i+50 < bb.Length)
                {
                    bb[i] = aa[50 + i];
                }
                else
                {
                    bb[i] = aa[i - 50];
                }
            }
            for (int i = 0; i < bb.Length; i++)
            {
                Console.WriteLine("bb[{0}]: {1}",i,bb[i]);
            }
        }
    }
}
