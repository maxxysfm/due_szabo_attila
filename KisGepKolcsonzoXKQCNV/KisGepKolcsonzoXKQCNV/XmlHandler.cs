using KisGepKolcsonzoXKQCNV;
using KisGepKolcsonzo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace KisGepKolcsonzoXKQCNV
{
    class XmlHandler
    {
        public bool WriteXML(string filePath, List<Ugyfel> ugyfelek)
        {
            //Serialisational jobb lett volna.
            using (XmlWriter xWriter = XmlWriter.Create(filePath))
            {
                try
                {
                    xWriter.WriteStartDocument();
                    xWriter.WriteStartElement("UgyfelKedvezmeny");
                    foreach (Ugyfel j in ugyfelek)
                    {
                        xWriter.WriteStartElement("UgyfelNev");
                        xWriter.WriteString(j.Nev);
                        xWriter.WriteEndElement();
                        xWriter.WriteStartElement("KedvezmenyMerteke");
                        xWriter.WriteString(j.Kedvezmeny.ToString());
                        xWriter.WriteEndElement();
                    }
                    xWriter.WriteEndElement();
                }
                catch (XmlException ex)
                {
                    MessageBox.Show($"Hiba: {ex}");
                    return false;
                }
                return true;
            }
        }
    }
}
