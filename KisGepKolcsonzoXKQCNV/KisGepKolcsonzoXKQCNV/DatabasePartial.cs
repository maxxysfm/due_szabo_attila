using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisGepKolcsonzoXKQCNV
{
    public partial class Gep
    {
        public override string ToString()
        {
            return $"{Nev}";
        }
    }
    public partial class Kolcsonze
    {
        public override string ToString()
        {
            return $"Gép neve:{Gep.Nev}\tKölcsönzés ára(1 nap):{Gep.KolcsonzesAra}\tNapok száma:{NapokSzama} Kölcsönzés ára:{Gep.KolcsonzesAra*NapokSzama}";
        }
    }
    public partial class Ugyfel
    {
        public override string ToString()
        {
            return $"{Nev} Kedvezmény: {Kedvezmeny}";
        }
    }
}
