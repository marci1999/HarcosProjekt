using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HarcosProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Harcos> harcosok = new List<Harcos>();

            StreamReader sr = new StreamReader("harcosok.csv");
            string[] sor = sr.ReadLine().Split(";");
            while (! )
            {

            }

            Harcos h1 = new Harcos("Cooper", 2);
            Harcos h2 = new Harcos("Fletó", 3);
            Harcos h3 = new Harcos("Samuel", 1);

            h1.Megkuzd(h2);
            Console.WriteLine(h1.Eletero);
            h1.Gyogyul();
            Console.WriteLine(h1.Eletero);
            h1.Gyogyul();
            Console.WriteLine(h1.Eletero);
            h1.Gyogyul();
            Console.WriteLine(h1.Eletero);


            Console.ReadLine();
        }
    }
}
