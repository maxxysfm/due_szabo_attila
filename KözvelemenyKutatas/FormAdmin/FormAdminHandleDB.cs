using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KözvelemenyKutatas
{
    public partial class FormAdminHandleDB : Form
    {
        // Ideiglenes IDk
        int indexOffsetKerdesek = 0;
        int indexOffsetValaszok = 0;
        //
        DataAccess dataAccess;
        KUTATASOK editedKutatas;
        List<KERDESEK> editedKerdesek = new List<KERDESEK>();
        List<VALASZOK> editedValaszok = new List<VALASZOK>();

        //Újra aktiváláshoz kellő mentések:
        //int OldFolimit = 0;  -- Ez csak egy min érték lesz a numericnek

        public FormAdminHandleDB(DataAccess dataAccess,KUTATASOK kutatasEdit = null)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
            editedKutatas = kutatasEdit ?? new KUTATASOK();
        }
        public void RefreshForm()
        {
            this.dataGridViewKerdes.DataSource = null;
            this.dataGridViewKerdes.Rows.Clear();
            this.dataGridViewKerdes.Columns.Clear();
            dataGridViewKerdes.DataSource = editedKerdesek;
            //Fomrai dolgok
            if (editedKerdesek.Count != 0)
            {
                //DataGridViewColumn edit_column = dataGridViewKerdes.Columns[0];
                //edit_column.Width = 30;
                //edit_column.HeaderText = "ID";
                DataGridViewColumn edit_column2 = dataGridViewKerdes.Columns[2];
                edit_column2.Width = 335;
                dataGridViewKerdes.Columns["KERDESID"].Visible = false;
                dataGridViewKerdes.Columns["KUTATASNEV"].Visible = false;
                dataGridViewKerdes.Columns["VALASZOKs"].Visible = false;
                dataGridViewKerdes.Columns["KUTATASOK"].Visible = false;
                dataGridViewKerdes.Columns["LEADOTTVALASZOKs"].Visible = false;
            }
            this.comboBoxKerdesSellect.DataSource = null;
            comboBoxKerdesSellect.DataSource = editedKerdesek;
            this.dataGridViewValasz.DataSource = null;
            this.dataGridViewValasz.Rows.Clear();
            this.dataGridViewValasz.Columns.Clear();
            //Forma:
            //Többi combo box:
            this.comboBoxKerdesAssign.DataSource = null;
            comboBoxKerdesAssign.DataSource = editedKerdesek;
            this.comboBoxKerdesDeleteSellected.DataSource = null;
            comboBoxKerdesDeleteSellected.DataSource = editedKerdesek;
            //dataGridViewValasz.DataSource = editedValaszok.Where(x => x.KERDESID == ((VALASZOK)comboBoxKerdesSellect.SelectedItem).KERDESID);
            //Why???
            if (comboBoxKerdesSellect.SelectedIndex != -1 && comboBoxKerdesSellect.Items.Count != 0)
            {
                RefreshFormKerdesek();
            }
            //Delete combo box csak akkor változik, ha a kérdés kivan választva.
            //if (comboBoxKerdesDeleteSellected.SelectedIndex != -1 && comboBoxKerdesDeleteSellected.Items.Count != 0)
            //{
            //    var ListValaszokForDelete = editedValaszok.Where(x => x.KERDESID == ((KERDESEK)comboBoxKerdesDeleteSellected.SelectedItem).KERDESID);
            //    this.comboBoxValaszDeleteSellected.DataSource = null;
            //    comboBoxValaszDeleteSellected.DataSource = ListValaszokForDelete.ToList();
            //}
            //editedKerdesek.RemoveAll(x => x == null);
            //editedValaszok.RemoveAll(x => x == null);
        }
        public void RefreshFormKerdesek()
        {
            var ListValaszok = editedValaszok.Where(x => x.KERDESID == ((KERDESEK)comboBoxKerdesSellect.SelectedItem).KERDESID);
            dataGridViewValasz.DataSource = ListValaszok.ToList();
            //DataGridViewColumn edit_column3 = dataGridViewValasz.Columns[1];
            //edit_column3.Width = 30;
            //edit_column3.HeaderText = "ID";
            DataGridViewColumn edit_column4 = dataGridViewValasz.Columns[2];
            edit_column4.Width = 320;
            dataGridViewValasz.Columns["KERDESID"].Visible = false;
            dataGridViewValasz.Columns["VALASZID"].Visible = false;
            dataGridViewValasz.Columns["KERDESEK"].Visible = false;
            dataGridViewValasz.Columns["LEADOTTVALASZOKs"].Visible = false;
            if (comboBoxKerdesDeleteSellected.SelectedIndex != -1 && comboBoxKerdesDeleteSellected.Items.Count != 0)
            {
                var ListValaszokForDelete = editedValaszok.Where(x => x.KERDESID == ((KERDESEK)comboBoxKerdesDeleteSellected.SelectedItem).KERDESID);
                this.comboBoxValaszDeleteSellected.DataSource = null;
                comboBoxValaszDeleteSellected.DataSource = ListValaszokForDelete.ToList();
            }
        }
        private void FormAdminHandleDB_Load(object sender, EventArgs e)
        {
            dateTimePickerKezdDatumHour.Format = DateTimePickerFormat.Time;
            dateTimePickerKezdDatumHour.ShowUpDown = true;
            dateTimePickerVegDatumHour.Format = DateTimePickerFormat.Time;
            dateTimePickerVegDatumHour.ShowUpDown = true;
            //Módosítunk vagy új kutatást csinálunk?
            if (editedKutatas.KUTATASNEV != null)
            {
                buttonAddNewKutatas.Text = "Kutatás módosításainak mentése";
                this.Text = "Kutatás módosítása";
                textBoxKutatasNev.Text = editedKutatas.KUTATASNEV;
                textBoxKutatasNev.Enabled = false;
                foreach (KERDESEK j in dataAccess.GetAllKerdesForResearch(editedKutatas))
                {
                    editedKerdesek.Add(j);
                }
                foreach (VALASZOK j in dataAccess.GetAllValaszForResearch(editedKutatas))
                {
                    editedValaszok.Add(j);
                }
            }
            dateTimePickerKezdDatum.Value = (DateTime)editedKutatas.KEZDODATE;
            dateTimePickerVegDatum.Value = (DateTime)editedKutatas.VEGZODATE;
            dateTimePickerKezdDatumHour.Value = (DateTime)editedKutatas.KEZDODATE;
            dateTimePickerVegDatumHour.Value = (DateTime)editedKutatas.VEGZODATE;
            numericUpDownFoLimit.Value = editedKutatas.FOLIMIT;
            RefreshForm();
            if (editedKutatas.KUTATASLOCK == true)
            {
                this.Text = "Kutatás újraaktiválása";
                textBoxKerdes.Enabled = false;
                buttonAddNewKerdes.Enabled = false;
                textBoxValasz.Enabled = false;
                buttonAddNewValasz.Enabled = false;
                comboBoxKerdesDeleteSellected.Enabled = false;
                buttonKerdesDeleteSellected.Enabled = false;
                comboBoxValaszDeleteSellected.Enabled = false;
                buttonValaszDeleteSellected.Enabled = false;
                //Főlimit nem csökkenhet, max nőhet!
                numericUpDownFoLimit.Minimum = editedKutatas.FOLIMIT;
                //Új Dátum a régi Végdátum alapján kell hogy változzon.
                //dateTimePickerKezdDatum.MinDate = (DateTime)editedKutatas.VEGZODATE;
                //dateTimePickerKezdDatumHour.MinDate = (DateTime)editedKutatas.VEGZODATE;
                //Csak hogy ne ugyan akkor kezdődjön, mint amikor befejeződött.
                //dateTimePickerKezdDatumHour.MinDate.AddSeconds(1);
                //dateTimePickerVegDatum.MinDate = (DateTime)editedKutatas.VEGZODATE;
                //dateTimePickerVegDatumHour.MinDate = (DateTime)editedKutatas.VEGZODATE;
                ////Preferencia, de minimum 1 óra kell egy kutatás kitöltéséhez, ez lehetne kevesebb is, de akkor AddHour helyett más kell.
                //dateTimePickerKezdDatumHour.MinDate.AddHours(1);
            }
        }
        private void buttonAddNewKutatas_Click(object sender, EventArgs e)
        {
            try
            {
                //Hiba kezelés
                editedKutatas.KUTATASNEV = textBoxKutatasNev.Text;
                editedKutatas.KEZDODATE = dateTimePickerKezdDatum.Value.Date
                + dateTimePickerKezdDatumHour.Value.TimeOfDay;
                editedKutatas.VEGZODATE = dateTimePickerVegDatum.Value.Date
                + dateTimePickerVegDatumHour.Value.TimeOfDay;
                editedKutatas.FOLIMIT = numericUpDownFoLimit.Value;
                List<int> ErrorIndex = new List<int>();
                for (int i = 0; i < editedKerdesek.Count; i++)
                {
                    int valaszCount = 0;
                    for (int x = 0; x < editedValaszok.Count; x++)
                    {
                        if (editedKerdesek[i].KERDESID == editedValaszok[x].KERDESID)
                        {
                            valaszCount++;
                        }
                    }
                    if (valaszCount < 2)
                    {
                        ErrorIndex.Add(i);
                    }
                }
                if (editedKerdesek.Count == 0)
                {
                    MessageBox.Show("Nem tartozik kérdés a kutatáshoz, írjon be legalább egy kérdést!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ErrorIndex.Count != 0)
                {
                    string errorMessange = "";
                    for (int i = 0; i < ErrorIndex.Count; i++)
                    {
                        errorMessange += $" {editedKerdesek[i].LEIRAS}";
                    }
                    MessageBox.Show($"Nem tartozik legalább 2 válasz ezekhez a kérdésekhez:{errorMessange}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dataAccess.KutatasExists(editedKutatas) && textBoxKutatasNev.Enabled == true)
                {
                    MessageBox.Show("Ez a kutatás név már létezik, írjon be másik nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (editedKutatas.KEZDODATE > editedKutatas.VEGZODATE)
                {
                    MessageBox.Show("A végző dátumnak nagyobbnak kell lennie, mint a kezdő dátum!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Ha minden megfelelő:
                else
                {
                    dataAccess.DeleteKutatas(editedKutatas);
                    dataAccess.AddNewKutatas(editedKutatas);
                    foreach (KERDESEK j in editedKerdesek)
                    {
                        KERDESEK newKerd = new KERDESEK();
                        newKerd.KERDESID = dataAccess.GetNextKERDESID();
                        newKerd.KUTATASNEV = editedKutatas.KUTATASNEV;
                        newKerd.LEIRAS = j.LEIRAS;
                        dataAccess.AddNewKerdes(newKerd);
                        foreach (VALASZOK x in editedValaszok)
                        {
                            if (j.KERDESID == x.KERDESID)
                            {
                                VALASZOK newValasz = new VALASZOK();
                                newValasz.KERDESID = newKerd.KERDESID;
                                newValasz.VALASZID = dataAccess.GetNextVALASZID();
                                newValasz.LEIRAS = x.LEIRAS;
                                dataAccess.AddNewValasz(newValasz);
                            }
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A kutatás létrehozása sikertelen volt: {ex.Message}");
            }
        }
        private void buttonAddNewKerdes_Click(object sender, EventArgs e)
        {
            if (textBoxKerdes.TextLength < 5)
            {
                MessageBox.Show("Hiba, túl rövid a kérdés!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                KERDESEK newKerdes = new KERDESEK();
                newKerdes.KERDESID = indexOffsetKerdesek;
                newKerdes.KUTATASNEV = editedKutatas.KUTATASNEV;
                newKerdes.LEIRAS = textBoxKerdes.Text;
                editedKerdesek.Add(newKerdes);
                indexOffsetKerdesek++;
            }
            RefreshForm();
        }

        private void buttonAddNewValasz_Click(object sender, EventArgs e)
        {
            if (textBoxValasz.TextLength == 0)
            {
                MessageBox.Show("Hiba, túl rövid a válasz, legalább 1 betűt írjon be!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VALASZOK newValasz = new VALASZOK();
                newValasz.KERDESID = Convert.ToDecimal(((KERDESEK)comboBoxKerdesAssign.SelectedItem).KERDESID);
                newValasz.VALASZID = indexOffsetValaszok;
                newValasz.LEIRAS = textBoxValasz.Text;
                editedValaszok.Add(newValasz);
                indexOffsetValaszok++;
            }
            RefreshForm();
        }
        private void comboBoxKerdesSellect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKerdesSellect.SelectedIndex != -1 && comboBoxKerdesSellect.Items.Count != 0)
            {
                var ListValaszok = editedValaszok.Where(x => x.KERDESID == ((KERDESEK)comboBoxKerdesSellect.SelectedItem).KERDESID);
                dataGridViewValasz.DataSource = ListValaszok.ToList();
            }
            if (comboBoxKerdesDeleteSellected.SelectedIndex != -1 && comboBoxKerdesDeleteSellected.Items.Count != 0)
            {
                var ListValaszokForDelete = editedValaszok.Where(x => x.KERDESID == ((KERDESEK)comboBoxKerdesDeleteSellected.SelectedItem).KERDESID);
                this.comboBoxValaszDeleteSellected.DataSource = null;
                comboBoxValaszDeleteSellected.DataSource = ListValaszokForDelete.ToList();
            }
            RefreshForm();
        }

        private void buttonKerdesDeleteSellected_Click(object sender, EventArgs e)
        {
            if (comboBoxKerdesDeleteSellected.Items.Count != 0 && comboBoxKerdesDeleteSellected.SelectedIndex != -1)
            {
                //Foreachal nem mükszik...
                //foreach (VALASZOK j in editedValaszok)
                //{
                //    if (((KERDESEK)comboBoxKerdesDeleteSellected.SelectedItem).KERDESID == j.KERDESID)
                //    {
                //        editedValaszok.Remove(j);
                //    }
                //}
                editedValaszok.RemoveAll(x=>x.KERDESID == ((KERDESEK)comboBoxKerdesDeleteSellected.SelectedItem).KERDESID);
                editedKerdesek.Remove((KERDESEK)comboBoxKerdesDeleteSellected.SelectedItem);
                indexOffsetKerdesek--;
                //editedKerdesek.Sort();
            }
            RefreshForm();
        }

        private void buttonValaszDeleteSellected_Click(object sender, EventArgs e)
        {
            if (comboBoxValaszDeleteSellected.Items.Count != 0 && comboBoxValaszDeleteSellected.SelectedIndex != -1)
            {
                try
                {
                    editedValaszok.Remove((VALASZOK)comboBoxValaszDeleteSellected.SelectedItem);
                    //editedKerdesek.Sort();
                    indexOffsetValaszok--;
                }
                catch (Exception)
                {
                    MessageBox.Show("Sikertelen törlés");
                }
            }
            RefreshForm();
        }


    }
}
