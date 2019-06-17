using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KözvelemenyKutatas
{
    public partial class FormAdminViewGraph : Form
    {
        DataAccess dataAccess;
        KUTATASOK displayedKutatas;
        public FormAdminViewGraph(DataAccess dataAccess, KUTATASOK kutatasDisplay = null)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
            displayedKutatas = kutatasDisplay ?? new KUTATASOK();
            //dataAccess = new DataAccess();
        }

        private void FormAdminViewGraph_Load(object sender, EventArgs e)
        {
            //var result = dataAccess.DiagrammTest();
            ////chartMain.DataSource = result;
            //chartMain.Series[0].Points.Clear();
            //foreach (var item in result)
            //{
            //    DataPoint newDP = new DataPoint();
            //    newDP.SetValueXY(5,5);
            //}
            comboBoxNem.Items.Add("<Összes>");
            comboBoxNem.Items.Add("Férfi");
            //comma
            comboBoxNem.Items.Add("Nő");
            comboBoxNem.SelectedIndex = 0;
            comboBoxVegzettseg.Items.Add("<Összes>");
            comboBoxVegzettseg.Items.AddRange(Variables.Vegzettseg);
            comboBoxVegzettseg.SelectedIndex = 0;
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (comboBoxNem.SelectedIndex == 0 && comboBoxVegzettseg.SelectedIndex == 0)
            {
                chartMain.Series[0].Points.Clear();
                foreach (Tuple<string, decimal> j in dataAccess.Diagramm(displayedKutatas, numericUpDownAgeMin.Value, numericUpDownAgeMax.Value))
                {
                    DataPoint newDataPoint = new DataPoint();
                    newDataPoint.Label = $"{j.Item1}: {(double)j.Item2}";
                    newDataPoint.YValues = new[] { (double)j.Item2 };
                    chartMain.Series[0].Points.Add(newDataPoint);
                }
            }
            else if (comboBoxNem.SelectedIndex == 0 && comboBoxVegzettseg.SelectedIndex != 0)
            {
                //dataAccess.DiagrammVegzettsegOnly(displayedKutatas, numericUpDownAgeMin.Value, numericUpDownAgeMax.Value, (string)comboBoxVegzettseg.SelectedItem);
                chartMain.Series[0].Points.Clear();
                foreach (Tuple<string, decimal> j in dataAccess.DiagrammVegzettsegOnly(displayedKutatas, numericUpDownAgeMin.Value, numericUpDownAgeMax.Value, (string)comboBoxVegzettseg.SelectedItem))
                {
                    DataPoint newDataPoint = new DataPoint();
                    newDataPoint.Label = $"{j.Item1}: {(double)j.Item2}";
                    newDataPoint.YValues = new[] { (double)j.Item2 };
                    chartMain.Series[0].Points.Add(newDataPoint);
                }

            }
            else if (comboBoxNem.SelectedIndex != 0 && comboBoxVegzettseg.SelectedIndex == 0)
            {
                //dataAccess.DiagrammGendreOnly(displayedKutatas, numericUpDownAgeMin.Value, numericUpDownAgeMax.Value, (string)comboBoxNem.SelectedItem);
                chartMain.Series[0].Points.Clear();
                foreach (Tuple<string, decimal> j in dataAccess.DiagrammGendreOnly(displayedKutatas, numericUpDownAgeMin.Value, numericUpDownAgeMax.Value, (string)comboBoxNem.SelectedItem))
                {
                    DataPoint newDataPoint = new DataPoint();
                    newDataPoint.Label = $"{j.Item1}: {(double)j.Item2}";
                    newDataPoint.YValues = new[] { (double)j.Item2 };
                    chartMain.Series[0].Points.Add(newDataPoint);
                }
            }
            else if (comboBoxNem.SelectedIndex != 0 && comboBoxVegzettseg.SelectedIndex != 0)
            {
                //var DisplayList = dataAccess.DiagrammAll(displayedKutatas, numericUpDownAgeMin.Value, numericUpDownAgeMax.Value, (string)comboBoxNem.SelectedItem, (string)comboBoxVegzettseg.SelectedItem);
                ////chartMain.DataSource = DisplayList;
                //RefreshChart(DisplayList);
                chartMain.Series[0].Points.Clear();
                foreach (Tuple<string, decimal> j in dataAccess.DiagrammAll(displayedKutatas, numericUpDownAgeMin.Value, numericUpDownAgeMax.Value, (string)comboBoxNem.SelectedItem, (string)comboBoxVegzettseg.SelectedItem))
                {
                    DataPoint newDataPoint = new DataPoint();
                    newDataPoint.Label = $"{j.Item1}: {(double)j.Item2}";
                    newDataPoint.YValues = new[] { (double)j.Item2 };
                    chartMain.Series[0].Points.Add(newDataPoint);
                }
            }
        }
    }
}
