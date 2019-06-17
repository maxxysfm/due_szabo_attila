using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KözvelemenyKutatas
{
    public partial class FELHASZNALOIADATOK
    {
        public override string ToString()
        {
            //return $"{EMAIL} Nem:{NEM} Kor:{KOR} éves, Végzettség:{VEGZETTSEG}";
            return $"{EMAIL}";
        }
    }
    public partial class KUTATASOK
    {
        public override string ToString()
        {
            //return $"{KUTATASNEV}, Kezdete: {KEZDODATE}, Vége: {VEGZODATE}";
            return $"{KUTATASNEV}";
        }
    }
    public partial class KERDESEK
    {
        public override string ToString()
        {
            //return $"ID:{KERDESID} Kutatás:{KUTATASNEV} Leírás.:{LEIRAS}";
            return $"{LEIRAS}";
        }
    }
    public partial class LEADOTTVALASZOK
    {
        public override string ToString()
        {
            //return $"ID:{LEADOTTID} EMAIL:{EMAIL} Kérdés:{KERDESEK.LEIRAS} Válasz:{VALASZOK.LEIRAS}";
            return $"ID:{LEADOTTID} EMAIL:{EMAIL} Kérdés:{KERDESEK.LEIRAS} Válasz:{VALASZOK.LEIRAS}";
        }
    }
    public partial class VALASZOK
    {
        public override string ToString()
        {
            //Ne az ID-t írja ki
            //return $"{KERDESID}. Vál.ID:{VALASZID} Leírás.:{LEIRAS}";
            return $"{LEIRAS}";
        }
    }
}
