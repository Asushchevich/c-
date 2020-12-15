using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Введите 1 или 2\n");
            a.p = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("c = " + a.c);
        }
    }

    class A
    {
        private int a = 5;
        private int b = 2;

        public char p;

        public float c
        {
            get
            {
                if (p == '1')
                {
                    return a * b;
                }
                else
                {
                    return a - b;
                }
            }
        }

        public A()
        {

        }
    }
}