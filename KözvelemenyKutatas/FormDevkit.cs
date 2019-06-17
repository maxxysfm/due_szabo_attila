using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace KözvelemenyKutatas
{
    public partial class FormDevkit : Form
    {
        DataAccess dataAccess;
        public FormDevkit()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
            RefreshForm();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //DateTime date = DateTime.ParseExact(Convert.ToString(dateTimePickerOverride.Text), "yyyy.MM.dd. HH:mm:ss", CultureInfo.CurrentCulture);
            Variables.CurrentDate = dateTimePickerOverride.Value.Date 
                + dateTimePickerHour.Value.TimeOfDay;
            FormCheckXML FormStartRegular = new FormCheckXML();
            this.Hide();
            FormStartRegular.ShowDialog();
        }
        public void RefreshForm()
        {
            comboBoxKutatas.Items.Clear();
            foreach (var j in dataAccess.GetAllKutatas())
            {
                comboBoxKutatas.Items.Add(j);
            }
            if (comboBoxKutatas.Items.Count > 0)
            {
                comboBoxKutatas.SelectedIndex = 0;
            }
        }
        private void FormDevkit_Load(object sender, EventArgs e)
        {
            dateTimePickerHour.Format = DateTimePickerFormat.Time;
            dateTimePickerHour.ShowUpDown = true;
        }
        public void RefreshCount()
        {
            labelLimit.Text = $"{dataAccess.GetAllAvailableSlotsNumber((KUTATASOK)comboBoxKutatas.SelectedItem)}/{((KUTATASOK)comboBoxKutatas.SelectedItem).FOLIMIT} fő";
        }
        private void comboBoxKutatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCount();
        }

        private void FormDevkit_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataAccess.Dispose();
            Application.Exit();
        }
    }
}
