using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            B clasB = new B(4, 3, 5);
            Console.WriteLine(clasB.c2);
            foreach (int i in clasB.arr)
                Console.WriteLine(i);
                  


        }


    }
    class A
    {
        public int a;
        public int b;



        public int c
        {
            get { return a + b; }
            set { value = c; }

        }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public A()
        {

        }
    }
    class B : A
    {
        int d = 5;
        public int[] arr; 
        
        public int c2
        {
            get { for (int i = 0; i < 2; i++) { d += c; } return d; }
            set { ++value; }
        }
        public B(int a, int b) : base(a, b)

        {


        }

        public B(int a, int c2, int d) : this(a, c2)
        {
            this.a = a;
            this.c2 = c2;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = c2*i;
            } 

        }
        
        

    }
}

