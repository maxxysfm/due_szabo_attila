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
    public partial class FormSkillRating : Form
    {
        DataAccess dataAccess;
        public FormSkillRating(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();
        }

        private void FormSkillRating_Load(object sender, EventArgs e)
        {
            listBoxDisplay.DataSource = dataAccess.GetAllGameByMMR();
        }
    }
}
