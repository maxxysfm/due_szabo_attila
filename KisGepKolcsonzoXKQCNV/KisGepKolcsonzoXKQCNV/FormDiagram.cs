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
using System.Windows.Forms.DataVisualization.Charting;

namespace KisGepKolcsonzoXKQCNV
{
    public partial class FormDiagram : Form
    {
        DataAccess dataAccess;
        public FormDiagram(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();
        }
        private void FormDiagram_Load(object sender, EventArgs e)
        {
            chartMain.Series[0].Points.Clear();
            foreach (double j in dataAccess.Chart())
            {
                DataPoint newDataPoint = new DataPoint();
                newDataPoint.YValues = new[] { (double)j };
                chartMain.Series[0].Points.Add(newDataPoint);
            }
        }
    }
}
