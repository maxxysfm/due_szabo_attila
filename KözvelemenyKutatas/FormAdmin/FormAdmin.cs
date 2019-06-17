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
    public partial class FormAdmin : Form
    {
        DataAccess dataAccess;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public void RefreshForm()
        {
            dataAccess.KutatasLockCheckByDate();
            labelDate.Text = $"Rendszer dátum: {Variables.CurrentDate}";
            this.dataGridViewMain.DataSource = null;
            this.dataGridViewMain.Rows.Clear();
            this.dataGridViewMain.Columns.Clear();
            //this.dataGridViewMain.DataSource = this.GetNewValues();
            //listBoxMain.DataSource = dataAccess.GetAllKutatas();
            //Csinálunk listát is csak azért hogy tudjuk olvasni rendesen a létszámot.
            List<KUTATASOK> listOfKutatasok = new List<KUTATASOK>();
            switch (comboBoxFilter.SelectedIndex)
            {
                //Összes.
                case 0:
                    listOfKutatasok = dataAccess.GetAllKutatas();
                    break;
                //Aktív kutatások.
                case 1:
                    listOfKutatasok = dataAccess.GetAllAvailableKutatas();
                    break;
                //In-Aktív kutatások.
                case 2:
                    listOfKutatasok = dataAccess.GetAllUnavailableKutatas();
                    break;
                //Lejárt kutatások.
                case 3:
                    listOfKutatasok = dataAccess.GetAllExpiredKutatas();
                    break;
                //Módosítható kutatások.
                case 4:
                    foreach (KUTATASOK j in dataAccess.GetAllUnlockedKutatas())
                    {
                        if (dataAccess.GetAllAvailableSlotsNumber(j) == 0)
                        {
                            listOfKutatasok.Add(j);
                        }
                    }
                    //listOfKutatasok = dataAccess.GetAllLockedKutatas();
                    break;
                //Módosíthatatlan kutatások.
                case 5:
                    listOfKutatasok = dataAccess.GetAllLockedKutatas();
                    break;
                default:
                    listOfKutatasok = dataAccess.GetAllKutatas();
                    break;
            }
            //DataSource azért kell
            dataGridViewMain.DataSource = listOfKutatasok;
            dataGridViewMain.Columns["KERDESEKs"].Visible = false;
            var column = new DataGridViewTextBoxColumn();
            column.Name ="Résztvevők Száma:";
            dataGridViewMain.Columns.Insert(3, column);
            for (int i = 0; i < dataGridViewMain.Rows.Count; i++)
            {
                dataGridViewMain.Rows[i].Cells[3].Value = (decimal)dataAccess.GetAllAvailableSlotsNumber((KUTATASOK)listOfKutatasok[i]);
            }
            DataGridViewColumn edit_column = dataGridViewMain.Columns[0];
            edit_column.Width = 210;
            //Felhasználók:
            dataGridViewUsers.DataSource = dataAccess.GetAllFELHASZNALOIADATOK();
            dataGridViewUsers.Columns["LEADOTTVALASZOKs"].Visible = false;
            DataGridViewColumn edit_column2 = dataGridViewUsers.Columns[0];
            edit_column2.Width = 210;
            DataGridViewColumn edit_column3 = dataGridViewUsers.Columns[3];
            edit_column3.Width = 210;
            //Többi combo box:
            //Mit szabad módosítani? Azt a kutatást: Ami még nincs zárolva + Ahova még nem adtak le kérdést.
            comboBoxModify.Items.Clear();
            foreach (KUTATASOK j in dataAccess.GetAllUnlockedKutatas())
            {
                if (dataAccess.GetAllAvailableSlotsNumber(j) == 0)
                {
                    comboBoxModify.Items.Add(j);
                }
            }
            if (comboBoxModify.Items.Count != 0)
            {
                comboBoxModify.SelectedIndex = 0;
            }
            comboBoxDeleteKutatas.DataSource = dataAccess.GetAllKutatas();
            comboBoxInspect.DataSource = dataAccess.GetAllKutatas();
            comboBoxDeleteUser.DataSource = dataAccess.GetAllFELHASZNALOIADATOK();
            comboBoxReActivate.DataSource = dataAccess.GetAllExpiredKutatas();
            //Hiba kezelés
            DisableButton(comboBoxReActivate, buttonReActivate);
            DisableButton(comboBoxModify, buttonBoxModify);
            DisableButton(comboBoxInspect, buttonAnwsersSellected);
            DisableButton(comboBoxInspect, buttonDiagrammSellected);
            DisableButton(comboBoxDeleteKutatas, buttonDeleteSellectedKutatas);
            DisableButton(comboBoxDeleteKutatas, buttonDeleteDataFromSellectedKutatas);
            DisableButton(comboBoxDeleteUser, buttonDeleteSellectedUser);
        }

        public void DisableButton(ComboBox cmbToCheck,Button buttonToCheck)
        {
            if (cmbToCheck.Items.Count == 0)
            {
                buttonToCheck.Enabled = false;
            }
            else
            {
                buttonToCheck.Enabled = true;
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dataAccess = new DataAccess();
            comboBoxFilter.Items.Add("Összes kutatás.");
            comboBoxFilter.Items.Add("Aktív kutatások.");
            comboBoxFilter.Items.Add("In-Aktív kutatások.");
            comboBoxFilter.Items.Add("Lejárt kutatások.");
            comboBoxFilter.Items.Add("Módosítható kutatások.");
            comboBoxFilter.Items.Add("Módosíthatatlan kutatások.");
            comboBoxFilter.SelectedIndex = 0;
            RefreshForm();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAdminHandleDB HandleDB = new FormAdminHandleDB(dataAccess);
            HandleDB.ShowDialog();
            if (HandleDB.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("A kutatás sikeresen létre lett hozva!");
            }
            RefreshForm();
        }

        private void buttonBoxModify_Click(object sender, EventArgs e)
        {
            FormAdminHandleDB HandleDB = new FormAdminHandleDB(dataAccess,(KUTATASOK)comboBoxModify.SelectedItem);
            HandleDB.ShowDialog();
            if (HandleDB.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("A kutatás sikeresen módosítva lett!");
            }
            RefreshForm();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan szerentné kitörölni az adatbázist? Ez a folyamat nem vonható vissza!", "Törlés", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataAccess.DeleteDB();
            }
            RefreshForm();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void buttonReActivate_Click(object sender, EventArgs e)
        {
            //Újranyitás
            FormAdminHandleDB HandleDB = new FormAdminHandleDB(dataAccess, (KUTATASOK)comboBoxReActivate.SelectedItem);
            HandleDB.ShowDialog();
            if (HandleDB.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("A kutatás sikeresen újra lett nyitva!");
            }
            RefreshForm();
        }
        private void buttonDeleteAllKutatas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan szerentné kitörölni az adatbázist? Ez a művelet nem vonható vissza!", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataAccess.DeleteAllKutatas();
            }
            RefreshForm();
        }
        private void buttonDeleteAllUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan szerentné kitörölni az összes felhasználót? A leadott válaszok is törlésre kerülnek.", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataAccess.DeleteAllUser();
            }
            RefreshForm();
        }

        private void buttonDeleteSellectedUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Biztosan szerentné kitörölni {(FELHASZNALOIADATOK)comboBoxDeleteUser.SelectedItem} felhasználót? A felhasználó leadott válaszai is törlésre kerülnek.", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataAccess.DeleteUser((FELHASZNALOIADATOK)comboBoxDeleteUser.SelectedItem);
            }
            RefreshForm();
        }

        private void buttonDeleteSellectedKutatas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Biztosan szerentné kitörölni {(KUTATASOK)comboBoxDeleteKutatas.SelectedItem} ? A felhasználók által leadott válaszok is törlésre kerülnek.", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //LEADOTTVALASZOK TÖRLÉSE
                //VALASZOK TÖRLÉSE
                //KÉRDÉSEK TÖRLÉSE
                //KUTATÁS TÖRLÉSE
                //dataAccess.DeleteKutatas((KUTATASOK)comboBoxDeleteKutatas.SelectedItem);
                //1. Lépés
                //if (dataAccess.GetAllAvailableSlotsNumber((KUTATASOK)comboBoxDeleteKutatas.SelectedItem) != 0)
                //{
                //    dataAccess.DeleteKutatas((KUTATASOK)comboBoxDeleteKutatas.SelectedItem);
                //}
                dataAccess.DeleteKutatas((KUTATASOK)comboBoxDeleteKutatas.SelectedItem);
            }
            RefreshForm();
        }
        private void buttonDeleteDataFromSellectedKutatas_Click(object sender, EventArgs e)
        {
            if (dataAccess.GetAllAvailableSlotsNumber((KUTATASOK)comboBoxDeleteKutatas.SelectedItem) != 0)
            {
                if (MessageBox.Show($"Biztosan szerentné kitörölni {(KUTATASOK)comboBoxDeleteKutatas.SelectedItem} leadott válaszait? Az adatok törlődnek véglegesen!", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //buttonDeleteDataFromSellectedKutatas
                    List<LEADOTTVALASZOK> torlendoKutatasadat = new List<LEADOTTVALASZOK>();
                    torlendoKutatasadat = dataAccess.GetAllLeadottvalaszForResearch((KUTATASOK)comboBoxDeleteKutatas.SelectedItem);
                    foreach (LEADOTTVALASZOK j in torlendoKutatasadat)
                    {
                        dataAccess.DeleteLeadottvalaszok(j);
                    }
                }
                RefreshForm();
            }
            else
            {
                MessageBox.Show("A kutatást még nem töltötte ki senki!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void timerKutatasDisplay_Tick(object sender, EventArgs e)
        {
            Variables.CurrentDate = Variables.CurrentDate.AddSeconds(5);
            timerKutatasDisplay.Enabled = true;
            timerKutatasDisplay.Interval = 5000;
            RefreshForm();
        }

        private void buttonAnwsersSellected_Click(object sender, EventArgs e)
        {
            FormAdminViewDB ViewKutatas = new FormAdminViewDB(dataAccess, (KUTATASOK)comboBoxInspect.SelectedItem);
            ViewKutatas.ShowDialog();
        }

        private void buttonDiagrammSellected_Click(object sender, EventArgs e)
        {
            FormAdminViewGraph ViewGraph = new FormAdminViewGraph(dataAccess, (KUTATASOK)comboBoxInspect.SelectedItem);
            ViewGraph.ShowDialog();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataAccess.Dispose();
            Application.Exit();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //Manuális refresh, mert Timer miatt a combobox kiválasztott elemei folyamatosan változnak. Meg lehetne oldani index mentéssel talán vagy valamelyik eventel, de budget / time. :(
            RefreshForm();
            //https://stackoverflow.com/questions/6771769/refresh-icon-for-button
        }
    }
}
