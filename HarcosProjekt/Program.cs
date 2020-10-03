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
            int sablonSzam = Convert.ToInt32(Console.ReadLine());
            Harcos harcosom = new Harcos(nev, sablonSzam);
            Console.WriteLine(harcosom);
            do
            {
                
            } while (true);

            Console.ReadLine();
        }
    }
}
