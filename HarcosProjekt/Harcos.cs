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

    }
}
