using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//using System.Globalization;

namespace KözvelemenyKutatas
{
    public class Variables
    {
        /// <summary>
        /// Ide kerülnek azok a változók, amiket minden formban lehet olvasni.
        /// </summary>
        //public static DateTimeFormatInfo CurrentDateInfo = new CultureInfo("hu-HU", false).DateTimeFormat;
        public static DateTime CurrentDate = DateTime.Now;
        ////https://msdn.microsoft.com/en-us/library/system.timers.timer(v=vs.110).aspx
        //public static Timer aTimer = new Timer(10000);
        //ProgramMode: XML által beolvasott felhasználói mód:
        //False = Normal, True = Admin
        public static FELHASZNALOIADATOK User = new FELHASZNALOIADATOK();
        public static string XMLFileName = "Userdata.xml";
        public static string[] Vegzettseg = new string[] { "Általános Iskola", "Gimnázium", "Szakközépiskola","Szakiskola", "Felsőoktatási intézmény" };
        public static bool ProgramMode = false;
        //Norm felhasználói módban használt érték.
    }
}
