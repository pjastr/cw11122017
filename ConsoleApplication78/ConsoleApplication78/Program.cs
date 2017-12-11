using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication78
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> znaki = new Stack<char>();
            znaki.Push('4');
            znaki.Push('t');
            znaki.Push('R');
            znaki.Push('4');
            
            Console.WriteLine(znaki.Contains('R'));
            //foreach(var element in znaki)
            //{
            //    Console.WriteLine(element);
            //}

            Osoba o1 = new Osoba("Jan", 23);
            Stack<Osoba> osoby = new Stack<Osoba>();
            osoby.Push(o1);

            osoby.Push(new Osoba("Anna", 30));
            osoby.Push(o1);
            osoby.Push(new Student("Zofia", 19));
            Console.WriteLine(osoby.Contains(o1));
            //foreach(var osoba in osoby)
            //{
            //    Console.WriteLine(osoba);
            //}
            //Console.WriteLine(osoby.Pop());
        }
    }

    class Osoba
    {
        int wiek;
        string imie;

        public Osoba(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }

        public override string ToString()
        {
            return imie +", "+wiek;
        }
    }

    class Student : Osoba
    {

        public Student(string imie, int wiek)
            :base(imie, wiek)
        {
            
        }

    }
}
