using System;
using System.Collections.Generic;

namespace ConsoleApplication74
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[4];

            int[] liczby2 = { 1,2,7,6};
            //for(int i=0;i<liczby.Length; i++)
            //{
            //    Console.WriteLine(liczby2[i]);
            //}
            //Console.WriteLine("foreach");
            //foreach(var element in liczby2)
            //{
            //    Console.WriteLine(element);
            //}
            //Console.WriteLine(liczby2[liczby2.Length-1]);
            Array.Sort(liczby2);
            
            //Osoba[] osoby = new Osoba[2];
            //Osoba[] osoby2 = { new Osoba("Jan", 50), new Osoba("Anna", 25), new Osoba("Krzysztof", 40) };
            //Osoba[] osoby3 = osoby2;
            //osoby2[1] = new Osoba("Zofia", 60);
            //Array.Resize<Osoba>(ref osoby2, 6);
            //osoby2[2] = new Osoba("Tomasz", 12);

            Stack<Osoba> osoby5 = new Stack<Osoba>();
            
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
    }
}
