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
    public partial class FormAdminViewDB : Form
    {
        DataAccess dataAccess;
        KUTATASOK displayedKutatas;
        List<KERDESEK> displayedKerdesek = new List<KERDESEK>();
        List<VALASZOK> displayedValaszok = new List<VALASZOK>();
        public FormAdminViewDB(DataAccess dataAccess, KUTATASOK kutatasDisplay = null)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
            displayedKutatas = kutatasDisplay ?? new KUTATASOK();
            RefreshForm();
            RefreshValaszok();
            comboBoxKerdesAll.SelectedIndex = 0;
        }
        public void RefreshForm()
        {
            comboBoxKerdesAll.DataSource = null;
            comboBoxKerdesAll.DataSource = dataAccess.GetAllKerdesForResearch(displayedKutatas);
        }
        private void FormAdminViewDB_Load(object sender, EventArgs e)
        {
            labelKutatasName.Text = displayedKutatas.KUTATASNEV;
            RefreshForm();
        }

        private void comboBoxKerdesAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValaszok();
        }
        public void RefreshValaszok()
        {
            if (comboBoxKerdesAll.SelectedIndex != -1 && comboBoxKerdesAll.Items.Count != 0 && dataAccess.GetAllAvailableSlotsNumber(displayedKutatas) != 0)
            {
                //var ListValaszokFilter = dataAccess.GetAllLeadottvalaszForResearch(displayedKutatas).Where(x => x.KERDESID == ((KERDESEK)comboBoxKerdesAll.SelectedItem).KERDESID);
                this.dataGridViewValaszok.DataSource = null;
                this.dataGridViewValaszok.Rows.Clear();
                this.dataGridViewValaszok.Columns.Clear();
                dataGridViewValaszok.DataSource = dataAccess.GetAllLeadottvalaszForResearch(displayedKutatas).Where(x => x.KERDESID == ((KERDESEK)comboBoxKerdesAll.SelectedItem).KERDESID).ToList();
                DataGridViewColumn edit_column = dataGridViewValaszok.Columns[1];
                edit_column.Width = 175;
                dataGridViewValaszok.Columns["LEADOTTID"].Visible = false;
                dataGridViewValaszok.Columns["KERDESID"].Visible = false;
                dataGridViewValaszok.Columns["VALASZID"].Visible = false;
                dataGridViewValaszok.Columns["FELHASZNALOIADATOK"].Visible = false;
                dataGridViewValaszok.Columns["KERDESEK"].Visible = false;
                dataGridViewValaszok.Columns["VALASZOK"].Visible = false;
                var column = new DataGridViewTextBoxColumn();
                column.Name = "Leírás:";
                column.Width = 275;
                dataGridViewValaszok.Columns.Insert(3, column);
                for (int i = 0; i < dataGridViewValaszok.Rows.Count; i++)
                {
                    dataGridViewValaszok.Rows[i].Cells[3].Value = (dataAccess.GetAllVALASZOK().Where(x=>x.VALASZID == (decimal)dataGridViewValaszok.Rows[i].Cells[4].Value).Single()).LEIRAS;
                }
            }
        }
    }
}
