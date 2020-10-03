using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HarcosProjekt
{
    class Harcosok
    {
        List<Harcos> harcosok;
        public Harcosok(string fileName)
        {
            try
            {
                harcosok = new List<Harcos>();
                StreamReader sr = new StreamReader(fileName);
                string sor = sr.ReadLine();
                while (sor != null)
                {
                    harcosok.Add(new Harcos(sor));
                    sor = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                throw;
            }
        }
        public void kiIr()
        {
            int i = 1;
            foreach (var item in harcosok)
            {
                Console.WriteLine(i+""+item);
                i++;
            }
        }

        public Harcos kiker(int i)
        {
            return harcosok.ElementAt(i - 1);
        }

        public int hosz()
        {
           return harcosok.Count();
        }
    }
}
