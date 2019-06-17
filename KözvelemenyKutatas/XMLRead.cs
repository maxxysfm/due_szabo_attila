using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace KözvelemenyKutatas
{
    class XMLRead
    {
        //Filepath opcionális,mivel nem akarjuk hogy csak a classon belül lehessen módosítani.
        public bool ReadFromXML(string filePath,out FELHASZNALOIADATOK result)
        {
            result = new FELHASZNALOIADATOK();
            //Még ha csak egy usert is adunk hozzá, class szükséges hogy felismerje a beolvasott adatokat és tárolja őket.
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"A file nem létezik: {filePath}!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                using (XmlReader xReader = XmlReader.Create(filePath))
                {
                    //Csak egy felhasnzáló adatát olvassuk be, aki kitölti a teszteket.
                    int i = 0;
                    while (i != 1)
                    {
                        xReader.Read();
                        if (xReader.Name == "user" && xReader.IsStartElement())
                        {
                            //feltételezzük hogy 0 és 1 van beírva a mode-hoz
                            Variables.ProgramMode = Convert.ToBoolean(xReader.GetAttribute("mode"));
                            //egymás alá olvasás
                            xReader.ReadToDescendant("EMAIL");
                            result.EMAIL = xReader.ReadElementContentAsString();
                            xReader.Read();
                            result.NEM = xReader.ReadElementContentAsString();
                            xReader.Read();
                            result.KOR = xReader.ReadElementContentAsInt();
                            xReader.Read();
                            result.VEGZETTSEG = xReader.ReadElementContentAsString();
                            i++;
                        }
                    }
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show($"Hiba történt a file olvasásakor: {ex.Message}!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba, {ex.Message}. győzödjön meg arról, hogy az XML file tartalma megfelelő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
