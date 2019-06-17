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
    public partial class FormNormPoll : Form
    {
        DataAccess dataAccess;
        List<KERDESEK> kerdesek = new List<KERDESEK>();
        List<VALASZOK> valaszok = new List<VALASZOK>();
        List<LEADOTTVALASZOK> newKitoltes = new List<LEADOTTVALASZOK>();
        public FormNormPoll(DataAccess dataAccess, KUTATASOK kutatas = null)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
            kerdesek = dataAccess.GetAllKerdesForResearch(kutatas);
            valaszok = dataAccess.GetAllValaszForResearch(kutatas);
            for (int i = 0; i < kerdesek.Count; i++)
            {
                LEADOTTVALASZOK leadott = new LEADOTTVALASZOK();
                newKitoltes.Add(leadott);
            }
        }
        public void UpdateForm()
        {
            comboBoxKerdesek.Items.Clear();
            foreach (KERDESEK item in kerdesek)
            {
                comboBoxKerdesek.Items.Add(item);
            }
        }
        public void UpdateFormValaszok()
        {
            comboBoxValasz.Items.Clear();
            //string test = Convert.ToString(comboBoxKerdesek.SelectedIndex);
            foreach (VALASZOK item in valaszok)
            {
                if (item.KERDESID == kerdesek[Convert.ToInt32(comboBoxKerdesek.SelectedIndex)].KERDESID)
                {
                    comboBoxValasz.Items.Add(item);
                }
            }
            try
            {
                comboBoxValasz.SelectedItem = kerdesek[Convert.ToInt32(newKitoltes[comboBoxKerdesek.SelectedIndex].KERDESID)];
            }
            catch (Exception)
            {
                comboBoxValasz.SelectedIndex = 0;
            }
        }
        private void FormNormPoll_Load(object sender, EventArgs e)
        {
            UpdateForm();
            if (comboBoxKerdesek.Items.Count > 0)
            {
                comboBoxKerdesek.SelectedIndex = 0;
            }
            //decimal test = dataAccess.GetNextLEADOTTID();
        }
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            bool Error = false;
            string ErrorMessage = "Nem lettek kitöltve ezek a kérdések: ";
            for (int i = 0; i < kerdesek.Count; i++)
            {
                if (newKitoltes[i].EMAIL == null)
                {
                    Error = true;
                    ErrorMessage += $"{kerdesek[i].LEIRAS} ";
                }
            }
            if (Error == false)
            {
                foreach (LEADOTTVALASZOK j in newKitoltes)
                {
                    //Csak azért hogy az ID tényleg korrekt legyen, mert mostani LEADOTTID az csak ideiglenes
                    LEADOTTVALASZOK leadottValasz = new LEADOTTVALASZOK();
                    leadottValasz.LEADOTTID = dataAccess.GetNextLEADOTTID();
                    leadottValasz.EMAIL = j.EMAIL;
                    leadottValasz.KERDESID = j.KERDESID;
                    leadottValasz.VALASZID = j.VALASZID;
                    dataAccess.AddNewLeadottvalasz(leadottValasz);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(ErrorMessage,"Hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            //this.DialogResult = DialogResult.OK;
        }

        private void comboBoxKerdesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFormValaszok();
        }

        private void buttonSaveAnwser_Click(object sender, EventArgs e)
        {
            if (comboBoxValasz.SelectedIndex != -1)
            {
                LEADOTTVALASZOK leadottValasz = new LEADOTTVALASZOK();
                leadottValasz.LEADOTTID = comboBoxKerdesek.SelectedIndex;
                leadottValasz.EMAIL = Variables.User.EMAIL;
                //(KUTATASOK)cmbList.SelectedItem
                leadottValasz.KERDESID = ((KERDESEK)comboBoxKerdesek.SelectedItem).KERDESID;
                leadottValasz.VALASZID = ((VALASZOK)comboBoxValasz.SelectedItem).VALASZID;
                newKitoltes[comboBoxKerdesek.SelectedIndex] = leadottValasz;
            }
        }
    }
}
