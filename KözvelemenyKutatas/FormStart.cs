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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }
        //Megfelelő zárás szükséges CloseForm
        private void btnDevKit_Click(object sender, EventArgs e)
        {
            FormDevkit NormalFormStart = new FormDevkit();
            this.Hide();
            NormalFormStart.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormCheckXML FormStartRegular = new FormCheckXML();
            this.Hide();
            FormStartRegular.ShowDialog();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            //lehet fölösleges, de why not?
            //Variables.CurrentDate = DateTime.Now;
        }
    }
}
