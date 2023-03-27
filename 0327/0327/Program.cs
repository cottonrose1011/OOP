using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0327
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.color = "Red";
            car1.speed = 0;

            Car car2 = new Car();
            car2.color = "Green";
            car2.speed = 0;

            Car car3 = new Car();
            car3.color = "Yellow";
            car3.speed = 0;

        }

        class Car
        {
            public string color;
            public int speed;
            public void UpSpeed(int value)
            {
                speed += value;
            }
            public void DownSpeed(int value)
            {
                speed -= value;
            }
        }
    }
}
