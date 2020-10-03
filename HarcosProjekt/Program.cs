using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Harcosok h = new Harcosok("harcosok.csv");
            Console.WriteLine(h);

            //Harcos h1 = new Harcos("Cooper", 2);
            //Harcos h2 = new Harcos("Fletó", 3);
            //Harcos h3 = new Harcos("Samuel", 1);

            /*h1.Megkuzd(h2);
            Console.WriteLine(h1.Eletero);
            h1.Gyogyul();
            Console.WriteLine(h1.Eletero);
            h1.Gyogyul();
            Console.WriteLine(h1.Eletero);
            h1.Gyogyul();
            Console.WriteLine(h1.Eletero);*/
            Console.WriteLine("Adjon meg a harcos nevet");
            string nev = Console.ReadLine();
            Console.WriteLine("és egy sablonszámot\n" +
            "1: alapEletero = 15 alapSebzes = 3\n" +
            "2: alapEletero = 12 alapSebzes = 4\n" +
            "3: alapEletero = 8 alapSebzes = 5");
            int sablonSzam = 0;
            do
            {
                try
                {
                    sablonSzam = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("nem számot adtál meg");
                }
                if (sablonSzam > 3 || sablonSzam < 1)
                {
                    Console.WriteLine("a számnak 1 és  3 között kell lenni");
                }
            } while (sablonSzam > 3 || sablonSzam < 1);
            Harcos harcosom = new Harcos(nev, sablonSzam);
            int korszamlalo = 0;
            do
            {
                Console.WriteLine(harcosom);
                h.kiIr();
                Console.WriteLine("adja meg a menüpontot.\n" +
                    "a: megküzd egy másik harcossal\n" +
                    "b: gyógyul\n" +
                    "c: kilép");
                char bekert = '@';
                try
                {
                    bekert = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("nem számot adtál meg");
                }
                if (bekert.Equals('a'))
                {
                    Console.WriteLine("melyik harcosal akkar megküzdeni?");
                    try
                    {
                        int szam = Convert.ToInt32(Console.ReadLine());
                        Harcos masik = h.kiker(szam);
                        harcosom.Megkuzd(masik);
                        korszamlalo++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("nem számot adtál meg");
                    }
                } 
                else if(bekert.Equals('b'))
                {
                    harcosom.Gyogyul();
                    korszamlalo++;
                } 
                else if (bekert.Equals('c'))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("rossz karaktert adtál meg");
                }
                if (korszamlalo == 3)
                {
                    Console.WriteLine("kör vége.");
                    int hosz = h.hosz();
                    int veletlen = 0;
                    do
                    {
                        veletlen = r.Next(4);
                    } while (veletlen == 0);
                    Harcos masik = h.kiker(Convert.ToInt32(veletlen));
                    masik.Megkuzd(harcosom);
                    Console.WriteLine("és most miden elenfél gyogyul");
                    for (int i = 1; i < hosz+1; i++)
                    {
                        Harcos gyogyit = h.kiker(i);
                        gyogyit.Gyogyul();
                        korszamlalo = 0;
                    }
                }
            } while (true);

            Console.ReadLine();
        }
    }
}
