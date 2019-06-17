namespace KözvelemenyKutatas
{
    partial class FormDevkit
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKutatas = new System.Windows.Forms.ComboBox();
            this.labelLimit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.dateTimePickerOverride = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHour = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(431, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(204, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Program indítása";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kijelölt/Aktív kutatás feltöltése random felhasználói adatokkal:";
            // 
            // comboBoxKutatas
            // 
            this.comboBoxKutatas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKutatas.FormattingEnabled = true;
            this.comboBoxKutatas.Location = new System.Drawing.Point(15, 25);
            this.comboBoxKutatas.Name = "comboBoxKutatas";
            this.comboBoxKutatas.Size = new System.Drawing.Size(579, 21);
            this.comboBoxKutatas.TabIndex = 2;
            this.comboBoxKutatas.SelectedIndexChanged += new System.EventHandler(this.comboBoxKutatas_SelectedIndexChanged);
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Location = new System.Drawing.Point(600, 28);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(34, 13);
            this.labelLimit.TabIndex = 3;
            this.labelLimit.Text = "y/x fő";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indításkor alkalmazott dátum:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(485, 51);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Random felhasználó hozzáadása:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Jelenleg résztvevők száma:";
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Location = new System.Drawing.Point(535, 49);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(99, 23);
            this.btnAddRandom.TabIndex = 19;
            this.btnAddRandom.Text = "Hozzáad";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerOverride
            // 
            this.dateTimePickerOverride.Location = new System.Drawing.Point(15, 65);
            this.dateTimePickerOverride.Name = "dateTimePickerOverride";
            this.dateTimePickerOverride.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerOverride.TabIndex = 20;
            // 
            // dateTimePickerHour
            // 
            this.dateTimePickerHour.Location = new System.Drawing.Point(77, 91);
            this.dateTimePickerHour.Name = "dateTimePickerHour";
            this.dateTimePickerHour.ShowUpDown = true;
            this.dateTimePickerHour.Size = new System.Drawing.Size(77, 20);
            this.dateTimePickerHour.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Óra:";
            // 
            // FormDevkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(646, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerHour);
            this.Controls.Add(this.dateTimePickerOverride);
            this.Controls.Add(this.btnAddRandom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLimit);
            this.Controls.Add(this.comboBoxKutatas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDevkit";
            this.Text = "Fejlesztői eszközök";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDevkit_FormClosed);
            this.Load += new System.EventHandler(this.FormDevkit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKutatas;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.DateTimePicker dateTimePickerOverride;
        private System.Windows.Forms.DateTimePicker dateTimePickerHour;
        private System.Windows.Forms.Label label2;
    }
}