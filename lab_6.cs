using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {

        static void Main(string[] args)
        {
            Man man1 = new Man { Surname = "Иван", BirthYear = 1976, Status = "Бежевый" };
            Man man2 = new Man { Surname = "Виктория", BirthYear = 2006, Status = "зелёный" };
            Man man3 = new Man { Surname = "Владимир", BirthYear = 1999, Status = "синий" };
            Man man4 = new Man { Surname = "Александр", BirthYear = 2001, Status = "красный" };
            Man man5 = new Man { Surname = "Лия", BirthYear = 1989, Status = "оранжевый" };


            List<Man> mans = new List<Man>();
            mans.Add(man1);
            mans.Add(man2);
            mans.Add(man3);
            mans.Add(man4);
            mans.Add(man5);
            mans.Sort();

            foreach (Man m in mans)
            {
                Console.WriteLine($"{m.BirthYear} - {m.Surname} - {m.Status}");
            }
        }
    }
    class Man : IComparable
    {
        public string Surname { get; set; }
        public int BirthYear { get; set; }
        public string Status { get; set; }

        public Man(string Surname, DateTime Birthday, string Status)
        {
            this.Surname = Surname;
            this.BirthYear = BirthYear;
            this.Status = Status;
        }

        public Man()
        {

        }

        public virtual int Info()
        {
            return BirthYear;
        }

        public int CompareTo(object obj)
        {
            Man p = obj as Man;
            if (p != null)
                return this.BirthYear.CompareTo(p.BirthYear);
            else
                throw new Exception("exception");
        }
    }
    class Student : Man
    {
        public int Math { get; set; }
        public int Physics { get; set; }
        public int History { get; set; }


        public Student(int Math, int Physics, int History)
        {
            this.Math = Math;
            this.Physics = Physics;
            this.History = History;
        }
        public int Average()
        {
            return (Math + Physics + History) / 3;
        }

        public override int Info()
        {
            int[] arr = { Math, Physics, History };
            return arr.Max();
        }
    }
}