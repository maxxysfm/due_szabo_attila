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
namespace Beadando
{
    public partial class FormChart : Form
    {
        DataAccess dataAccess;
        public FormChart(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            chartMain.Series[0].Points.Clear();
            foreach (Tuple<decimal, decimal> j in dataAccess.Chart())
            {
                DataPoint newDataPoint = new DataPoint();
                newDataPoint.Label = $"{(dataAccess.GetCharacterById(j.Item1)).Name}: {(double)j.Item2}";
                newDataPoint.YValues = new[] { (double)j.Item2 };
                chartMain.Series[0].Points.Add(newDataPoint);
            }
        }
    }
}
