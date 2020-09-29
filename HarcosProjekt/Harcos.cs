using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        string nev;
        int szint;
        int tapasztalat;
        int eletero;
        int alapEletero;
        int alapSebzes;

        public string Nev1 { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Eletero { get => eletero; set => eletero = value; }

        public Harcos(string nev, int statuszSablon)
        {
            this.nev = nev;
            this.szint = 1;
            this.tapasztalat = 0;
            if (statuszSablon == 1)
            {
                this.alapEletero = 15;
                this.alapSebzes = 3;
            }
            else if (statuszSablon == 2)
            {
                this.alapEletero = 12;
                this.alapSebzes = 4;
            }
            else if (statuszSablon == 3)
            {
                this.alapEletero = 8;
                this.alapSebzes = 5;
            }
            this.eletero = MaxEletero();
        }

        public int sebzes()
        {
            return alapSebzes + szint;
        }
        public int szintLepeshez()
        {
            return 10 + szint * 5;
        }

        public int MaxEletero()
        {
            return alapEletero + szint * 3;
        }

        public void Megkuzd(Harcos masikHarcos)
        {
            if (this != masikHarcos)
            {
                if (this.eletero != 0 && masikHarcos.eletero != 0)
                {
                    masikHarcos.Eletero -= this.sebzes();
                    if (masikHarcos.eletero > 0)
                    {
                        masikHarcos.Tapasztalat += 5;
                        this.Eletero -= masikHarcos.sebzes();
                        if (this.eletero > 0)
                        {
                            this.Tapasztalat += 5;
                            Console.WriteLine("mindeniki túlélte");
                        }
                        else
                        {
                            Console.WriteLine("megöltek téged");
                            masikHarcos.Tapasztalat += 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("hát halotan már nem ugrál");
                        this.Tapasztalat += 10;
                    }
                }
                else
                {
                    Console.WriteLine("mind a két harcosnak élnie kell");
                }
            }
            else
            {
                Console.WriteLine("a harcos nem küzdhet magával");
            }
        }

        public void Gyogyul()
        {
            if (this.eletero == 0)
            {
                this.Eletero = MaxEletero();
                this.Tapasztalat = 0;
            }
            else if (this.Eletero + 3 + this.szint <= this.MaxEletero())
            {
                this.Eletero += 3 + this.szint;
            }
            else
            {
                int ideiglenes = MaxEletero() - eletero;
                this.Eletero += ideiglenes;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - EXP: {1}/{2} - HP: {3}/{4} - DMG: {5}", this.nev, this.tapasztalat, szintLepeshez(), this.eletero, MaxEletero(), sebzes());
        }
    }
}
