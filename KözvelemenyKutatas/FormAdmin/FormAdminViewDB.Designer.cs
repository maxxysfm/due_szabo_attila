namespace KözvelemenyKutatas
{
    partial class FormAdminViewDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelKutatasName = new System.Windows.Forms.Label();
            this.labelKerdes = new System.Windows.Forms.Label();
            this.comboBoxKerdesAll = new System.Windows.Forms.ComboBox();
            this.dataGridViewValaszok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValaszok)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(3, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(287, 24);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "E-Mail szerint beérkező válaszok:";
            // 
            // labelKutatasName
            // 
            this.labelKutatasName.AutoSize = true;
            this.labelKutatasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKutatasName.Location = new System.Drawing.Point(4, 25);
            this.labelKutatasName.Name = "labelKutatasName";
            this.labelKutatasName.Size = new System.Drawing.Size(111, 18);
            this.labelKutatasName.TabIndex = 10;
            this.labelKutatasName.Text = "<Kutatás neve>";
            // 
            // labelKerdes
            // 
            this.labelKerdes.AutoSize = true;
            this.labelKerdes.Location = new System.Drawing.Point(4, 43);
            this.labelKerdes.Name = "labelKerdes";
            this.labelKerdes.Size = new System.Drawing.Size(43, 13);
            this.labelKerdes.TabIndex = 12;
            this.labelKerdes.Text = "Kérdés:";
            // 
            // comboBoxKerdesAll
            // 
            this.comboBoxKerdesAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKerdesAll.FormattingEnabled = true;
            this.comboBoxKerdesAll.Location = new System.Drawing.Point(7, 59);
            this.comboBoxKerdesAll.Name = "comboBoxKerdesAll";
            this.comboBoxKerdesAll.Size = new System.Drawing.Size(497, 21);
            this.comboBoxKerdesAll.TabIndex = 11;
            this.comboBoxKerdesAll.SelectedIndexChanged += new System.EventHandler(this.comboBoxKerdesAll_SelectedIndexChanged);
            // 
            // dataGridViewValaszok
            // 
            this.dataGridViewValaszok.AllowUserToAddRows = false;
            this.dataGridViewValaszok.AllowUserToDeleteRows = false;
            this.dataGridViewValaszok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValaszok.Enabled = false;
            this.dataGridViewValaszok.Location = new System.Drawing.Point(7, 86);
            this.dataGridViewValaszok.Name = "dataGridViewValaszok";
            this.dataGridViewValaszok.ReadOnly = true;
            this.dataGridViewValaszok.Size = new System.Drawing.Size(500, 487);
            this.dataGridViewValaszok.TabIndex = 13;
            // 
            // FormAdminViewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(516, 586);
            this.Controls.Add(this.dataGridViewValaszok);
            this.Controls.Add(this.labelKerdes);
            this.Controls.Add(this.comboBoxKerdesAll);
            this.Controls.Add(this.labelKutatasName);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAdminViewDB";
            this.Text = "Kutatás megtekintése";
            this.Load += new System.EventHandler(this.FormAdminViewDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValaszok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelKutatasName;
        private System.Windows.Forms.Label labelKerdes;
        private System.Windows.Forms.ComboBox comboBoxKerdesAll;
        private System.Windows.Forms.DataGridView dataGridViewValaszok;
    }
}