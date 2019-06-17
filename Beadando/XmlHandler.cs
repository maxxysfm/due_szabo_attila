using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Beadando
{
    class XmlHandler
    {
        public bool WriteXML(string filePath, List<Game> game)
        {
            using (XmlWriter xWriter = XmlWriter.Create(filePath))
            {
                try
                {
                    xWriter.WriteStartDocument();
                    xWriter.WriteStartElement("Results");
                    foreach (Game x in game)
                    {
                        xWriter.WriteStartElement("Game");
                        xWriter.WriteStartElement("PlayerId");
                        xWriter.WriteValue(x.PlayerId);
                        xWriter.WriteEndElement();
                        xWriter.WriteStartElement("MapId");
                        xWriter.WriteValue(x.MapId);
                        xWriter.WriteEndElement();
                        xWriter.WriteStartElement("SkillRating");
                        xWriter.WriteValue(x.SkillRating);
                        xWriter.WriteEndElement();
                        xWriter.WriteEndElement();
                    }
                    xWriter.WriteEndElement();
                }
                catch (XmlException ex)
                {
                    MessageBox.Show($"Exception fordult elő! Hiba: {ex}");
                    return false;
                }
                return true;
            }
        }
    }
}
