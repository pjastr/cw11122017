using System;
namespace ConsoleApplication77
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[4];
            //Console.WriteLine(liczby[1]);

            int[] liczby2 = { 4, 2, 7, 8, -2 };
            //int[] liczby3 = liczby2;
            //liczby2[1] = 20;
            //byte zmien = 3;
            //liczby[1] = zmien;
            //Array.Resize<int>(ref liczby2, 3);
            for(int i=0;i<liczby2.Length;i++)
            {
                Console.WriteLine(liczby2[i]);
            }
            Console.WriteLine("foreach");
            foreach(var element in liczby2)
            {
                Console.WriteLine(element);
            }
            //Array.Sort(liczby2);
            
            Osoba[] osoby1 = new Osoba[3];
            Osoba[] osoby2 = { new Osoba("Jan", 30), new Osoba("Anna", 12) };

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
