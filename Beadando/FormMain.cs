using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class FormMain : Form
    {
        DataAccess dataAccess;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataAccess.Dispose();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataAccess = new DataAccess();
            comboBoxPlayerSelect.DataSource = dataAccess.GetAllCharacter();
        }
        private void comboBoxPlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDisplay.DataSource = dataAccess.GetAllGameByMMR((Character)comboBoxPlayerSelect.SelectedItem);
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            XmlHandler xmlhandler = new XmlHandler();
            List<Game> FilterGames = new List<Game>();
            string filename = $"{((Character)comboBoxPlayerSelect.SelectedItem).Name}";
            foreach (Game x in listBoxDisplay.Items)
            {
                FilterGames.Add(x);
            }
            if (!xmlhandler.WriteXML($"{filename}_Results.xml",FilterGames))
            {
                MessageBox.Show("Sikertelen volt az XML írása!");
            }
            else
            {
                MessageBox.Show($"Az XML file sikeresen létre lett hozva: {filename}");
            }
        }

        private void buttonMostGames_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A legtöbb játék ezen a pályán zajlott: {dataAccess.GetMostPlayedMap()}");
        }

        private void buttonPlayerStatistics_Click(object sender, EventArgs e)
        {
            FormSkillRating formSkillRating = new FormSkillRating(dataAccess);
            formSkillRating.Show();
        }

        private void buttonMMRAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Az 'irl wipe' nevű csapat átlagos MMR-ja: {dataAccess.AverageMMRByTeam("irl wipe")}");
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            FormChart formChart = new FormChart(dataAccess);
            formChart.Show();
        }
    }
}
