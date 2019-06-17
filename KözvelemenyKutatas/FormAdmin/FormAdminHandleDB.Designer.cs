namespace KözvelemenyKutatas
{
    partial class FormAdminHandleDB
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
            this.buttonAddNewKutatas = new System.Windows.Forms.Button();
            this.textBoxKutatasNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerKezdDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVegDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddNewKerdes = new System.Windows.Forms.Button();
            this.comboBoxKerdesAssign = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFoLimit = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKerdes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddNewValasz = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxValasz = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxKerdesDeleteSellected = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonKerdesDeleteSellected = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxValaszDeleteSellected = new System.Windows.Forms.ComboBox();
            this.buttonValaszDeleteSellected = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxKerdesSellect = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVegDatumHour = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKezdDatumHour = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewKerdes = new System.Windows.Forms.DataGridView();
            this.dataGridViewValasz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKerdes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValasz)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewKutatas
            // 
            this.buttonAddNewKutatas.Location = new System.Drawing.Point(12, 454);
            this.buttonAddNewKutatas.Name = "buttonAddNewKutatas";
            this.buttonAddNewKutatas.Size = new System.Drawing.Size(373, 43);
            this.buttonAddNewKutatas.TabIndex = 0;
            this.buttonAddNewKutatas.Text = "Új kutatás hozzáadása";
            this.buttonAddNewKutatas.UseVisualStyleBackColor = true;
            this.buttonAddNewKutatas.Click += new System.EventHandler(this.buttonAddNewKutatas_Click);
            // 
            // textBoxKutatasNev
            // 
            this.textBoxKutatasNev.Location = new System.Drawing.Point(91, 33);
            this.textBoxKutatasNev.MaxLength = 50;
            this.textBoxKutatasNev.Name = "textBoxKutatasNev";
            this.textBoxKutatasNev.Size = new System.Drawing.Size(294, 20);
            this.textBoxKutatasNev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kutatás adatai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kutatás neve:";
            // 
            // dateTimePickerKezdDatum
            // 
            this.dateTimePickerKezdDatum.Location = new System.Drawing.Point(91, 59);
            this.dateTimePickerKezdDatum.Name = "dateTimePickerKezdDatum";
            this.dateTimePickerKezdDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKezdDatum.TabIndex = 4;
            // 
            // dateTimePickerVegDatum
            // 
            this.dateTimePickerVegDatum.Location = new System.Drawing.Point(91, 83);
            this.dateTimePickerVegDatum.Name = "dateTimePickerVegDatum";
            this.dateTimePickerVegDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVegDatum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kezdő dátum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Végző dátum:";
            // 
            // buttonAddNewKerdes
            // 
            this.buttonAddNewKerdes.Location = new System.Drawing.Point(12, 183);
            this.buttonAddNewKerdes.Name = "buttonAddNewKerdes";
            this.buttonAddNewKerdes.Size = new System.Drawing.Size(367, 28);
            this.buttonAddNewKerdes.TabIndex = 10;
            this.buttonAddNewKerdes.Text = "Új kérdés hozzáadása";
            this.buttonAddNewKerdes.UseVisualStyleBackColor = true;
            this.buttonAddNewKerdes.Click += new System.EventHandler(this.buttonAddNewKerdes_Click);
            // 
            // comboBoxKerdesAssign
            // 
            this.comboBoxKerdesAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKerdesAssign.FormattingEnabled = true;
            this.comboBoxKerdesAssign.Location = new System.Drawing.Point(61, 235);
            this.comboBoxKerdesAssign.Name = "comboBoxKerdesAssign";
            this.comboBoxKerdesAssign.Size = new System.Drawing.Size(318, 21);
            this.comboBoxKerdesAssign.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fő limit";
            // 
            // numericUpDownFoLimit
            // 
            this.numericUpDownFoLimit.Location = new System.Drawing.Point(91, 111);
            this.numericUpDownFoLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFoLimit.Name = "numericUpDownFoLimit";
            this.numericUpDownFoLimit.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownFoLimit.TabIndex = 14;
            this.numericUpDownFoLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kutatáshoz kapcsolódó új kérdés:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kérdés:";
            // 
            // textBoxKerdes
            // 
            this.textBoxKerdes.Location = new System.Drawing.Point(61, 157);
            this.textBoxKerdes.MaxLength = 100;
            this.textBoxKerdes.Name = "textBoxKerdes";
            this.textBoxKerdes.Size = new System.Drawing.Size(318, 20);
            this.textBoxKerdes.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(9, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Válaszok hozzáadása a kérdésekhez:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Válasz:";
            // 
            // buttonAddNewValasz
            // 
            this.buttonAddNewValasz.Location = new System.Drawing.Point(12, 283);
            this.buttonAddNewValasz.Name = "buttonAddNewValasz";
            this.buttonAddNewValasz.Size = new System.Drawing.Size(367, 28);
            this.buttonAddNewValasz.TabIndex = 20;
            this.buttonAddNewValasz.Text = "Új válasz hozzáadása a kijelölt kérdéshez";
            this.buttonAddNewValasz.UseVisualStyleBackColor = true;
            this.buttonAddNewValasz.Click += new System.EventHandler(this.buttonAddNewValasz_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Kérdés:";
            // 
            // textBoxValasz
            // 
            this.textBoxValasz.Location = new System.Drawing.Point(61, 260);
            this.textBoxValasz.MaxLength = 50;
            this.textBoxValasz.Name = "textBoxValasz";
            this.textBoxValasz.Size = new System.Drawing.Size(318, 20);
            this.textBoxValasz.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Kérdés:";
            // 
            // comboBoxKerdesDeleteSellected
            // 
            this.comboBoxKerdesDeleteSellected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKerdesDeleteSellected.FormattingEnabled = true;
            this.comboBoxKerdesDeleteSellected.Location = new System.Drawing.Point(61, 340);
            this.comboBoxKerdesDeleteSellected.Name = "comboBoxKerdesDeleteSellected";
            this.comboBoxKerdesDeleteSellected.Size = new System.Drawing.Size(318, 21);
            this.comboBoxKerdesDeleteSellected.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(9, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(346, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Kutatáshoz kapcsolódó kérdések/válaszok törlése:";
            // 
            // buttonKerdesDeleteSellected
            // 
            this.buttonKerdesDeleteSellected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonKerdesDeleteSellected.Location = new System.Drawing.Point(298, 367);
            this.buttonKerdesDeleteSellected.Name = "buttonKerdesDeleteSellected";
            this.buttonKerdesDeleteSellected.Size = new System.Drawing.Size(81, 24);
            this.buttonKerdesDeleteSellected.TabIndex = 26;
            this.buttonKerdesDeleteSellected.Text = "Törlés";
            this.buttonKerdesDeleteSellected.UseVisualStyleBackColor = false;
            this.buttonKerdesDeleteSellected.Click += new System.EventHandler(this.buttonKerdesDeleteSellected_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Válasz";
            // 
            // comboBoxValaszDeleteSellected
            // 
            this.comboBoxValaszDeleteSellected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValaszDeleteSellected.FormattingEnabled = true;
            this.comboBoxValaszDeleteSellected.Location = new System.Drawing.Point(61, 397);
            this.comboBoxValaszDeleteSellected.Name = "comboBoxValaszDeleteSellected";
            this.comboBoxValaszDeleteSellected.Size = new System.Drawing.Size(318, 21);
            this.comboBoxValaszDeleteSellected.TabIndex = 27;
            // 
            // buttonValaszDeleteSellected
            // 
            this.buttonValaszDeleteSellected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonValaszDeleteSellected.Location = new System.Drawing.Point(298, 424);
            this.buttonValaszDeleteSellected.Name = "buttonValaszDeleteSellected";
            this.buttonValaszDeleteSellected.Size = new System.Drawing.Size(81, 24);
            this.buttonValaszDeleteSellected.TabIndex = 29;
            this.buttonValaszDeleteSellected.Text = "Törlés";
            this.buttonValaszDeleteSellected.UseVisualStyleBackColor = false;
            this.buttonValaszDeleteSellected.Click += new System.EventHandler(this.buttonValaszDeleteSellected_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(388, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Összes kérdés:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(807, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Összes válasz a kiválasztott kérdésre:";
            // 
            // comboBoxKerdesSellect
            // 
            this.comboBoxKerdesSellect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKerdesSellect.Enabled = false;
            this.comboBoxKerdesSellect.FormattingEnabled = true;
            this.comboBoxKerdesSellect.Location = new System.Drawing.Point(810, 33);
            this.comboBoxKerdesSellect.Name = "comboBoxKerdesSellect";
            this.comboBoxKerdesSellect.Size = new System.Drawing.Size(404, 21);
            this.comboBoxKerdesSellect.TabIndex = 33;
            this.comboBoxKerdesSellect.SelectedIndexChanged += new System.EventHandler(this.comboBoxKerdesSellect_SelectedIndexChanged);
            // 
            // dateTimePickerVegDatumHour
            // 
            this.dateTimePickerVegDatumHour.Location = new System.Drawing.Point(297, 84);
            this.dateTimePickerVegDatumHour.Name = "dateTimePickerVegDatumHour";
            this.dateTimePickerVegDatumHour.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerVegDatumHour.TabIndex = 34;
            // 
            // dateTimePickerKezdDatumHour
            // 
            this.dateTimePickerKezdDatumHour.Location = new System.Drawing.Point(297, 60);
            this.dateTimePickerKezdDatumHour.Name = "dateTimePickerKezdDatumHour";
            this.dateTimePickerKezdDatumHour.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerKezdDatumHour.TabIndex = 35;
            // 
            // dataGridViewKerdes
            // 
            this.dataGridViewKerdes.AllowUserToAddRows = false;
            this.dataGridViewKerdes.AllowUserToDeleteRows = false;
            this.dataGridViewKerdes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKerdes.Enabled = false;
            this.dataGridViewKerdes.Location = new System.Drawing.Point(391, 33);
            this.dataGridViewKerdes.Name = "dataGridViewKerdes";
            this.dataGridViewKerdes.ReadOnly = true;
            this.dataGridViewKerdes.Size = new System.Drawing.Size(413, 464);
            this.dataGridViewKerdes.TabIndex = 36;
            // 
            // dataGridViewValasz
            // 
            this.dataGridViewValasz.AllowUserToAddRows = false;
            this.dataGridViewValasz.AllowUserToDeleteRows = false;
            this.dataGridViewValasz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValasz.Enabled = false;
            this.dataGridViewValasz.Location = new System.Drawing.Point(810, 59);
            this.dataGridViewValasz.Name = "dataGridViewValasz";
            this.dataGridViewValasz.ReadOnly = true;
            this.dataGridViewValasz.Size = new System.Drawing.Size(404, 438);
            this.dataGridViewValasz.TabIndex = 37;
            // 
            // FormAdminHandleDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1217, 501);
            this.Controls.Add(this.dataGridViewValasz);
            this.Controls.Add(this.dataGridViewKerdes);
            this.Controls.Add(this.dateTimePickerKezdDatumHour);
            this.Controls.Add(this.dateTimePickerVegDatumHour);
            this.Controls.Add(this.comboBoxKerdesSellect);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonValaszDeleteSellected);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxValaszDeleteSellected);
            this.Controls.Add(this.buttonKerdesDeleteSellected);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxKerdesDeleteSellected);
            this.Controls.Add(this.textBoxValasz);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonAddNewValasz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKerdes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownFoLimit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxKerdesAssign);
            this.Controls.Add(this.buttonAddNewKerdes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerVegDatum);
            this.Controls.Add(this.dateTimePickerKezdDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKutatasNev);
            this.Controls.Add(this.buttonAddNewKutatas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAdminHandleDB";
            this.Text = "Kutatás hozzáadása";
            this.Load += new System.EventHandler(this.FormAdminHandleDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKerdes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValasz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewKutatas;
        private System.Windows.Forms.TextBox textBoxKutatasNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerKezdDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerVegDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddNewKerdes;
        private System.Windows.Forms.ComboBox comboBoxKerdesAssign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownFoLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKerdes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddNewValasz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxValasz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxKerdesDeleteSellected;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonKerdesDeleteSellected;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxValaszDeleteSellected;
        private System.Windows.Forms.Button buttonValaszDeleteSellected;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxKerdesSellect;
        private System.Windows.Forms.DateTimePicker dateTimePickerVegDatumHour;
        private System.Windows.Forms.DateTimePicker dateTimePickerKezdDatumHour;
        private System.Windows.Forms.DataGridView dataGridViewKerdes;
        private System.Windows.Forms.DataGridView dataGridViewValasz;
    }
}