using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(a, b, c);
            angle.ToRadians();
            Console.ReadKey();
        }
    }

    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Grad
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;

                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            get
            {
                return sec;
            }

        }

        public Angle(int grad, int min, int sec)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }

        public double ToRadians()
        {
            double rad = (Grad + Min / 60 + Sec / 60 / 60) * Math.PI / 180;
            Console.WriteLine("The angle is {0:f2} rad", rad);
            return rad;
        }
    }
}