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
    public partial class FormNorm : Form
    {
        DataAccess dataAccess;
        public FormNorm()
        {
            InitializeComponent();
        }

        private void FormNorm_Load(object sender, EventArgs e)
        {
            labelGreetings.Text = $"Üdvözöljük {Variables.User.EMAIL}!";
            dataAccess = new DataAccess();
            RefreshForm();
        }
        public void RefreshForm()
        {
            labelDate.Text = Variables.CurrentDate.ToString();
            dataAccess.KutatasLockCheckByDate();
            cmbList.DataSource = dataAccess.GetAllAvailableKutatasToUser(Variables.User);
            listBoxMain.DataSource = dataAccess.GetAllAvailableKutatasToUser(Variables.User);
            if (cmbList.Items.Count == 0)
            {
                //listBoxMain.Text = "<Üres>";
                cmbList.Enabled = false;
                buttonKitoltes.Enabled = false;
                labelListCmb.Text = "Nem elérhető több kutatás!";
            }
            else
            {
                labelListCmb.Text = "Válaszzon ki egy kutatást!";
                cmbList.Enabled = true;
                buttonKitoltes.Enabled = true;
            }
        }

        private void buttonKitoltes_Click(object sender, EventArgs e)
        {
            List<KERDESEK> kerdesek = new List<KERDESEK>();
            if (cmbList.SelectedItem != null)
            {
                kerdesek = dataAccess.GetAllKerdesForResearch((KUTATASOK)cmbList.SelectedItem);
            }
            if (cmbList.SelectedItem != null && kerdesek.Count != 0)
            {
                FormNormPoll FormPoll = new FormNormPoll(dataAccess,(KUTATASOK)cmbList.SelectedItem);
                if (FormPoll.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Sikeresen kitöltötte a kutatást!", "Sikeres kitöltés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("Hiba: nincs kijelölve kutatás, vagy nincsenek kérdések a kutatáshoz rendelve!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void timerKutatasDisplay_Tick(object sender, EventArgs e)
        {
            //Minden 10.ik másodpercbe frissítsen. Mert why not.
            Variables.CurrentDate = Variables.CurrentDate.AddSeconds(5);
            timerKutatasDisplay.Enabled = true;
            timerKutatasDisplay.Interval = 5000;
            RefreshForm();
        }

        private void FormNorm_FormClosed(object sender, FormClosedEventArgs e)
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
