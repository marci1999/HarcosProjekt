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
            if (statuszSablon == 2)
            {
                this.alapEletero = 12;
                this.alapSebzes = 4;
            }
            if (statuszSablon == 3)
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

        public override string ToString()
        {
            return string.Format("{0} - EXP: {1}/{2} - HP: {3}/{4} - DMG: {5}", this.nev, this.tapasztalat, szintLepeshez(), this.eletero, MaxEletero(), sebzes());
        }
    }
}
