using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat6();
            Feladat7();
            Feladat8();
            Console.ReadKey();
        }

        private static void Feladat8()
        {
            double Szam;
            for (int i = 0; i < 13; i++)
            {
                Szam = Math.Pow(4,i);
                if(i%2==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }                
                Console.WriteLine("A 4 {0}-edik hatványa: {1}", i, Szam);
                Console.ResetColor();
            }
        }

        private static void Feladat7()
        {
            Console.WriteLine("7.Feladat: Csapadék szimulátor");
            int Csapadek;
            int db = 0;
            double Sum = 0;
            double Atlag = 0;
            for (int i = 1; i < 22; i++)
            {
                Csapadek = rnd.Next(35, 76);
                Sum += Csapadek;
                Atlag = Sum / 21;
                if(55<=Csapadek)
                { 
                    db++;
                }
                Console.WriteLine("{0:00} nap csapadék mennyisége: {1} mm", i, Csapadek);
            }
            Console.WriteLine("\nEnnyi nap volt 55 mm vagy a feletti a csapadék : {0}", db);
            Console.WriteLine("\nA csapadék átlagos mennyisége: {0}", Atlag);

        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat: Gömb térfogata, felszíne");
            Console.Write("Kérem adja meg a gömb sugarát: ");
            double Sugar = double.Parse(Console.ReadLine());
            double Terfogat = (4 * Math.PI / 3) * Math.Pow(Sugar, 3);
            Console.WriteLine("A gömb térfogata: {0:0.00}", Terfogat);
            double Felszin = 4 * Math.PI * Math.Pow(Sugar, 2);
            Console.WriteLine("A gömb felszíne: {0:0.00}", Felszin);


        }

        private static void Feladat3()
        {
            int Szam;
            int Sum = 0;
            int db = 0;
            for(int i=10; i<100; i++)
            {
                Szam = i;
                if(Szam%5==0)
                {
                    if(Szam%2==0)
                    {
                        db++;
                    }
                    Console.Write("{0} ,", Szam);
                    Sum += Szam;
                }
            }
            Console.WriteLine("\n\nAz öttel osztható kétjegyű számok összege: {0}",Sum);
            Console.WriteLine("\nA kettővel osztható számok számossága: {0}", db);
        }

        private static void Feladat2()
        {
            int Szam;
            for(int i=100; i<1000; i++)
            {
                Szam = i;
                if(Szam%7==0)
                {
                    Console.Write("{0} , ", Szam);
                }
            }
        }

        private static void Feladat1()
        {
            Console.Write("Kérem adja meg a kezdő tökét: ");
            double Kezdotoke = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg mekkora lesz a kamatláb: ");
            double Kamatlab = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg hány évig kívánja kamatoztatni a pénzt: ");
            int Evek = int.Parse(Console.ReadLine());
            double Bevetel = 0;
            double Kamatszorzo = (100 + Kamatlab) / 100;
            for(int i=1; i<=Evek; i++)
            {
                Bevetel = Kezdotoke * Math.Pow(Kamatszorzo, i);
                Console.WriteLine("{0:00} év bevétel: {1:0.00} Ft", i,Bevetel);
            }
        }
    }
}
