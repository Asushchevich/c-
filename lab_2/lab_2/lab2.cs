using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            B clasB = new B(1,2,3);
            Console.WriteLine(clasB.c2);
            
            
            
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
        int d;
        public int c2
        {
            get {for (int i = 0; i < 2; i++) { d += c; } return d; }
            set { ++ value; }
        }
        public B(int a, int b) : base(a , b)

        {
           
            
        }

        public B (int a, int b, int d) : this(a,b) 
            { 
            this.a = a;
            this.b = b;
            this.d = d;

            }
        
    }
}

