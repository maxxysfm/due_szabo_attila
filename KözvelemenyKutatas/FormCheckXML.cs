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
    public partial class FormCheckXML : Form
    {
        DataAccess dataAccess;
        public FormCheckXML()
        {
            InitializeComponent();
            //Lehetne DataAccess-al visszaadott érték is ha frissülne a hossza.
            //varchar(50)
            //lehet az adatbázisban 50 a max de hogy formba kiférjen most 32 tűnik ideális hossznak
            txtEmail.MaxLength = 32;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Nem túl fancy hiba kezelés, csak hogy ne legyen üres email, feltételezzük mindenki jól írja be az email címét. kappa
            if (txtEmail.Text.Length < 10)
            {
                MessageBox.Show($"Túl rövid az E-mail cím!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //PROGRAM elindulásának módja, ha admin vagy, akkor nem kellenek a felhasználói adatok.
                if (comboBoxMode.SelectedIndex == 1)
                {
                    dataAccess.KutatasLockCheckByDate();
                    FormAdmin FormAdminStart = new FormAdmin();
                    FormAdminStart.ShowDialog();
                }
                else
                {
                    dataAccess.GetAllAvailableKutatasToUser(Variables.User);
                    //Már megvan szabva a dátum a rendszerben.
                    dataAccess.KutatasLockCheckByDate();
                    //Hozzáadás + tovább lépés mod szerint
                    this.Hide();
                    //A form-ba ha végeztünk bármi szerkesztést az adatokon, akkor azok kerülnek beolvasásra. A newUser változót használjuk még mindig.
                    //ADATOK
                    //1. EMAIL: A hossz megszabható lenne a varchar(50) alapján is, külön hibaüzenettel, de ehelyett a textbox MaxLength-jét írtuk át 50-re.
                    Variables.User.EMAIL = txtEmail.Text;
                    //2. NEM:
                    Variables.User.NEM = cmbNem.Text;
                    //3. KOR: (Ez az érték mindig bele fog férni, mivel csak 1-100)
                    Variables.User.KOR = Convert.ToInt32(numericUpDownKor.Text);
                    //4. VEGZETTSEG:
                    Variables.User.VEGZETTSEG = cmbVegzettseg.Text;
                    if (!dataAccess.UserExists(Variables.User))
                    {
                        MessageBox.Show("Új felhasználó hozzáadva!", "Belépés");
                        dataAccess.AddNewUser(Variables.User);
                    }
                    else
                    {
                        MessageBox.Show("A felhasználó adatai frissültek!", "Belépés");
                        dataAccess.RefreshUser(Variables.User);
                    }
                    FormNorm FormNormStart = new FormNorm();
                    this.Hide();
                    FormNormStart.ShowDialog();
                }
            }
        }
        private void FormCheckXML_Load(object sender, EventArgs e)
        {
            ///XML-ből való beolvasás.
            ///Az összes adat elemzése alapján töltődnek fel a Form emeljei.
            ///Ha nem sikerül az XML beolvasása, akkor alapértékek legyenek beállítva
            dataAccess = new DataAccess();
            XMLRead xmlReading = new XMLRead();
            if (!xmlReading.ReadFromXML(Variables.XMLFileName, out Variables.User))
            {
                //Default értékek ha új felhasználót csinálunk XML nélkül
                Variables.User.EMAIL = "";
                Variables.User.NEM = "Férfi";
                Variables.User.KOR = 18;
                Variables.User.VEGZETTSEG = Variables.Vegzettseg[0];
                //MessageBox.Show($"Az XML beolvasása sikertelen volt, töltse ki manuálisan a mezőket.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                xmlReading.ReadFromXML(Variables.XMLFileName, out Variables.User);
                //MessageBox.Show($"Az XML beolvasása sikeres volt!", "Sikeres beolvasás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Sorrend ha megváltozik, akkor SelectedIndex nem működik megfelelően
            comboBoxMode.Items.Add("Normál");
            comboBoxMode.Items.Add("Admin");
            cmbNem.Items.Add("Férfi");
            cmbNem.Items.Add("Nő");
            //XML alapján:
            // 1. MODE:
            if (Variables.ProgramMode == true)
            {
                comboBoxMode.SelectedItem = "Admin";
            }
            else
            {
                comboBoxMode.SelectedItem = "Normál";
            }
            // 2. EMAIL:
            txtEmail.Text = Variables.User.EMAIL;
            // 3. NEM:
            if (Variables.User.NEM== "Nő")
            {
                cmbNem.SelectedItem = "Nő";
            }
            else
            {
                cmbNem.SelectedItem = "Férfi";
            }
            // 4. 5. Kor/Végzettség
            foreach (var vegz in Variables.Vegzettseg)
            {
                cmbVegzettseg.Items.Add(vegz);
            }
            cmbVegzettseg.SelectedItem = Variables.User.VEGZETTSEG;
            numericUpDownKor.Value = Variables.User.KOR;
        }

        private void FormCheckXML_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataAccess.Dispose();
            Application.Exit();
        }
    }
}
