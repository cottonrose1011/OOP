using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEOF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double avg;
            string num;
            int[] array = new int[0];
            
            while (true)
            {
                Console.Write("숫자를 입력하세요(Enter는 종료): ");
                num = Console.ReadLine();
                if (num.Equals('\n'))
                    break;
                Array.Resize(ref array, array.Length + 1);
                array[array.Length-1] = int.Parse(num);
                sum += array[array.Length-1];
            }

            avg = (float) sum / array.Length;
            Console.WriteLine("합계 : {0}", sum);
            Console.WriteLine("평균 : {0}", avg);

        }
    }
}
