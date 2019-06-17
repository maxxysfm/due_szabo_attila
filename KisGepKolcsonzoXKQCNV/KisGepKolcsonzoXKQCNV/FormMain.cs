using KisGepKolcsonzoXKQCNV;
using KisGepKolcsonzo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Xml;
using System.Xml.Serialization;

namespace KisGepKolcsonzoXKQCNV
{
    public partial class FormMain : Form
    {
        DataAccess dataAccess;
        public FormMain()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //listBoxMain.DataSource = dataAccess.GetAllKolcsonzes();
            listBoxSecondary.DataSource = dataAccess.GetAllUgyfel();
            comboBoxUgyfelek.DataSource = dataAccess.GetAllUgyfel();
        }
        private void comboBoxUgyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxMain.DataSource = dataAccess.GetAllKolcsonzes((Ugyfel)comboBoxUgyfelek.SelectedItem);
            listBoxMain.SelectedIndex = -1;
            int KedvezmenyNelkul = 0;
            foreach (Kolcsonze j in listBoxMain.Items)
            {
                KedvezmenyNelkul += dataAccess.GetKolcsonzesAra(j) * j.NapokSzama;
            }
            double Kedvezmenyel = 0;
            foreach (Kolcsonze j in listBoxMain.Items)
            {
                // szükséges osztások double-val
                Kedvezmenyel += (dataAccess.GetKolcsonzesAra(j) * j.NapokSzama) * 
                    ((100-(int)((Ugyfel)comboBoxUgyfelek.SelectedItem).Kedvezmeny)%100)/100;
            }

            labelKedvezmenyNelkul.Text = $"{KedvezmenyNelkul}";
            labelKedvezmennyel.Text = null;
            labelKedvezmennyel.Text = $"{Kedvezmenyel}";
            labelKedvezmeny.Text = $"{KedvezmenyNelkul - Kedvezmenyel}";
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            listBoxSecondary.DataSource = dataAccess.GetAllUgyfel((Decimal)numericUpDownFilter.Value);
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            XmlHandler xmlhandlerForm = new XmlHandler();
            List<Ugyfel> SzurtUgyfelek = new List<Ugyfel>();
            foreach (Ugyfel j in listBoxSecondary.Items)
            {
                SzurtUgyfelek.Add(j);
            }
            if (!xmlhandlerForm.WriteXML("SzurtUgyfelekOut.xml", SzurtUgyfelek))
            {
                MessageBox.Show("Sikertelen volt az XML írása.");
            }
            else
            {
                MessageBox.Show("Sikeres volt az XML írása!");
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataAccess.Dispose();
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            // 100% exception
            FormDiagram FormDiagramShow = new FormDiagram(dataAccess);
            FormDiagramShow.Show();
        }
    }
}
