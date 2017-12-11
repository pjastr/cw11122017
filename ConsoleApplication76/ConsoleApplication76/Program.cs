using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication76
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> wyrazy = new Stack<string>();
            //wyrazy.Push("sddssd");
            ////wyrazy.Push(675666);
            ////wyrazy[0];
            //wyrazy.Push("334");
            //wyrazy.Push("");
            //wyrazy.Push("sddssd");
            //wyrazy.Push("awe");
            //wyrazy.Push("654");
            //Console.WriteLine(wyrazy.Contains("rttt"));
            //foreach(var element in wyrazy)
            //{
            //    Console.WriteLine(element);
            //}
            //Console.WriteLine(wyrazy.Peek());
            //for (int i = 0; i < wyrazy.Count; i++)
            //{
            //    Console.WriteLine(wyrazy[i]);
            //}
            Osoba o1 = new Osoba("Jan", 23);
            Osoba o2 = new Osoba("Anna", 20);
            Osoba o3 = new Osoba("Krzysztof", 44);
            Stack<Osoba> osoby = new Stack<Osoba>();
            osoby.Push(o1);
            osoby.Push(o2);
            osoby.Push(o3);
            Console.WriteLine(osoby.Contains(o1));
            var osoby2 = osoby.Reverse().ToList<Osoba>();



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

        public Osoba() { }
    }

    class Student:Osoba
    {
        public Student() 
        { }
    }
}
